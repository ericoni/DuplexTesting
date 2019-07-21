using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDuplexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            WSDualHttpBinding binding = new WSDualHttpBinding();
            EndpointAddress endptadr = new EndpointAddress("http://localhost:12000/DuplexTestUsingCode/Server");
            binding.ClientBaseAddress = new Uri("http://localhost:8000/DuplexTestUsingCode/Client/");
        }
    }
}
