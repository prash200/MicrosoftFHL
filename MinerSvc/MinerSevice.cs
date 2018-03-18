using DataAccessLayer;
using DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinerSvc
{
    public partial class MinerSevice : ServiceBase
    {
        public MinerSevice()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            while (true)
            {
                // This will be contacting StateMachineSvc
                Connector connector = ConnectorFactory.getConnector(ConnectorType.Redis);
                Data data = connector.getData();
                Block block = this.MineBlock(data, 4);

                Thread.Sleep(1000);
            }
        }

        protected override void OnStop()
        {
        }

        private Block MineBlock(Data data, int difficulty)
        {
            Block block = new Block();
            return block;
        }

        private bool PushBlockToPeers(Block block)
        {
            foreach (var peer in Common.Settings.Default.Peers)
            {

            }

            return true;
        }
    }
}
