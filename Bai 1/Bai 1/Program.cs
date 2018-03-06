using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IP Address list:");
            string host = Dns.GetHostName();
            IPHostEntry hostInfo = Dns.GetHostEntry(host);
            foreach(IPAddress ip in hostInfo.AddressList)
            Console.WriteLine(ip);
            Console.ReadLine();
        }
    }
}
