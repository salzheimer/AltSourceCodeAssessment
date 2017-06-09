using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ledger.Services.Api.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICategoryServices" in both code and config file together.
    [ServiceContract]
    public interface ICategoryServices
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<Core.Category> GetCategories();

        [OperationContract]
        Core.Category GetCategory(int id);

        [OperationContract]
        string CreateCategory(Core.Category category);
    }
}
