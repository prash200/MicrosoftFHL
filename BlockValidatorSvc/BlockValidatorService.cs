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

            //this.ValidateBlock(b);
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

        private bool ValidateBlock(Block b)
        {
            //validate hash
            Block lastBlock = this.connector.getMyLastBlock();
            if(b.prevHash.Equals(lastBlock.hash))
            {
                return true;
            }
            return false;
        }
    }
}
