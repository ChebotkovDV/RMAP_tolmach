using System;
using System.Collections.Generic;
using System.Linq;


namespace RMAP_tolmach
{
    class FieldsArray : List<Field>
    {
        public int Length {get { return this.Count; }}
        public int Width { private set; get; }
        public string Name { private set; get; }
        public string Log { private set; get; }
        public bool Fail { private set; get; }
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
        public int BytesCount
        {
            get
            {
                return this.Length * this.Width;
            }
        }

        public FieldsArray(string name, int width)
        {
            this.Width = width;
            this.Name = name;
        }
        public FieldsArray(string name, int width, string message)
        {
            this.Width = width;
            this.Name = name;
            Set(message);
        }

        public string Status
        {
            get
            {
                if (Fail)
                {
                    return Log;
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

        public void Set(string str)
        {
            if (str == "")
            {
                Fail = false;
                Log = "";
                this.Clear();
                return;
            }

            string[] strArray = str.Split(' ');
            int length = strArray.Length;
            Log = "";
            Fail = false;
            this.Clear();

            for (int i = 0; i < length; i++)
            {
                string current = strArray[length - 1 - i];

                if (current != "" && current != " ")
                {
                    string fieldName = Name + "[" + i.ToString() + "]";
                    Field newField = new Field(fieldName, Width, current);
                    this.Add(newField);

                    if (newField.Fail)
                    {
                        Fail = true;
                        Log += this[i].Status + "\r\n";
                    }
                }
            }
        }
        public void Set(FieldsArray array)
        {
            if (array.Width != this.Width)
            {
                throw new ArgumentException("Разная ширина полей");
            }

            this.Clear();
            foreach (Field f in array)
            {
                this.Add(f);
            }
        }
        public void Set(byte[] bytes)
        {
            this.Clear();

            Array.Resize(ref bytes, bytes.Length + this.Width - 1);
            for (int i = 0; i <= (bytes.Length - Width); i += Width)
            {
                byte[] newData = new byte[Width];
                Array.Copy(bytes, i, newData, 0, Width);

                string newFieldName = this.Name + "[" + this.Length.ToString() + "]";
                Field newField = new Field(newFieldName, Width);
                newField.Set(newData);

                this.Add(newField);
            }
        }

        public new void Clear()
        {
            base.Clear();
            Log = "";
            Fail = false;
        }

        public override string ToString()
        {
            return ToString("",""," ");
        }
        public string ToString(string prefix, string fieldDivider, string byteDivider)
        {
            if (Empty)
            {
                return "";
            }

            string text = "";
            for (int i = Length - 1; i >= 0; i--)
            {
                text += this[i].ToString(prefix, byteDivider) + fieldDivider;
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

    }
}
