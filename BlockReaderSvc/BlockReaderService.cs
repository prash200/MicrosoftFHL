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
using System.Threading;

namespace BlockReaderSvc
{
    public partial class BlockReaderService : ServiceBase
    {
        public BlockReaderService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            while (true)
            {
                // This will be contacting 
                //TODO:listener for incoming blocks
                Thread.Sleep(1000);
            }
        }

        protected override void OnStop()
        {
        }
    }
}
