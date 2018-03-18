using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    [Serializable]
    public class BlockChain
    {
        public List<Block> chain { get; set; }
    }
}
