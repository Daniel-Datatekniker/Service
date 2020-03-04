using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Refactory
{
    class LocalPing
    {

        public LocalPing()
        {

        }


        public string Ping()
        {
            // Ping's the local machine.
            Ping pingSender = new Ping();
            IPAddress address = IPAddress.Loopback;
            PingReply reply = pingSender.Send(address);

            if (reply.Status == IPStatus.Success)
            {
                return $"Address: {reply.Address.ToString()}\n"
                   + $"RoundTrip time: {reply.RoundtripTime}\n"
                   + $"Time to live: { reply.Options.Ttl}\n"
                   + $"Don't fragment: {reply.Options.DontFragment}\n"
                   + $"Buffer size: {reply.Buffer.Length}";
            }
            else
            {
                return reply.Status.ToString();
            }
        }
    }
}
