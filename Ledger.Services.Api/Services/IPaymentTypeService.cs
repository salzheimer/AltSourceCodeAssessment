using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ledger.Services.Api.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPaymentTypeService" in both code and config file together.
    [ServiceContract]
    public interface IPaymentTypeService
    {


        [OperationContract]
        string CreatePaymentType(Core.PaymentType pType);

        [OperationContract]
        List<Core.PaymentType> GetPaymentTypes();

        [OperationContract]
        Core.PaymentType GetPaymentType(int id);
    }
}
