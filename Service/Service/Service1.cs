using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Service
{
    public partial class Service1 : ServiceBase
    {
        private Timer timer1 = null;
        
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer1 = new Timer();
            this.timer1.Interval = 10000;
            this.timer1.Elapsed += new ElapsedEventHandler(this.timer1_Tick);
        }

        private void timer1_Tick(object sender, ElapsedEventArgs e)
        {
            Libary.WriteErrorLog("Timer ticked and some job has been done succesfully");
        }

        protected override void OnStop()
        {
            timer1.Enabled = false;
            Libary.WriteErrorLog("Test window services stopped");
        }
    }
}
