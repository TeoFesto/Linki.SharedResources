using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Linki.SharedResources
{
    public class ServerConnectionResponse : Response
    {
        public ServerConnectionResponse() { }
        public ServerConnectionResponse(IPEndPoint endPoint)
        {
            ipAddress = endPoint.Address.ToString();
            port = endPoint.Port;
        }
        public string ipAddress { get; set; }
        public int port { get; set; }
    }
}
