using System;
using System.Collections.Generic;
using System.Text;

namespace RMAP_tolmach
{
    class RmapPacket
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

        public RmapPacket()
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
            EEP = false;
        }
        

        public string GetRMAPPacket()
        {
            return GetRMAPPacket("", "", " ");
        }
        public string GetRMAPPacket(string prefix, string fieldDivider, string byteDivider)
        {
            string text = "";
            text += TargetSpWAddresses.ToString(prefix, fieldDivider, byteDivider);
            text += TargetLogicalAddresses.ToString(prefix, byteDivider);
            text += ProtocolIdentifier.ToString(prefix, byteDivider);
            text += Instruction.ToString(prefix, byteDivider);
            text += Key.ToString(prefix, byteDivider);
            text += ReplyAddress.ToString(prefix, fieldDivider, byteDivider);
            text += InitiatorLogicalAddress.ToString(prefix, byteDivider);
            text += TransactionIdentifier.ToString(prefix, byteDivider);
            text += ExtendedAddress.ToString(prefix, byteDivider);
            text += Address.ToString(prefix, byteDivider);
            text += DataLength.ToString(prefix, byteDivider);
            text += HeaderCRC.ToString(prefix, byteDivider);
            text += Data.ToString(prefix, fieldDivider, byteDivider);
            text += DataCRC.ToString(prefix, byteDivider);
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
        public string FieldsStatus
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
                return text;
            }
        }
        public string Status
        {
            get
            {
                string text = "";
                text += "Packet type = " + Instruction.PacketType.ToString() + "\r\n";
                text += "Command : " + Instruction.CommandType.ToString() + "\r\n";
                text += "Reply address length - " + Instruction.AddressLength.ToString() + " bytes\r\n";

                if (Fail)
                {
                    text += "ВНИМАНИЕ : одно или несколько полей заполнены не корректно \r\n";
                }
                if (Empty)
                {
                    text += "ВНИМАНИЕ : одно или несколько полей не заполнены \r\n";
                }
                if (Instruction.ReplyAddressLength != ReplyAddress.Length)
                {
                    text += "ВНИМАНИЕ : введенное количество Replay-адресов не соответствует заявленному значению в поле Instruction \r\n";
                }
                if (DataLength.ToInt32() != (Data.Length * Data.Width))
                {
                    text += "ВНИМАНИЕ : введенное количество слов данных не соответствует заявленному значению в поле DataLength \r\n";
                }
                if (! HeaderCrcIsCorrected)
                {
                    text += "Не сходится CRC заголовка \r\n";
                }
                if (! DataCrcIsCorrected)
                {
                    text += "Не сходится CRC данных \r\n";
                }
                
                return text;
            }
        }
        private bool HeaderCrcIsCorrected
        { 
            get 
            { 
                if (!HeaderCRC.Fail && !HeaderCRC.Empty)
                {
                    return (HeaderCRC.Byte0 == Hex.GetCrc(Header));
                }
                else
                {
                    return false;
                }
            } 
        }
        private bool DataCrcIsCorrected
        {
            get
            {
                if (Data.Empty || Data.Fail)
                {
                    return true;
                }
                else if (DataCRC.Fail || DataCRC.Empty)
                {
                    return false;
                }
                else
                {
                    return (DataCRC.Byte0 == Hex.GetCrc(Data.ToBytes()));
                }
            }
        }

        public void UpdateHeaderCrc()
        {
            HeaderCRC.Set(Hex.GetCrc(Header));
        }
        public void UpdateDataCrc()
        {
            if (Data.Empty)
            {
                DataCRC.Set("");
            }
            else
            {
                byte[] data = Data.ToBytes();
                byte crc = Hex.GetCrc(data);
                DataCRC.Set(crc);
            }
        }
        public byte [] Header
        {
            get
            {
                List<byte> temp = new List<byte>();
                temp.AddRange(DataLength.ToBytes());
                temp.AddRange(Address.ToBytes());
                temp.AddRange(ExtendedAddress.ToBytes());
                temp.AddRange(TransactionIdentifier.ToBytes());
                temp.AddRange(InitiatorLogicalAddress.ToBytes());
                temp.AddRange(ReplyAddress.ToBytes());
                temp.AddRange(Key.ToBytes());
                temp.AddRange(Instruction.ToBytes());
                temp.AddRange(ProtocolIdentifier.ToBytes());
                temp.AddRange(TargetLogicalAddresses.ToBytes());
                return temp.ToArray();
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
        public bool Empty
        {
            get
            {
                return DataLength.Empty || Address.Empty || ExtendedAddress.Empty || TransactionIdentifier.Empty ||
                    InitiatorLogicalAddress.Empty || ReplyAddress.Empty || Key.Empty || Instruction.Empty ||
                    ProtocolIdentifier.Empty || TargetLogicalAddresses.Empty || TargetSpWAddresses.Empty ||
                    HeaderCRC.Empty || Data.Empty || DataCRC.Empty;
            }
        }
        public void Parse (string message, out string log)
        {
            if (Hex.ParseToRmap(message, TargetLogicalAddresses, out RmapPacket newPacket, out log))
            {
                TargetSpWAddresses = newPacket.TargetSpWAddresses;
                TargetLogicalAddresses = newPacket.TargetLogicalAddresses;
                ProtocolIdentifier = newPacket.ProtocolIdentifier;
                Instruction = newPacket.Instruction;
                Key = newPacket.Key;
                ReplyAddress = newPacket.ReplyAddress;
                InitiatorLogicalAddress = newPacket.InitiatorLogicalAddress;
                TransactionIdentifier = newPacket.TransactionIdentifier;
                ExtendedAddress = newPacket.ExtendedAddress;
                Address = newPacket.Address;
                DataLength = newPacket.DataLength;
                HeaderCRC = newPacket.HeaderCRC;
                Data = newPacket.Data;
                DataCRC = newPacket.DataCRC;
                EEP = newPacket.EEP;
            }
        }

    }
}
