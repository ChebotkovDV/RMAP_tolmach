using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RMAP_tolmach
{
    internal class Field : List<byte>
    {
        public int Width { get; protected set; }
        public bool Fail { get; protected set; }
        public string Log { get; protected set; }
        public string Name { get; protected set; }
        public bool Empty
        {
            set
            {
                if (value)
                {
                    this.Clear();
                }
            }
            get
            {
                return this.Count == 0;
            }
        }

        public Field()
        {
            Width = 1;
            this.Clear();
            this.Add(0);
            Name = "newField";
            Empty = true;
            Fail = false;
        }

        public Field(int byteNumber, string name)
        {
            Width = byteNumber;
            this.Clear();
            for (int i = 0; i < byteNumber; i++)
            {
                this.Add(0);
            }
            Name = name;
            Empty = false;
            Fail = false;
        }
        public Field(string name, byte inputValue)
        {
            Width = 1;
            Name = name;
            Set(inputValue);
        }
        public Field(int width, string name, string inputValue)
        {
            Width = width;
            Name = name;
            Set(inputValue);
        }

        public virtual void Set (byte newValue)
        {
            Width = 1;
            this.Clear();
            this.Add(newValue);
            Empty = false;
            Fail = false;
        }
        public virtual void Set(byte [] newValue)
        {
            Width = newValue.Length;
            this.Clear();
            this.AddRange(newValue);
            Empty = false;
            Fail = false;
        }
        public virtual void Set (string message)
        {

            Empty = false;
            Log = "";
            Fail = false;
            this.Clear();

            if (message == "")
            {
                Empty = true;
                return;
            }

            byte[] newValue = Hex.ParseToBytes(message, out string log);
            if (log != "")
            {
                Fail = true;
                Log = log;
                return;
            }

            if (Width < newValue.Length)
            {
                Fail = true;
                Log = "    данные не помещаются в поле \r\n";
                this.AddRange(newValue[..Width]);
                return;
            }

            if (newValue.Length == 0)
            {
                Fail = true;
                Empty = true;
                Log = "    данные не распознанны \r\n";
                return;
            }

            this.AddRange(newValue);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Field newField = (Field)obj;
            return this.SequenceEqual(newField);
        }

        public string GetReport
        {
            get
            {
                if (Fail)
                {
                    return "поле <" + Name + "> : \r\n" + Log;
                }
                else if (Empty)
                {
                    return "поле <" + Name + ">    : пусто";
                }
                else
                {
                    return "поле <" + Name + ">    : ok";
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
                text += divider + this[i].ToString("X2");
            }
            return text;
        }
        public int ToInt32()
        {
            if (Empty)
            {
                return 0;
            }
            byte[] temp = new byte[4];
            this.CopyTo(temp, 0);
            return BitConverter.ToInt32(temp,0);
        }
        public byte Byte0
        {
            get
            {
                if (Empty)
                {
                    return 0;
                }
                return this[0];
            }
        }

    }
}
