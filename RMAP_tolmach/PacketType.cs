using System;
using System.Collections;
using System.Text;

namespace RMAP_tolmach
{
    class PacketType
    {
        public bool Command { get; set;}
        public bool Reply { get; set; }
        public bool Uncorrect { get; set; }
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
            if (Command && !Reply && !Uncorrect)
            {
                return "Command";
            }
            if (Reply && !Command && !Uncorrect)
            {
                return "Reply";
            }
            return "Uncorrected";
        }
        public BitArray Bits
        {
            get
            {
                BitArray bits = new BitArray(2, false);
                bits[0] = Command;
                bits[1] = Uncorrect;
                return bits;
            }
        }
    }
}
