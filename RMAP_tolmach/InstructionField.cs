using System;
using System.Collections;
using System.Text;

namespace RMAP_tolmach
{
    class InstructionField : Field
    {
        public PacketType PacketType { get; set; }
        public CommandField CommandType { get; set; }
        public AddressLength AddressLength { get; set; }

        public InstructionField()
        {
            Name = "Instruction";
            Width = 1;
            this.bytes = new byte[] { 0 };
            this.Empty = false;

            PacketType = new PacketType();
            CommandType = new CommandField();
            AddressLength = new AddressLength();
        }
        public InstructionField(byte value)
        {
            Name = "Instruction";
            Width = 1;
            this.bytes = new byte[] { value};
            this.Empty = false;

            PacketType = new PacketType(value);
            CommandType = new CommandField(value);
            AddressLength = new AddressLength(value);
        }

        public int ReplyAddressLength
        {
            get
            {
                return AddressLength.ToInt();
            }
        }

        public override void Set(string newValue)
        {
            base.Set(newValue);
            if (base.Fail)
            {
                PacketType = new PacketType(0xff);
                CommandType = new CommandField(0);
                AddressLength = new AddressLength(0);
            }
            else
            {
                PacketType = new PacketType(this.bytes[0]);
                CommandType = new CommandField(this.bytes[0]);
                AddressLength = new AddressLength(this.bytes[0]);
            }
        }
        public override void Set(byte newValue)
        {
            base.Set(newValue);
            if (base.Fail)
            {
                PacketType = new PacketType(0xff);
                CommandType = new CommandField(0);
                AddressLength = new AddressLength(0);
            }
            else
            {
                PacketType = new PacketType(this.bytes[0]);
                CommandType = new CommandField(this.bytes[0]);
                AddressLength = new AddressLength(this.bytes[0]);
            }
        }
        // приводит value в соответствие с PacketType, CommandType, AddressLength
        public void Update()
        {
            BitArray newValue = new BitArray(8);
            newValue[7] = PacketType.Bits[1];
            newValue[6] = PacketType.Bits[0];
            newValue[5] = CommandType.Bits[3];
            newValue[4] = CommandType.Bits[2];
            newValue[3] = CommandType.Bits[1];
            newValue[2] = CommandType.Bits[0];
            newValue[1] = AddressLength.Bits[1];
            newValue[0] = AddressLength.Bits[0];
            newValue.CopyTo(base.bytes, 0);
        }

    }
}
