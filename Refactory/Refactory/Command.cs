using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactory
{
    class Command
    {
        Ip ip;
        LocalPing LocalPing;
        RouterTracking RouterTracking;
        public Command()
        {
            ip = new Ip();
            LocalPing = new LocalPing();
            RouterTracking = new RouterTracking();
        }


        /// <summary>
        /// 0  get host address, 1 get ip from hostname, 2 local ping, 3 traceroute need hostname or ip, 4 display dhcpserveradd
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string Cmd(int input, string text)
        {
            string returnString = "";
            switch (input)
            {
                case 0:
                   returnString = ip.GetHostAddress(text);
                    break;
                case 1:
                   returnString = ip.GetIpFromHostname(text);
                    break;
                case 2:
                   returnString = LocalPing.Ping();
                    break;
                case 3:
                    returnString = RouterTracking.Traceroute(text);
                     break;
                case 4:
                   returnString =  RouterTracking.DisplayDhcpServerAddresses();
                    break;
               
            }
            return returnString;
        }

    }
}
