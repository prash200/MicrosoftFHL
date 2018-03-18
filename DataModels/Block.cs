using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    [Serializable]
    public class Block
    {
        public byte[] prevHash { get; private set; }
        public byte[] nonce { get; set; }
        public Data data { get; set; }
        public byte hash { get; set; }
    }
}
