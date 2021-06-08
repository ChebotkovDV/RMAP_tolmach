using System;
using System.Collections;
using System.Text;

namespace RMAP_tolmach
{
    static class Crc
    {
        private static BitArray polinom { get; set; }
        private static BitArray bits { get; set; }
        private static bool MostSignificantBit {
            get
            {
                return bits[bits.Length - 1];
            }
        }
        static Crc()
        {
            bool[] myBools = new bool[9] { true, false, false, false, false, false, true, true, true };
            polinom = new BitArray(myBools);
        }

        public static byte Calc(byte [] original)
        {
            return Calc(new BitArray(original));
        }
        public static byte Calc (BitArray original)
        {
            int extendetBitsCount = polinom.Length - 1;
            bits = new BitArray(original.Length + extendetBitsCount, false);
            for (int i = 0; i < original.Length; i++)
            {
                if (original[i])
                {
                    bits.Set(i + extendetBitsCount, true); 
                }
            }
            Calc();
            return ToByte();
        }
        private static void Calc()
        {
            while (bits.Length > 8)
            {
                Xor();
                TrimNulls();
            }
        }
        private static void Xor()
        {
            for (int i = 8; i >= 0; i--)
            {
                int bitPointer = bits.Length - 9 + i;
                bits[bitPointer] ^= polinom[i];
            }
        }
        private static void TrimNulls()
        {
            while (!MostSignificantBit && (bits.Length > 8))
            {
                bits.Length--;
            }
        }


        private static byte ToByte()
        {
            if (bits.Count > 8)
            {
                throw new ArgumentException("bits count overflow");
            }
            byte[] bytes = new byte[1];
            bits.CopyTo(bytes, 0);
            return bytes[0];
        }
    }
}
