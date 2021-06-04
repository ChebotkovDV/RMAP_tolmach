using System;
using System.Collections.Generic;
using System.Text;

namespace RMAP_tolmach
{
    class FieldsArray
    {
        Field[] fields;
        int length;
        int width;
        string name = "new";
        string log = "";
        bool fail = false;

        public FieldsArray(string name, int width)
        {
            this.width = width;
            this.name = name;
        }

        public Field this [int index]
        {
            get
            {
                if (index >= 0 && index < length)
                {
                    return fields[index];
                }
                else
                {
                    return new Field("empty", 0);
                }
            }
            set
            {
                if (index >= 0 && index < length)
                {
                    fields[index] = value;
                }
                else
                {
                    fail = true;
                    log += "    поле с индексом " + index.ToString() + " не существует \r\n";
                }
            }
        }
        public string Status
        {
            get
            {
                if (fail)
                {
                    return log;
                }
                else
                {
                    return "Поля <" + name + ">    : ok \r\n";
                }
            }
        }

        public void Set(string str)
        {
            string[] strArray = str.Split(' ');
            length = strArray.Length;
            fields = new Field[length];

            for (int i = 0; i<length; i++)
            {
                string fieldName = name + "[" + i.ToString() + "]";
                Field newField = new Field(fieldName, width, strArray[i]);
                fields[i] = newField;

                if (newField.Fail)
                {
                    fail = true;
                    log += newField.Status + "\r\n";
                }
            }
        }
        public int Length
        {
            get
            {
                return length;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
        }
        public bool Fail
        {
            get
            {
                return fail;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string ToString()
        {
            return ToString(" ");
        }
        public string ToString(string divider)
        {
            string text = "";
            for (int i = 0; i < length; i++)
            {
                text += "   " + fields[i].ToString(divider);
            }
            return text;
        }
    }
}
