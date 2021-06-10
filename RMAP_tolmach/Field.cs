using System;
using System.Collections.Generic;
using System.Text;

namespace RMAP_tolmach
{
    class Field
    {
        protected byte[] bytes;
        public int Length { get; protected set; }
        public bool Fail { get; protected set; }
        public string Log { get; protected set; }
        public string Name { get; protected set; }
        public bool Empty { get; protected set; }

        public Field()
        {
            Name = "empty";
            Length = 0;
            Empty = true;
            bytes = null;
            Fail = false;
        }
        public Field(string name, int byteNumber)
        {
            Length = byteNumber;
            bytes = new byte[Length];
            Name = name;
            Empty = false;
            Fail = false;
        }

        public Field(string name, int byteNumber, string inputValue)
        {
            Length = byteNumber;
            Name = name;
            bytes = new byte[Length];
            Fail = false;
            Set(inputValue);
        }

        public void Set (byte newValue)
        {
            Length = 1;
            bytes = new byte[1] { newValue };
            Empty = false;
            Fail = false;
        }

        public virtual void Set (string message)
        {
            if (message == "")
            {
                Name = "empty";
                Length = 0;
                Empty = true;
                bytes = null;
                Fail = false;
            }

            try
            {
                byte[] newValue = Parse(message);

                if (Length < newValue.Length)
                {
                    Fail = true;
                    Log += "    данные не помещаются в поле \r\n";
                    return;
                }

                // заполняем массив value. Старшие символы остаются нулями.
                int numberOfNulls = Length - newValue.Length;
                for (int i = 0; i < newValue.Length; i++)
                {
                    bytes[i] = newValue[i];
                }
                Fail = false;
                Log = "";
            }
            catch
            {
                Fail = true;
                Log += "    введена не корректная строка \r\n";
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
                    Log += "    значение <" + strArray[i] + "> имеет не корректный формат \r\n";
                    Fail = true;
                }
                catch (OverflowException)
                {
                    Log += "    значение <" + strArray[i] + "> выходит за пределы 0..255 \r\n";
                    Fail = true;
                }
                catch (ArgumentException)
                {
                    Log += "    значение <" + strArray[i] + "> не является 16-разрядным числом \r\n";
                    Fail = true;
                }
            }
            return byteArray;
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
            return ToString(" ");
        }
        public string ToString(string divider)
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
            for (int i = Length - 1; i >= 0; i--)
            {
                text += divider + bytes[i].ToString("X2");
            }
            return text;
        }
        public byte[] ToBytes()
        {
            return bytes;
        }
        public int ToInt32()
        {
            byte[] extendedArray = new byte[4] { 0, 0, 0, 0 };
            for (int i = 0; (i < 4) && (i < bytes.Length); i++)
                extendedArray[i] = bytes[i];
            return BitConverter.ToInt32(extendedArray,0);
        }
        public byte Byte0
        {
            get
            {
                return bytes[0];
            }
        }

    }
}
