using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	class Program
	{
		static void Main(string[] args)
		{
			//ServiceService css = new ServiceService();
			//css.Start();

			//ServiceHost svc = new ServiceHost(typeof(Service));

			ServiceHost svc = new ServiceHost(Service.Instance);
			svc.AddServiceEndpoint(typeof(Common.ITestService),
			new NetTcpBinding(),
			new Uri(("net.tcp://localhost:10012/ITestService")));

			svc.Open();

			Console.WriteLine("Started...");
			Console.Read();
		}
	}
}
