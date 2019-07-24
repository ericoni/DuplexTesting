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
			//DuplexChannelClient();

			ITestService proxy = null;
			CallbackImplementer callback = new CallbackImplementer();

			DuplexChannelFactory<ITestService> factory = new DuplexChannelFactory<ITestService>(
			  new InstanceContext(callback),
			  new NetTcpBinding(),
			  new EndpointAddress("net.tcp://localhost:10012/ITestService"));
			proxy = factory.CreateChannel();

			int proxyRet = proxy.Register("a");
			Console.WriteLine(proxyRet.ToString() + " callback " + callback.counter.ToString());

			Console.WriteLine("DuplexChannelClient()");
			Console.Read();
		}

		static void RegularChannelClient()
		{
			// ChannelFactory<ITestService> factory = new ChannelFactory<ITestService>(
			//new NetTcpBinding(),
			//new EndpointAddress("net.tcp://localhost:10012/ITestService"));
			// ITestService kanal = factory.CreateChannel();

			// Thread.Sleep(3000);
			// kanal.Register("");
		}

		static void DuplexChannelClient()
		{
			ITestService proxy = null;
			CallbackImplementer callback = new CallbackImplementer();

			DuplexChannelFactory<ITestService> factory = new DuplexChannelFactory<ITestService>(
			  new InstanceContext(callback),
			  new NetTcpBinding(),
			  new EndpointAddress("net.tcp://localhost:10012/ITestService"));
			proxy = factory.CreateChannel();

			int proxyRet = proxy.Register("a");
			Console.WriteLine(proxyRet.ToString() + " callback " + callback.counter.ToString());

			Console.WriteLine("DuplexChannelClient()");
		}

		static void StaticTest()
		{
			ClassForStaticTest test = new ClassForStaticTest();
			Console.WriteLine(test.IncreaseA().ToString());
		}
	}
}
