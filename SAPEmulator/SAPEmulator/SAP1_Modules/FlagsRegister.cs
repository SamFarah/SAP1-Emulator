using BitField;
namespace SAP1Modules
{
    public class FlagsRegister : Register
    {
        public FlagBitField FlagsBits; //its data is in the form of bitField
        public override byte Data { get { return FlagsBits; } } //return the bitField

        public FlagsRegister(byte mask = 0xff) : base(mask, mask)
        {
            Enable = true; // A flag register is always enabled
            FlagsBits = new FlagBitField();
        }

        //Bit Field Definition
        [BitFieldNumberOfBits(2)]
        public struct FlagBitField : IBitField
        {
            [BitFieldInfo(1, 1)] public bool ZeroFlag { get; set; }
            [BitFieldInfo(0, 1)] public bool CarryFlag { get; set; }

            //easily convert between the bitfield and byte
            public static implicit operator byte(FlagBitField content) => (byte)content.ToUInt64();
            public static explicit operator FlagBitField(ulong content) => BitFieldExtensions.CreateBitField<FlagBitField>(content);
        }
    }
}