using System;
using System.Collections.Generic;
using System.Text;

namespace RMAP_tolmach
{
    class WriteCommand
    {
        public FieldsArray TargetSpWAddresses { get; set; }
        public FieldsArray TargetLogicalAddresses { get; set; }
        public Field ProtocolIdentifier { get; set; }
        public InstructionField Instruction { get; set; }
        public Field Key { get; set; }
        public FieldsArray ReplyAddress { get; set; }
        public Field InitiatorLogicalAddress { get; set; }
        public Field TransactionIdentifier { get; set; }
        public Field ExtendedAddress { get; set; }
        public Field Address { get; set; }
        public Field DataLength { get; set; }
        public Field HeaderCRC { get; set; }
        public FieldsArray Data { get; set; }
        public Field DataCRC { get; set; }
        public bool EEP { get; set; }

        public WriteCommand()
        {
            TargetSpWAddresses = new FieldsArray("targetSpWAddresses", 1);
            TargetLogicalAddresses = new FieldsArray("targetLogicalAddresses", 1);
            ProtocolIdentifier = new Field("ProtocolIdentifier", 1, "0x01");
            Instruction = new InstructionField();
            Key = new Field("Key", 1, "0x00");
            ReplyAddress = new FieldsArray("replyAddresses", 1);
            InitiatorLogicalAddress = new Field("InitiatorLogicalAddress", 1, "0xFE");
            TransactionIdentifier = new Field("TransactionIdentifier", 2);
            ExtendedAddress = new Field("ExtendedAddress", 1);
            Address = new Field("Address", 4);
            DataLength = new Field("DataLength", 3);
            HeaderCRC = new Field("HeaderCRC", 1);
            Data = new FieldsArray("Data", 4);
            DataCRC = new Field("DataCRC", 1);
        }
        


        public string GetRMAPPacket()
        {
            string text = "";
            text += TargetSpWAddresses.ToString(" 0x");
            text += TargetLogicalAddresses.ToString(" 0x");
            text += ProtocolIdentifier.ToString(" 0x");
            text += Instruction.ToString(" 0x");
            text += Key.ToString(" 0x");
            text += ReplyAddress.ToString(" 0x");
            text += InitiatorLogicalAddress.ToString(" 0x");
            text += TransactionIdentifier.ToString(" 0x");
            text += ExtendedAddress.ToString(" 0x");
            text += Address.ToString(" 0x");
            text += DataLength.ToString(" 0x");
            text += HeaderCRC.ToString(" 0x");
            text += Data.ToString(" 0x");
            text += DataCRC.ToString(" 0x");
            if (EEP)
            {
                text += "  EEP";
            }
            else
            {
                text += "  EOP";
            }
            return text;
        }

        public string Status
        {
            get
            {
                string text = "";
                text += TargetSpWAddresses.Status;
                text += TargetLogicalAddresses.Status;
                text += ProtocolIdentifier.Status;
                text += Instruction.Status;
                text += Key.Status;
                text += ReplyAddress.Status;
                text += InitiatorLogicalAddress.Status;
                text += TransactionIdentifier.Status;
                text += ExtendedAddress.Status;
                text += Address.Status;
                text += DataLength.Status;
                text += HeaderCRC.Status;
                text += Data.Status;
                text += DataCRC.Status;
                text += "\r\n";
                text += "Packet type = " + Instruction.PacketType.ToString() + "\r\n";
                text += "Command : " + Instruction.CommandType.ToString() + "\r\n";
                text += "Reply address length - " + Instruction.AddressLength.ToString() + " bytes\r\n";

                if (Instruction.ReplyAddressLength != ReplyAddress.Length)
                {
                    text += "ВНИМАНИЕ : введенное количество Replay-адресов не соответствует заявленному значению в поле Instruction \r\n";
                }

                //text += "dataLength = " + DataLength.ToInt() + "\r\n";
                text += "dataLength = " + DataLength.temp() + "\r\n";

                text += "\r\n";
                return text;
            }
        }

    }
}
