using System;
using System.Collections.Generic;
using System.Text;

namespace RMAP_tolmach
{
    class Field
    {
        protected byte[] value;
        protected int length;
        protected bool fail = false;
        protected string log = "";
        protected string fieldName = "newField";

        public Field()
        {
            fieldName = "empty";
            length = 0;
        }
        public Field(string name, int byteNumber)
        {
            length = byteNumber;
            value = new byte[length];
            fieldName = name;
        }

        public Field(string name, int byteNumber, string inputValue)
        {
            length = byteNumber;
            fieldName = name;
            value = new byte[length];
            Set(inputValue);
        }

        public virtual void Set (string inputValue)
        {
            try
            {
                byte[] newValue = Parse(inputValue);

                if (length < newValue.Length)
                {
                    fail = true;
                    log += "    данные не помещаются в поле \r\n";
                    return;
                }

                // заполняем массив value с конца. Первые символы остаются нулями.
                int numberOfNulls = length - newValue.Length;
                for (int i = newValue.Length - 1; i >= 0; i--)
                {
                    value[i + numberOfNulls] = newValue[i];
                }
                fail = false;
                log = "";
            }
            catch
            {
                fail = true;
                log += "    введена не корректная строка \r\n";
            }

        }
        // преобразует строку, содержащую число в 16-ричной форме записи, в массив byte
        protected byte[] Parse(string inputValue)
        {
            string newStr = inputValue.Trim();
            // удаляем префикс, если он есть
            if (newStr.Substring(0, 2) == "0x")
            {
                newStr = newStr.Remove(0, 2);
            }
            // добавляем ноль в начало строки, на случай, если количество символов строки окажется нечетным
            newStr = newStr.Insert(0, "0");

            int byteNumber = newStr.Length / 2;

            // разбиваем исходную строку на массив подстрок по два символа
            string[] strArray = new string[byteNumber];
            for(int i = 0; i < byteNumber; i++)
            {
                // копируем два последних символа исходной строки
                strArray[i] = newStr.Substring(newStr.Length - 2, 2);
                // и удаляем их
                newStr = newStr.Remove(newStr.Length - 2, 2);
            }

            // преобразуем массив подстрок в массив byte
            byte[] byteArray = new byte[byteNumber];

            for (int i = 0; i < byteNumber; i++)
            {
                try
                {
                    byteArray[i] = Convert.ToByte(strArray[i], 16);
                }
                catch (FormatException)
                {
                    log += "    значение <" + strArray[i] + "> имеет не корректный формат \r\n";
                    fail = true;
                }
                catch (OverflowException)
                {
                    log += "    значение <" + strArray[i] + "> выходит за пределы 0..255 \r\n";
                    fail = true;
                }
                catch (ArgumentException)
                {
                    log += "    значение <" + strArray[i] + "> не является 16-разрядным числом \r\n";
                    fail = true;
                }
            }
            return byteArray;
        }

        public int Length
        {
            get
            {
                return length;
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
                return fieldName;
            }
            set
            {
                fieldName = value;
            }
        }

        public string Status
        {
            get
            {
                if (fail)
                {
                    return "поле <" + fieldName + "> : \r\n" + log;
                }
                else
                {
                    return "поле <" + fieldName + ">    : ok \r\n";
                }
            }
        }
        public override string ToString()
        {
            return ToString(" ");
        }
        public string ToString(string divider)
        {
            if (fail)
            {
                return " FAIL ";
            }

            string text = "";
            for (int i = length - 1; i >= 0; i--)
            {
                text += divider + value[i].ToString("X2");
            }
            return text;
        }
        public byte[] ToBytes()
        {
            return value;
        }

        public int ToInt()
        {
            return 0;
        }

    }
}
