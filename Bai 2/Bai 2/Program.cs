using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Domain name/IP Address: ");
            string hostName = Console.ReadLine();
            IPHostEntry hostInfo = Dns.Resolve(hostName);
            Console.WriteLine("Host name: "+hostInfo.HostName+"\nIP Address:");
            
            foreach (IPAddress ip in hostInfo.AddressList)
            {
                Console.WriteLine(ip);
            }
            Console.ReadLine();
        }
    }
}
