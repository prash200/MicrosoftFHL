using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public abstract class Connector
    {
        public abstract Data getData();
        public abstract Block getBlock();
        public abstract BlockChain getBlockChain();
    }
}
