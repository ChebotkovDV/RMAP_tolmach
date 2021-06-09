using System;
using System.Collections.Generic;
using System.Text;

namespace RMAP_tolmach
{
    class FieldsArray : List<Field>
    {
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
            Empty = false;


            this.Clear();
            for (int i = 0; i<Length; i++)
            {
                string fieldName = Name + "[" + i.ToString() + "]";
                this.Add(new Field(fieldName, Width, strArray[Length - 1 - i]));

                if (this[i].Fail)
                {
                    Fail = true;
                    Log += this[i].Status + "\r\n";
                }
            }

            if (str == "")
            {
                Fail = false;
                Length = 0;
                Log = "empty";
                Empty = true;
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
            for (int i = Length - 1; i >= 0; i--)
            {
                text += " " + this[i].ToString(divider);
            }
            return text;
        }

        public byte[] ToBytes()
        {
            byte[] bytes = new byte[Length * Width];
            for (int i = 0; i < Length; i++)
            {
                this[i].ToBytes().CopyTo(bytes, i * Width);
            }
            return bytes;
        }

        //public bool EqualityComparer
    }
}
