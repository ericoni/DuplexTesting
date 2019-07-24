using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
	public class Service : ITestService
	{
		private static Service instance;
		int counter = 0;
		List<ITestServiceCallback> callbackList = new List<ITestServiceCallback>();

		public static Service Instance
		{
			get
			{
				if (instance == null)
					instance = new Service();
				return instance;
			}
		}
		public void ReceiveCache(string userName, List<string> addressList)
		{
			throw new NotImplementedException();
		}

		public int Register(string userName)
		{
			counter++;
			OperationContext context = OperationContext.Current;
			ITestServiceCallback client = context.GetCallbackChannel<ITestServiceCallback>();

			if(callbackList.Contains(client) == false)
				callbackList.Add(client);
			
			//if(userName.Equals("a"))//hardcoded reply to client
			//	client.NotifyUserOfCache();
			return counter;
		}

		public int Unregister(string userName)
		{
			throw new NotImplementedException();
		}

		public void NotifyClient()
		{
			foreach (var callback in callbackList)
			{
				callback.NotifyUserOfCache();
			}
		}
	}
}
