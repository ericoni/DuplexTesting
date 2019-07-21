using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    //[ServiceContract(CallbackContract = typeof(ITestServiceCallback))]
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        int Register(string userName);

        [OperationContract(IsOneWay = true)]
        void ReceiveCache(string userName, List<string> addressList);

        [OperationContract]
        int Unregister(string userName);
    }
}
