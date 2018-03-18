using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public enum ConnectorType
    {
        Redis = 0
    }

    public  static class ConnectorFactory
    {
        public static Connector getConnector(ConnectorType type)
        {
            switch (type)
            {
                case ConnectorType.Redis:
                    return new RedisConnector();
                default:
                    throw new NotSupportedException(string.Format("{0} is not supported", type.ToString()));
            }
        }
    }
}
