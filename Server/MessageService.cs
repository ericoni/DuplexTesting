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
	public class MessageService : ISendMessage
	{
		static MessageService instance;
		public static MessageService Instance
		{
			get
			{
				if (instance == null)
					instance = new MessageService();
				return instance;
			}
		}
		public void SendMessage(string message)
		{
			Service.Instance.NotifyClient();
		}
	}
}
