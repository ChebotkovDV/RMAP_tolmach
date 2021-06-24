using System;
using System.Collections;
using System.Text;

namespace RMAP_tolmach
{
    class CommandType
    {
        public bool Write { get; set; }
        public bool VerifyDataBeforeWrite { get; set; }
        public bool Reply { get; set; }
        public bool IncrementAddress { get; set; }

        public CommandType()
        {
            Write = false;
            VerifyDataBeforeWrite = false;
            Reply = false;
            IncrementAddress = false;
        }
        public CommandType(byte instruction)
        {
            Write = ((instruction >> 5) & 1) == 1;
            VerifyDataBeforeWrite = ((instruction >> 4) & 1) == 1;
            Reply = ((instruction >> 3) & 1) == 1;
            IncrementAddress = ((instruction >> 2) & 1) == 1;
        }

        public bool Read { get { return !Write; } }

        public new string ToString()
        {
            if (! Write && ! VerifyDataBeforeWrite && Reply && ! IncrementAddress)
            {
                return "Read single address";
            }
            else if (!Write && !VerifyDataBeforeWrite && Reply && IncrementAddress)
            {
                return "Read incrementing addresses";
            }
            else if (!Write && VerifyDataBeforeWrite && Reply && IncrementAddress)
            {
                return "Read‐Modify‐Write incrementing addresses";
            }
            else if (Write && ! VerifyDataBeforeWrite && ! Reply && ! IncrementAddress)
            {
                return "Write, single address, don’t verify before writing, no reply";
            }
            else if (Write && ! VerifyDataBeforeWrite && ! Reply && IncrementAddress)
            {
                return "Write, incrementing addresses, don’t verify before writing, no reply";
            }
            else if (Write && !VerifyDataBeforeWrite && Reply && ! IncrementAddress)
            {
                return "Write, single address, don’t verify before writing, send reply";
            }
            else if (Write && ! VerifyDataBeforeWrite && Reply && IncrementAddress)
            {
                return "Write, incrementing addresses, don’t verify before writing, send reply";
            }
            else if (Write && VerifyDataBeforeWrite && ! Reply && ! IncrementAddress)
            {
                return "Write, single address, verify before writing, no reply";
            }
            else if (Write && VerifyDataBeforeWrite && ! Reply && IncrementAddress)
            {
                return "Write, incrementing addresses, verify before writing, no reply";
            }
            else if (Write && VerifyDataBeforeWrite && Reply && ! IncrementAddress)
            {
                return "Write, single address, verify before writing, send reply";
            }
            else if (Write && VerifyDataBeforeWrite && Reply && IncrementAddress)
            {
                return "Write, incrementing addresses, verify before writing, send reply";
            }
            else
            {
                return "Invalid";
            }
        }

        public BitArray Bits
        {
            get
            {
                BitArray bits = new BitArray(4);
                bits[0] = IncrementAddress;
                bits[1] = Reply;
                bits[2] = VerifyDataBeforeWrite;
                bits[3] = Write;
                return bits;
            }
        }

    }
}
