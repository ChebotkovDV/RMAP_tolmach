using System;
using System.Collections;
using System.Text;

namespace RMAP_tolmach
{
    class InstructionField : Field
    {
        private PacketType _packetType;
        private CommandType _commandType;
        private AddressLength _addressLength;

        public InstructionField()
        {
            Name = "Instruction";
            Width = 1;
            this.Set(0);

            _packetType = new PacketType();
            _commandType = new CommandType();
            _addressLength = new AddressLength();
        }
        public InstructionField(byte value)
        {
            Name = "Instruction";
            Width = 1;
            this.Set(value);
            _packetType = new PacketType(value);
            _commandType = new CommandType(value);
            _addressLength = new AddressLength(value);
        }

        public bool DataExist
        {
            get
            {
                bool writeCommand = _packetType.Command && _commandType.Write;
                bool readReply = _packetType.Reply && _commandType.Read;
                return (writeCommand || readReply) && ! this.Empty;
            }
        }
        public bool IsCommand {get{ return _packetType.Command; } }
        public bool IsReply{get{ return _packetType.Reply; } }
        public bool IsUncorrect{get{ return _packetType.Uncorrect; } }
        public bool IsWrite { get { return _commandType.Write; } }
        public string GetPacketType{get{ return IsCommand ? "Command" : IsReply ? "Reply" : "Uncorrect"; }}
        public int GetReplyAddressLength{get{ return _addressLength.ToInt(); }}
        public BitArray CommandType{get{ return _commandType.Bits; }}
        public string GetCommandType{get{ return _commandType.ToString(); }}

        public override void Set(string newValue)
        {
            base.Set(newValue);
            UpdateControls();
        }
        public override void Set(byte newValue)
        {
            base.Set(newValue);
            UpdateControls();
        }
        public void Set(Field newValue)
        {
            base.Set(newValue[0]);
            UpdateControls();
        }
        private void UpdateControls()
        {
            if (base.Fail || base.Empty)
            {
                _packetType = new PacketType(0xff);
                _commandType = new CommandType(0);
                _addressLength = new AddressLength(0);
            }
            else
            {
                _packetType = new PacketType(this[0]);
                _commandType = new CommandType(this[0]);
                _addressLength = new AddressLength(this[0]);
            }
        }
        public void SetCommandType (bool write, bool verify, bool reply, bool increment)
        {
            _commandType.Write = write;
            _commandType.VerifyDataBeforeWrite = verify;
            _commandType.Reply = reply;
            _commandType.IncrementAddress = increment;
            UpdateValue();
        }
        public void SetReplyAddressLength(bool bytes0, bool bytes4, bool bytes8, bool bytes12)
        {
            _addressLength.Set0 = bytes0;
            _addressLength.Set4 = bytes4;
            _addressLength.Set8 = bytes8;
            _addressLength.Set12 = bytes12;
            UpdateValue();
        }
        public void SetPacketType(bool command, bool reply)
        {
            bool typeCommand = command && !reply;
            bool typeReply = !command && reply;
            bool typeUncorrect = !(command ^ reply);
            _packetType.Command = typeCommand;
            _packetType.Reply = typeReply;
            _packetType.Uncorrect = typeUncorrect;
            _addressLength.Set0 = typeReply;
            UpdateValue();
        }
        private void UpdateValue()
        {
            BitArray newValue = new BitArray(8);
            newValue[7] = _packetType.Bits[1];
            newValue[6] = _packetType.Bits[0];
            newValue[5] = _commandType.Bits[3];
            newValue[4] = _commandType.Bits[2];
            newValue[3] = _commandType.Bits[1];
            newValue[2] = _commandType.Bits[0];
            newValue[1] = _addressLength.Bits[1];
            newValue[0] = _addressLength.Bits[0];
            byte[] newInstruction = new byte[1];
            newValue.CopyTo(newInstruction, 0);
            this.Set(newInstruction);
        }
    }
}
