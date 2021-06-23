using System;
using System.Collections;
using System.Text;

namespace RMAP_tolmach
{
    class PacketType
    {
        public bool Command { get; set;}
        public bool Reply { get; set; }
        public bool Uncorrect { get; private set; }
        public PacketType()
        {
            Command = false;
            Reply = true;
            Uncorrect = false;
        }
        public PacketType(byte instruction)
        {
            Command = false;
            Reply = false;
            Uncorrect = true;
            if ((instruction >> 6) == 1)
            {
                Command = true;
                Uncorrect = false;
            }
            if ((instruction >> 6) == 0)
            {
                Reply = true;
                Uncorrect = false;
            }

        }

        public new string ToString ()
        {
            string text = "Uncorrected";
            if (Command && !Reply)
            {
                text = "Command";
            }
            if (Reply && !Command)
            {
                text = "Reply";
            }
            return text;
        }
        public BitArray Bits
        {
            get
            {
                BitArray bits = new BitArray(2, false);
                bits[0] = Command;
                return bits;
            }
        }
    }
}
