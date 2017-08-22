using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSChanger
{
    class Server
    {
        public string Name;
        public string IP;
        public Server(string Name, string IP)
        {
            this.Name = Name;
            this.IP = IP;
        }
    }
}
