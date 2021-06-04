using System;
using System.Collections;
using System.Text;

namespace RMAP_tolmach
{
    class AddressLength
    {
        private int bits;

        public AddressLength()
        {
            bits = 0;
        }
        public AddressLength(byte instruction)
        {
            bits = instruction & 3; // младшие два бита поля "Instruction"
        }
        public int ToInt()
        {
            int length = 0;
            if (bits == 1)
            {
                length = 4;
            }
            if (bits == 2)
            {
                length = 8;
            }
            if (bits == 3)
            {
                length = 12;
            }
            return length;
        }
        public new string ToString()
        {
            return ToInt().ToString();
        }
        public BitArray Bits
        {
            get
            {
                BitArray bits = new BitArray(new int[] { this.bits });
                bits.Length = 2;
                return bits;
            }
        }
        public bool Set0
        {
            set
            {
                if (value)
                {
                    this.bits = 0;
                }
            }
        }
        public bool Set4
        {
            set
            {
                if (value)
                {
                    this.bits = 1;
                }
            }
        }
        public bool Set8
        {
            set
            {
                if (value)
                {
                    this.bits = 2;
                }
            }
        }
        public bool Set12
        {
            set
            {
                if (value)
                {
                    this.bits = 3;
                }
            }
        }
    }
}
