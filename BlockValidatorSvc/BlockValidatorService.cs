using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataModels;

namespace BlockValidatorSvc
{
    public partial class BlockValidatorService : ServiceBase
    {
        Connector connector = ConnectorFactory.getConnector(ConnectorType.Redis);

        public BlockValidatorService()
        {
            InitializeComponent();           
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

        private bool isValid(Block b)
        {
            //validate hash
            Block lastBlock = this.connector.getMyLastBlock();//@pra - how do you determine if its the first block and what should be the validation for the same?
            if(b != null && b.prevHash.Equals(lastBlock.hash))
            {
                return true;
            }
            return false;
        }
    }
}
