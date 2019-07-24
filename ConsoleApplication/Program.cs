using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			ChannelFactory<ISendMessage> factory = new ChannelFactory<ISendMessage>(
				new NetTcpBinding(),
				new EndpointAddress("net.tcp://localhost:10013/ISendMessage"));
			ISendMessage kanal = factory.CreateChannel();

			kanal.SendMessage("poruka");

			Console.Read();
		}
	}
}
