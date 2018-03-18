using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    [Serializable]
    public class Data
    {
        public byte[] data {  get;  set; }
        public DateTime createTime { get; private set;  }
        public Guid id { get; private set; }
    }
}
