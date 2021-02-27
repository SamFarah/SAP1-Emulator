using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;
using System.Collections;
using System.Data;
using System.Diagnostics;

namespace SAP1Modules
{
    public class Assembler
    {
        public enum Instructions
        {
            NOP = 0x00,
            LDA = 0x01,
            ADD = 0x02,
            SUB = 0x03,
            STA = 0x04,
            LDI = 0x05,
            JMP = 0x06,
            JC = 0x07,
            JZ = 0x08,
            //  <Future Use Instruction> = 0x09
            //  <Future Use Instruction> = 0x0A
            //  <Future Use Instruction> = 0x0B
            //  <Future Use Instruction> = 0x0C
            //  <Future Use Instruction> = 0x0D
            OUT = 0x0E,
            HLT = 0x0F
        }

        public List<AssemblyCommand> Commands;
        public List<AssemblyVariable> Variables;
        public List<string> Errors;
        private bool isData { get; set; }
        public Assembler()
        {
            Commands = new List<AssemblyCommand>();
            Variables = new List<AssemblyVariable>();
            Errors = new List<string>(); // Store errors while generating machine code            
            isData = false;
        }

        public void GenerateCommands(string[] lines)
        {
            Regex CommandRegex = new Regex("(?<Label>.+:)?[ \\t]*(?<Instruction>\\w{2,3})[ \\t]*(?<Operands>\\$[A-Za-z\\d]+)?[ \\t]*(?<Address>\\w*)[ \\t]*(?<Comment>;+ *\\w*)?");
            Regex DataRegex = new Regex("^[ \\t]*(?<VarName>[A-Za-z]+\\w*)[ \\t]+(?<Value>\\$[A-Za-z\\d]+)[ \\t]*(?<Comment>;+.*)?$");

            foreach (string line in lines)
            {

                if (string.IsNullOrEmpty(line.Trim()) || line.Trim().StartsWith(";")) continue;


                if (line == ".CODE")
                {
                    isData = false;
                    continue;
                }

                if (line == ".DATA")
                {
                    isData = true;
                    continue;
                }


                if (!isData) //reading commands
                {
                    string label = string.Empty;
                    string inst = string.Empty;
                    string operand = string.Empty;
                    string address = string.Empty;
                    string comment = string.Empty;

                    var Res = CommandRegex.Match(line);
                    if (!Res.Success) continue;

                    label = Res.Groups["Label"].Value.Replace(":", "").Trim();
                    inst = Res.Groups["Instruction"].Value.ToUpper();
                    operand = Res.Groups["Operands"].Value.Replace("$", "");
                    address = Res.Groups["Address"].Value;
                    comment = Res.Groups["Comment"].Value.Replace(";", "").Trim();

                    byte temp = 0x01;
                    byte.TryParse(operand, System.Globalization.NumberStyles.HexNumber, null as IFormatProvider, out temp);

                    try
                    {
                        Commands.Add(new AssemblyCommand()
                        {
                            Address = (byte)Commands.Count,
                            Label = label,
                            Instruction = (Instructions)Enum.Parse(typeof(Instructions), inst),
                            Operand = temp,
                            OpAddress = address,
                            Comment = comment
                        });
                    }
                    catch (Exception) { Errors.Add($"could not recognize {inst} as an instruction"); }
                }
                else // reading data
                {

                    string varName = string.Empty;
                    string value = string.Empty;
                    string comment = string.Empty;

                    var Res = DataRegex.Match(line);
                    if (!Res.Success)
                    {
                        Errors.Add($"could not parse the line: {line}");
                        continue;
                    }

                    varName = Res.Groups["VarName"].Value.Trim();
                    value = Res.Groups["Value"].Value.Replace("$", "");
                    comment = Res.Groups["Comment"].Value.Replace(";", "").Trim();

                    byte temp = 0x01;
                    byte.TryParse(value, System.Globalization.NumberStyles.HexNumber, null as IFormatProvider, out temp);

                    try
                    {
                        Variables.Add(new AssemblyVariable()
                        {
                            Address = (byte)(15 - Variables.Count), // put variables on bottom
                            Name = varName,
                            Value = temp,
                            Comment = comment

                        });
                    }
                    catch (Exception) { Errors.Add($"could not add variable: {line}"); }
                }
            }
            if (Validate())
            {
                foreach (AssemblyCommand Command in Commands.Where(x => !string.IsNullOrEmpty(x.OpAddress)))
                {
                    //Find label,var address
                    AssemblyCommand CommandAtAddress = Commands.Where(x => x.Label.Trim().ToLower() == Command.OpAddress.Trim().ToLower()).FirstOrDefault();
                    if (CommandAtAddress != null) Command.Operand = CommandAtAddress.Address;
                    else
                    {
                        AssemblyVariable VariableAttAddress = Variables.Where(x => x.Name == Command.OpAddress).FirstOrDefault();
                        if (VariableAttAddress != null) Command.Operand = VariableAttAddress.Address;
                        else Errors.Add($"could not find label or variable: {Command.OpAddress}");
                    }

                }
            }
        }
        public bool Validate()
        {
            //find duplicate labels:
            var duplicateLabels = Commands
                                .Where(x => !string.IsNullOrEmpty(x.Label.Trim()))
                                .Select(x => x.Label.ToUpper())
                                .GroupBy(x => x)
                                .Where(g => g.Count() > 1)
                                .Select(y => new { Element = y.Key, Counter = y.Count() })
                                .ToList();

            if (duplicateLabels.Count > 0) Errors.AddRange(duplicateLabels.Select(x => $"The label \"{x.Element }\" was defined {x.Counter} times"));

            //find duplicate variables:
            var duplicateVariables = Variables
                                .Where(x => !string.IsNullOrEmpty(x.Name.Trim()))
                                .Select(x => x.Name)
                                .GroupBy(x => x)
                                .Where(g => g.Count() > 1)
                                .Select(y => new { Element = y.Key, Counter = y.Count() })
                                .ToList();

            if (duplicateVariables.Count > 0) Errors.AddRange(duplicateVariables.Select(x => $"The variable \"{x.Element }\" was defined {x.Counter} times"));

            return Errors.Count == 0;
        }

        public byte[] GetMachineCode(bool RandomizeBlanks)
        {
            byte[] retVal = new byte[16];
            if (RandomizeBlanks) Utilities.RadomizeArray(retVal);
            foreach (AssemblyCommand command in Commands) retVal[command.Address] = (byte)(((byte)command.Instruction << 4) | (command.Operand & 0x0F));            
            foreach (AssemblyVariable variable in Variables) retVal[variable.Address] = variable.Value;           
            return retVal;
        }
    }

    public class AssemblyCommand
    {
        public byte Address { get; set; }
        public string Label { get; set; }
        public Assembler.Instructions Instruction { get; set; }
        public byte Operand { get; set; }
        public string OpAddress { get; set; }
        public string Comment { get; set; }
    }

    public class AssemblyVariable
    {
        public byte Address { get; set; }
        public string Name { get; set; }
        public byte Value { get; set; }
        public string Comment { get; set; }
    }
}
