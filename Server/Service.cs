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
            string a = "rakija";
            return 5;
        }

        public int Unregister(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
