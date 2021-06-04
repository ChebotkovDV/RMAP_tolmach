using System;
using System.Collections;
using System.Text;

namespace RMAP_tolmach
{
    class PacketType
    {
        public bool Command { get; set;}
        public bool Reply { get; set; }

        public PacketType()
        {
            Command = false;
            Reply = true;
        }
        public PacketType(byte instruction)
        {
            Command = false;
            Reply = false;
            if ((instruction >> 6) == 1)
            {
                Command = true;
            }
            if ((instruction >> 6) == 0)
            {
                Reply = true;
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
