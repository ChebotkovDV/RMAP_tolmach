using System;
using System.Collections.Generic;
using System.Text;

namespace RMAP_tolmach
{
    class FieldsArray
    {
        public Field[] Fields { get; set; }
        public int Length { private set; get; }
        public int Width { private set; get; }
        public string Name { private set; get; }
        public string Log { private set; get; }
        public bool Fail { private set; get; }
        public bool Empty { private set; get; }

        public FieldsArray(string name, int width)
        {
            this.Width = width;
            this.Name = name;
            this.Empty = true;
        }

        public Field this [int index]
        {
            get
            {
                if (index >= 0 && index < Length)
                {
                    return Fields[index];
                }
                else
                {
                    return new Field("empty", 0);
                }
            }
            set
            {
                if (index >= 0 && index < Length)
                {
                    Fields[index] = value;
                }
                else
                {
                    Fail = true;
                    Log += "    поле с индексом " + index.ToString() + " не существует \r\n";
                }
            }
        }
        public string Status
        {
            get
            {
                if (Fail)
                {
                    return Log;
                }
                else
                {
                    return "Поля <" + Name + ">    : ok \r\n";
                }
            }
        }

        public void Set(string str)
        {
            string[] strArray = str.Split(' ');
            Length = strArray.Length;
            Fields = new Field[Length];

            for (int i = 0; i<Length; i++)
            {
                string fieldName = Name + "[" + i.ToString() + "]";
                Fields[i] = new Field(fieldName, Width, strArray[Length - 1 - i]);
                Empty = false;

                if (Fields[i].Fail)
                {
                    Fail = true;
                    Log += Fields[i].Status + "\r\n";
                }
            }

            if (str == "")
            {
                Fail = false;
                Length = 0;
                Log = "empty";
                Empty = true;
                Fields = null;
            }
        }

        public override string ToString()
        {
            return ToString(" ");
        }
        public string ToString(string divider)
        {
            if (Empty)
            {
                return "";
            }

            string text = "";
            for (int i = 0; i < Length; i++)
            {
                text += " " + Fields[i].ToString(divider);
            }
            return text;
        }

        public byte[] ToBytes()
        {
            byte[] bytes = new byte[Length * Width];
            for (int i = 0; i < Length; i++)
            {
                Fields[i].ToBytes().CopyTo(bytes, i * Width);
            }
            return bytes;
        }
    }
}
