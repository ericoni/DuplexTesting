using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Common;
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

			ServiceHosting();
			MessageServiceHosting();

			Console.Read();
		}

		private static void MessageServiceHosting()
		{
			ServiceHost svc = new ServiceHost(MessageService.Instance);
			svc.AddServiceEndpoint(typeof(Common.ISendMessage),
			new NetTcpBinding(),
			new Uri(("net.tcp://localhost:10013/ISendMessage")));

			svc.Open();

			Console.WriteLine("Started MessageServiceHosting...");
		}

		public static void ServiceHosting()
		{
			ServiceHost svc = new ServiceHost(Service.Instance);
			svc.AddServiceEndpoint(typeof(Common.ITestService),
			new NetTcpBinding(),
			new Uri(("net.tcp://localhost:10012/ITestService")));

			svc.Open();

			Console.WriteLine("Started ServiceHosting...");
		}

		static void ServerStaticTest()
		{
			ClassForStaticTest test = new ClassForStaticTest();
			Console.WriteLine(test.IncreaseA().ToString());
		}
	}
}
