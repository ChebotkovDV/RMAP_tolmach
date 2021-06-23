using System;
using System.Collections.Generic;
using System.Text;

namespace RMAP_tolmach
{
    class RmapPacket
    {
        public FieldsArray SpwAddresses { get; set; }
        public Field TargetLogicalAddresses { get; set; }
        public Field ProtocolIdentifier { get; set; }
        public InstructionField Instruction { get; set; }
        public Field Key { get; set; }
        public Field Status { get; set; }
        public FieldsArray ReplyAddresses { get; set; }
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
            SpwAddresses = new FieldsArray("TargetSpWAddresses", 1);
            TargetLogicalAddresses = new Field("TargetLogicalAddresses", 0xFE);
            ProtocolIdentifier = new Field("ProtocolIdentifier", 0x01);
            Instruction = new InstructionField();
            Key = new Field("Key", 0x00);
            Status = new Field("Status", 0x00);
            ReplyAddresses = new FieldsArray("ReplyAddresses", 1);
            InitiatorLogicalAddress = new Field("InitiatorLogicalAddress", 0xFE);
            TransactionIdentifier = new Field(2, "TransactionIdentifier");
            ExtendedAddress = new Field(1, "ExtendedAddress");
            Address = new Field(4, "Address");
            DataLength = new Field(3, "DataLength");
            HeaderCRC = new Field(1, "HeaderCRC");
            Data = new FieldsArray("Data", 4);
            DataCRC = new Field(1, "DataCRC");
            EEP = false;
        }
        

        public string GetRMAPPacket()
        {
            return GetRMAPPacket(" ");
        }
        public string GetRMAPPacket(string byteDivider)
        {
            return Hex.GetRMAPPacket(this, byteDivider);
        }
        public string FieldsStatus
        {
            get
            {
                string text = "";
                text += SpwAddresses.Status;
                text += TargetLogicalAddresses.Status;
                text += ProtocolIdentifier.Status;
                text += Instruction.Status;
                text += Key.Status;
                text += ReplyAddresses.Status;
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
        public string GetReport
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

                if (Instruction.ReplyAddressLength != ReplyAddresses.Length)        //!
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
                temp.AddRange(DataLength.ToArray());
                temp.AddRange(Address.ToArray());
                temp.AddRange(ExtendedAddress.ToArray());
                temp.AddRange(TransactionIdentifier.ToArray());
                temp.AddRange(InitiatorLogicalAddress.ToArray());
                temp.AddRange(ReplyAddresses.ToBytes());
                temp.AddRange(Key.ToArray());
                temp.AddRange(Instruction.ToArray());
                temp.AddRange(ProtocolIdentifier.ToArray());
                temp.AddRange(TargetLogicalAddresses.ToArray());
                return temp.ToArray();
            }
        }
        public bool Fail
        {
            get
            {
                return DataLength.Fail || Address.Fail || ExtendedAddress.Fail || TransactionIdentifier.Fail || 
                    InitiatorLogicalAddress.Fail || ReplyAddresses.Fail || Key.Fail || Instruction.Fail ||
                    ProtocolIdentifier.Fail || TargetLogicalAddresses.Fail || SpwAddresses.Fail || 
                    HeaderCRC.Fail || Data.Fail || DataCRC.Fail;
            }
        }
        public bool Empty
        {
            get
            {
                return DataLength.Empty || Address.Empty || ExtendedAddress.Empty || TransactionIdentifier.Empty ||
                    InitiatorLogicalAddress.Empty || ReplyAddresses.Empty || Key.Empty || Instruction.Empty ||
                    ProtocolIdentifier.Empty || TargetLogicalAddresses.Empty || SpwAddresses.Empty ||
                    HeaderCRC.Empty || Data.Empty || DataCRC.Empty;
            }
        }
        public void Parse (string message, out string log)
        {
            if (Hex.ParseToRmap(message, TargetLogicalAddresses, out RmapPacket newPacket, out log))
            {
                SpwAddresses = newPacket.SpwAddresses;
                TargetLogicalAddresses = newPacket.TargetLogicalAddresses;
                ProtocolIdentifier = newPacket.ProtocolIdentifier;
                Instruction = newPacket.Instruction;
                Key = newPacket.Key;
                ReplyAddresses = newPacket.ReplyAddresses;
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
