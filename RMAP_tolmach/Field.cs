using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RMAP_tolmach
{
    internal class Field
    {
        protected byte[] bytes;
        public int Width { get; protected set; }
        public bool Fail { get; protected set; }
        public string Log { get; protected set; }
        public string Name { get; protected set; }
        public bool Empty { get; protected set; }
       
        public Field()
        {
            Width = 1;
            bytes = new byte[1];
            Name = "newField";
            Empty = true;
            Fail = false;
        }

        public Field(string name, int byteNumber)
        {
            Width = byteNumber;
            bytes = new byte[Width];
            Name = name;
            Empty = false;
            Fail = false;
        }
        public Field(byte[] newValue)
        {
            Name = "noname";
            this.Set(newValue);
        }

        public Field(string name, int byteNumber, string inputValue)
        {
            Width = byteNumber;
            Name = name;
            bytes = new byte[Width];
            Fail = false;
            Set(inputValue);
        }

        public virtual void Set (byte newValue)
        {
            Width = 1;
            bytes = new byte[1] { newValue };
            Empty = false;
            Fail = false;
        }
        public virtual void Set(byte [] newValue)
        {
            Width = newValue.Length;
            bytes = newValue;
            Empty = false;
            Fail = false;
        }
        public virtual void Set (string message)
        {

            Empty = false;
            Log = "";
            Fail = false;

            if (message == "")
            {
                Empty = true;
                return;
            }

            byte[] newValue = Hex.ParseToBytes(message, out string log);
            if (Log != "")
            {
                Fail = true;
                Log = log;
                return;
            }

            if (Width < newValue.Length)
            {
                Fail = true;
                Log = "    данные не помещаются в поле \r\n";
                return;
            }

            // заполняем массив value. Старшие символы остаются нулями.
            for (int i = 0; i < newValue.Length; i++)
            {
                bytes[i] = newValue[i];
            }
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Field newField = (Field)obj;
            return this.bytes.SequenceEqual(newField.bytes);
        }

        public string Status
        {
            get
            {
                if (Fail)
                {
                    return "поле <" + Name + "> : \r\n" + Log;
                }
                else if (Empty)
                {
                    return "поле <" + Name + ">    : пусто \r\n";
                }
                else
                {
                    return "поле <" + Name + ">    : ok \r\n";
                }
            }
        }
        public override string ToString()
        {
            return ToString("","");
        }
        public string ToString(string prefix, string divider)
        {
            if (Fail)
            {
                return " FAIL ";
            }

            if (Empty)
            {
                return "";
            }

            string text = "";
            text += prefix;
            for (int i = Width - 1; i >= 0; i--)
            {
                text += bytes[i].ToString("X2") + divider;
            }
            return text;
        }
        public byte[] ToBytes()
        {
            if (Empty)
            {
                return null;
            }
            return bytes;
        }
        public int ToInt32()
        {
            if (Empty)
            {
                return 0;
            }

            byte[] extendedArray = new byte[4] { 0, 0, 0, 0 };
            for (int i = 0; (i < 4) && (i < bytes.Length); i++)
                extendedArray[i] = bytes[i];
            return BitConverter.ToInt32(extendedArray,0);
        }
        public byte Byte0
        {
            get
            {
                if (Empty)
                {
                    return 0;
                }
                return bytes[0];
            }
        }

    }
}
