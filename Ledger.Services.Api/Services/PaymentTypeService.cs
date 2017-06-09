using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ledger.Core;

namespace Ledger.Services.Api.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PaymentTypeService" in both code and config file together.
    public class PaymentTypeService : IPaymentTypeService
    {
        public string CreatePaymentType(PaymentType pType)
        {
            if (StartUp.OptionsBuilder == null) { throw new Exception("Service is not started"); }
            Data.Interfaces.IPaymentTypeRepository pTypeRepo = new Data.Repositories.PaymentTypeRepository();
            var result =pTypeRepo.Create(pType, StartUp.OptionsBuilder);
            if (result == 1)
            {
                return "Payment type create successfully";
            }
            else
            {
                return "Payment type creation failed";
            }
        }

        public void DoWork()
        {
        }

        public PaymentType GetPaymentType(int id)
        {
            if (StartUp.OptionsBuilder == null) { throw new Exception("Service is not started"); }
            Data.Interfaces.IPaymentTypeRepository pTypeRepo = new Data.Repositories.PaymentTypeRepository();
            return pTypeRepo.GetPaymentType(id,StartUp.OptionsBuilder);
        }

        public List<PaymentType> GetPaymentTypes()
        {
            if (StartUp.OptionsBuilder == null) { throw new Exception("Service is not started"); }
            Data.Interfaces.IPaymentTypeRepository pTypeRepo = new Data.Repositories.PaymentTypeRepository();

            return pTypeRepo.GetPaymentTypes(StartUp.OptionsBuilder);
        }
    }
}
