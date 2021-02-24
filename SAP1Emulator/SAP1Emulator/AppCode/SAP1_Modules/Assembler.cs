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
    class Assembler
    {
        public enum Instructions
        {
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
        public Assembler()
        {
            Commands = new List<AssemblyCommand>();
        }

        public void GenerateCommands(string[] lines)
        {
            Regex regex = new Regex("(?<Label>.+:)? *(?<Instruction>\\w{2,3}) +(?<Byte>[^\\s]+)? *;?(?<Comment>.*)?");

            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line)) continue;
                var Res = regex.Match(line);
                if (!Res.Success) continue;
                byte temp = 0x01;
                byte.TryParse(Res.Groups["Byte"].Value.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber, null as IFormatProvider, out temp);

                Commands.Add(new AssemblyCommand()
                {
                    Address = (byte)Commands.Count,
                    Label = Res.Groups["Label"].Value,
                    Instruction = (Instructions)Enum.Parse(typeof(Instructions), Res.Groups["Instruction"].Value.ToUpper()),
                    Byte = temp,
                    Comment = Res.Groups["Comment"].Value
                });

            }
        }
        public bool Validate()
        {
            //validate code
            return true;
        }

        public byte[] GetMachineCode()
        {
            byte[] retVal = new byte[16];
            foreach (AssemblyCommand command in Commands)
            {
                retVal[command.Address] = (byte)(((byte)command.Instruction << 4) | (command.Byte & 0x0F));
            }
            return retVal;
        }

    }

    class AssemblyCommand
    {
        public byte Address { get; set; }
        public string Label { get; set; }
        public Assembler.Instructions Instruction { get; set; }
        public byte Byte;
        public string Comment { get; set; }
    }
}
