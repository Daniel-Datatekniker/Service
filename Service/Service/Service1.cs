using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public partial class Service1 : ServiceBase
    {
        string cipherText = null;
        string plainText = "test";
        string plainText1 = null;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }


        public static string Encrypt(string plainText)
        {

        }
        protected override void OnStop()
        {
        }
    }
}
