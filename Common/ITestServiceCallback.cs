using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface ITestServiceCallback
    {
        [OperationContract(IsOneWay = true)] // Govori da li je neblokirajuci poziv, kada se odradi poziv
        void NotifyUserOfCache();
    }
}
