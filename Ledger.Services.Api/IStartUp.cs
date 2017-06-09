using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ledger.Services.Api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStartUp" in both code and config file together.
    [ServiceContract]
    public interface IStartUp
    {
        [OperationContract]
        void UseTestDatabase(bool IsInMemoryDb);
    }
}
