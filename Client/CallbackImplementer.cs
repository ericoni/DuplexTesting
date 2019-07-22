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
	public class CallbackImplementer : ITestServiceCallback
	{
		ITestService proxy = null;
		public int counter = 0;

		public CallbackImplementer()
		{
			//DuplexChannelFactory<ITestService> factory = new DuplexChannelFactory<ITestService>(
			//  new InstanceContext(this),
			//  new NetTcpBinding(),
			//  new EndpointAddress("net.tcp://localhost:10012/ITestService"));
			//proxy = factory.CreateChannel();

			//proxy.Register("");
		   
			//while (true)
			//{
			//    try
			//    {
			//        proxy.Register("");
			//    }
			//    catch (Exception e)
			//    {
			//        if(counter++ == 5)
			//            throw e;
			//    }
			//}

		}

		public void NotifyUserOfCache()
		{
			var p = Thread.CurrentPrincipal.Identity;
			counter++;
		}
	}
}
