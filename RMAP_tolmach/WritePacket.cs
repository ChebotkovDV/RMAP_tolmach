using System;
using System.Collections.Generic;
using System.Text;

namespace RMAP_tolmach
{
    class WritePacket
    {
        public FieldsArray TargetSpWAddresses { get; set; }
        public Field TargetLogicalAddresses { get; set; }
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

        public WritePacket()
        {
            TargetSpWAddresses = new FieldsArray("targetSpWAddresses", 1);
            TargetLogicalAddresses = new Field("targetLogicalAddresses", 1, "0xFE");
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
            string divider = " ";
            string text = "";
            text += TargetSpWAddresses.ToString(divider);
            text += TargetLogicalAddresses.ToString(divider);
            text += ProtocolIdentifier.ToString(divider);
            text += Instruction.ToString(divider);
            text += Key.ToString(divider);
            text += ReplyAddress.ToString(divider);
            text += InitiatorLogicalAddress.ToString(divider);
            text += TransactionIdentifier.ToString(divider);
            text += ExtendedAddress.ToString(divider);
            text += Address.ToString(divider);
            text += DataLength.ToString(divider);
            text += HeaderCRC.ToString(divider);
            text += Data.ToString(divider);
            text += DataCRC.ToString(divider);
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
                if (DataLength.ToInt32() != Data.Length)
                {
                    text += "ВНИМАНИЕ : введенное количество слов данных не соответствует заявленному значению в поле DataLength \r\n";
                }
                if ( HeaderCRC.Byte0 != Crc.Calc(Header))
                {
                    text += "Не сходится CRC заголовка \r\n";
                }
                if (DataCRC.Byte0 != Crc.Calc(Data.ToBytes()))
                {
                    text += "Не сходится CRC данных \r\n";
                }
                
                text += "\r\n";
                return text;
            }
        }

        public void UpdateHeaderCrc()
        {
            HeaderCRC.Set(Crc.Calc(Header));
        }
        public void UpdateDataCrc()
        {
            byte[] data = Data.ToBytes();
            byte crc = Crc.Calc(data);
            DataCRC.Set(crc);
        }
        public byte [] Header
        {
            get
            {
                int headerBytesCount =  DataLength.Length + Address.Length + ExtendedAddress.Length + 
                    TransactionIdentifier.Length + InitiatorLogicalAddress.Length + Key.Length + 
                    Instruction.Length + ProtocolIdentifier.Length + TargetLogicalAddresses.Length +
                    (ReplyAddress.Length * ReplyAddress.Width) + (TargetSpWAddresses.Length * TargetSpWAddresses.Width);

                byte[] header = new byte[headerBytesCount];

                int pointer = 0;
                DataLength.ToBytes().CopyTo(header, pointer);
                pointer += DataLength.Length;
                Address.ToBytes().CopyTo(header, pointer);
                pointer += Address.Length;
                ExtendedAddress.ToBytes().CopyTo(header, pointer);
                pointer += ExtendedAddress.Length;
                TransactionIdentifier.ToBytes().CopyTo(header, pointer);
                pointer += TransactionIdentifier.Length;
                InitiatorLogicalAddress.ToBytes().CopyTo(header, pointer);
                pointer += InitiatorLogicalAddress.Length;
                ReplyAddress.ToBytes().CopyTo(header, pointer);
                pointer += ReplyAddress.Length;
                Key.ToBytes().CopyTo(header, pointer);
                pointer += Key.Length;
                Instruction.ToBytes().CopyTo(header, pointer);
                pointer += Instruction.Length;
                ProtocolIdentifier.ToBytes().CopyTo(header, pointer);
                pointer += ProtocolIdentifier.Length;
                TargetLogicalAddresses.ToBytes().CopyTo(header, pointer);
                pointer += TargetLogicalAddresses.Length;
                TargetSpWAddresses.ToBytes().CopyTo(header, pointer);

                return header;
            }
        }

        public bool Fail
        {
            get
            {
                return DataLength.Fail || Address.Fail || ExtendedAddress.Fail || TransactionIdentifier.Fail || 
                    InitiatorLogicalAddress.Fail || ReplyAddress.Fail || Key.Fail || Instruction.Fail ||
                    ProtocolIdentifier.Fail || TargetLogicalAddresses.Fail || TargetSpWAddresses.Fail || 
                    HeaderCRC.Fail || Data.Fail || DataCRC.Fail;
            }
        }

    }
}
