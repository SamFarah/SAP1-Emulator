using BitField;
using System;

namespace SAP2Modules
{
    public class FlagsRegister : Register
    {
        public FlagBitField FlagsBits; //its data is in the form of bitField
        public override UInt16 Data { get { return FlagsBits; } } //return the bitField

        public FlagsRegister(UInt16 mask = 0xFFFF) : base(mask, mask)
        {
            Enable = true; // A flag register is always enabled
            FlagsBits = new FlagBitField();
        }

        //Bit Field Definition
        [BitFieldNumberOfBits(2)]
        public struct FlagBitField : IBitField
        {
            [BitFieldInfo(2, 1)] public bool MinusFlag { get; set; }
            [BitFieldInfo(1, 1)] public bool ZeroFlag { get; set; }
            [BitFieldInfo(0, 1)] public bool CarryFlag { get; set; }

            //easily convert between the bitfield and byte
            public static implicit operator UInt16(FlagBitField content) => (UInt16)content.ToUInt64();
            public static explicit operator FlagBitField(ulong content) => BitFieldExtensions.CreateBitField<FlagBitField>(content);
        }
    }
}