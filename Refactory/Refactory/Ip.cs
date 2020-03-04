using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Refactory
{
    class Ip
    {
        private IPAddress[] ipAddresses;

        public IPAddress[] Ips
        {
            get { return ipAddresses; }
            private set { ipAddresses = value; }
        }

        public Ip()
        {
         
        }

        /// <summary>
        /// Get host address, WebsiteName to IP
        /// </summary>
        /// <param name="hostAddress"></param>
        /// <returns></returns>
        public string GetHostAddress(string hostAddress)
        {
            Ips = Dns.GetHostAddresses(hostAddress);
            string text = "";
            foreach (IPAddress ipAddres in Ips)
            {
                text += $"{hostAddress} host addres {ipAddres.ToString()}";
            }

            return text;
        }


        /// <summary>
        /// Get hostname from Ip address
        /// </summary>
        /// <param name="Hostname"></param>
        /// <returns></returns>
        public  string GetIpFromHostname(string Hostname)
        {
            string ip = "";
            try
            {
                IPHostEntry ipHostEntry = Dns.GetHostEntry(Hostname);
                if (ipHostEntry.AddressList.Length > 0)
                {
                    //ip = ipHostEntry.AddressList[0].Address.ToString();
                    ip = ipHostEntry.AddressList[0].ToString();
                }
                else
                {
                    ip = "No information found.";
                }
            }
            catch (SocketException)
            {
                ip = "Unable to perform lookup - a socket error occured.";
                return ip;
            }
            catch (SecurityException)
            {
                ip = "Unable to perform lookup - permission denied.";
                return ip;
            }
            catch (Exception)
            {
                ip = "An unspecified error occured.";
                return ip;
            }

            return ip;
        }
    }
}
