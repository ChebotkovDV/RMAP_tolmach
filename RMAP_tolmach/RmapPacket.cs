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
                text += SpwAddresses.GetReport + "\r\n";
                text += TargetLogicalAddresses.GetReport + "\r\n";
                text += ProtocolIdentifier.GetReport + "\r\n";
                text += Instruction.GetReport + "\r\n";
                text += InitiatorLogicalAddress.GetReport + "\r\n";
                text += TransactionIdentifier.GetReport + "\r\n";
                if (Instruction.IsCommand)
                {
                    text += Key.GetReport + "\r\n";
                    text += ReplyAddresses.GetReport + "\r\n";
                    text += ExtendedAddress.GetReport + "\r\n";
                    text += Address.GetReport + "\r\n";
                }
                if (Instruction.IsReply)
                {
                    text += Status.GetReport + "\r\n";
                }
                text += HeaderCRC.GetReport;
                if (Instruction.DataExist)
                {
                    text += "\r\n";
                    text += DataLength.GetReport + "\r\n";
                    text += Data.GetReport + "\r\n";
                    text += DataCRC.GetReport;
                }
                return text;
            }
        }
        public string GetReport
        {
            get
            {
                string text = "";
                text += "Packet type = " + Instruction.GetPacketType + "\r\n";
                text += "Command : " + Instruction.GetCommandType + "\r\n";
                text += "Reply address length - " + Instruction.GetReplyAddressLength.ToString() + " bytes\r\n";

                if (Fail)
                {
                    text += "ВНИМАНИЕ : одно или несколько полей заполнены не корректно \r\n";
                }
                if (FieldNotFound)
                {
                    text += "ВНИМАНИЕ : одно или несколько полей не заполнены \r\n";
                }

                if (Instruction.GetReplyAddressLength != ReplyAddresses.Length && Instruction.IsCommand)
                {
                    text += "ВНИМАНИЕ : введенное количество Replay-адресов не соответствует заявленному значению в поле Instruction \r\n";
                }

                if (DataLength.ToInt32() != (Data.Length * Data.Width) && Instruction.DataExist)
                {
                    text += "ВНИМАНИЕ : введенное количество слов данных не соответствует заявленному значению в поле DataLength \r\n";
                }
                if (! HeaderCrcIsCorrected)
                {
                    text += "Не сходится CRC заголовка \r\n";
                }
                if (! DataCrcIsCorrected && Instruction.DataExist)
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
                bool dataFieldsFail = (DataLength.Fail || Data.Fail || DataCRC.Fail) && Instruction.DataExist;
                bool headerFildsFail = TransactionIdentifier.Fail || InitiatorLogicalAddress.Fail || Instruction.Fail ||
                    ProtocolIdentifier.Fail || TargetLogicalAddresses.Fail || HeaderCRC.Fail;
                bool typeReplyFail = Instruction.IsReply && Status.Fail;
                bool typeCommandFail = Instruction.IsCommand && (Address.Fail || ExtendedAddress.Fail ||
                    ReplyAddresses.Fail || Key.Fail);
                return dataFieldsFail || headerFildsFail || typeReplyFail || typeCommandFail;
            }
        }
        private bool FieldNotFound
        {
            get
            {
                bool dataFieldsEmpty = (DataLength.Empty || Data.Empty || DataCRC.Empty) && Instruction.DataExist;
                bool headerFildsEmpty = TransactionIdentifier.Empty || InitiatorLogicalAddress.Empty || Instruction.Empty ||
                    ProtocolIdentifier.Empty || TargetLogicalAddresses.Empty || HeaderCRC.Empty;
                bool typeReplyEmpty = Instruction.IsReply && Status.Empty;
                bool typeCommandEmpty = Instruction.IsCommand && (Address.Empty || ExtendedAddress.Empty || 
                    ReplyAddresses.Empty || Key.Empty);
                return dataFieldsEmpty || headerFildsEmpty || typeReplyEmpty || typeCommandEmpty;
            }
        }
        public void Parse (string message, out string log)
        {
            if (Hex.ParseToRmap(message, TargetLogicalAddresses, InitiatorLogicalAddress,
                ProtocolIdentifier, out RmapPacket newPacket, out log))
            {
                SpwAddresses = newPacket.SpwAddresses;
                TargetLogicalAddresses = newPacket.TargetLogicalAddresses;
                ProtocolIdentifier = newPacket.ProtocolIdentifier;
                Instruction = newPacket.Instruction;
                Key = newPacket.Key;
                Status = newPacket.Status;
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
