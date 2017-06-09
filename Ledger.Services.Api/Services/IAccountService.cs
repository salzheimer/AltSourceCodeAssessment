using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ledger.Services.Api.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAccount" in both code and config file together.
    [ServiceContract(Namespace = "http://Ledger.Api")]
    public interface IAccountService
    {
   

        [OperationContract]
        string CreateAccount(Core.Account account);

        [OperationContract]
        string LogIn(string userName, string password);

        [OperationContract]
        void LogOut();
    }
}
