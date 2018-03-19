using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels;
using StackExchange.Redis;

namespace DataAccessLayer
{
    class RedisConnector : Connector
    {
        static RedisConnector()
        {
            RedisConnector.lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
            {
                return ConnectionMultiplexer.Connect("localhost");
            });
        }

        private static Lazy<ConnectionMultiplexer> lazyConnection;

        public override Block getBlock()
        {
            lazyConnection.Value.GetDatabase().ListGetByIndex($"", 0);
        }

        public override BlockChain getBlockChain()
        {
            lazyConnection.Value.GetDatabase().ListGetByIndex($"", 0);
        }

        public override Data getData()
        {
            lazyConnection.Value.GetDatabase().ListGetByIndex($"", 0);
        }

        public override Block getMyLastBlock()
        {
            throw new NotImplementedException();
        }

        public override void setBlock(Block block)
        {
            throw new NotImplementedException();
        }

        public override void setBlockChain(BlockChain blockChain)
        {
            throw new NotImplementedException();
        }

        public override bool isFirstBlock(Block block)
        {
            throw new NotImplementedException();
        }
    }
}
