using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServiceService : IDisposable
    {
        //Service service = null;
        ServiceHost host = null;
        NetTcpBinding binding = null;
        string address = "net.tcp://localhost:10012/ITestServices";

        public ServiceService()
        {
            //service = CASSubscriber.Instance;
            binding = new NetTcpBinding();
            InitializeHosts();
        }

        private void InitializeHosts()
        {
            host = new ServiceHost(Service.Instance);
        }

        public void Dispose()
        {
            CloseHosts();
            GC.SuppressFinalize(this);
        }

        private void CloseHosts()
        {
            if (host == null)
            {
                throw new Exception("CAS Subscriber Services can not be closed because it is not initialized.");
            }

            host.Close();

            string message = "The CAS Subscriber Service is closed.";
            Console.WriteLine("\n\n{0}", message);
        }

        public void Start()
        {
            StartHosts();
        }

        private void StartHosts()
        {
            if (host == null)
            {
                throw new Exception("CAS Subscriber can not be opend because it is not initialized.");
            }

            string message = string.Empty;

            try
            {
                host.AddServiceEndpoint(typeof(ITestService), binding, address);
                host.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            message = string.Format("The WCF service {0} is ready.", host.Description.Name);
            Console.WriteLine(message);

            message = "Endpoints:";
            Console.WriteLine(message);
            Console.WriteLine(address);

            message = "The CAS Subscriber Service is started.";
            Console.WriteLine("{0}", message);

            Console.WriteLine("************************************************************************CAS Subscriber sterted", message);
        }
    }
}
