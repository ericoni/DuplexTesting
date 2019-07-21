using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //CallbackImplementer callback = new CallbackImplementer();

            ChannelFactory<ITestService> factory = new ChannelFactory<ITestService>(
           new NetTcpBinding(),
           new EndpointAddress("net.tcp://localhost:10012/ITestService"));
            ITestService kanal = factory.CreateChannel();

            Thread.Sleep(3000);
            kanal.Register("");

            Console.WriteLine("Prosao");
            Console.Read();
        }
    }
}
