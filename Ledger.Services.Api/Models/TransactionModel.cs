using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ledger.Services.Api.Models
{
    [DataContract]
    public class TransactionModel:Core.Transaction
    {
        [DataMember]
        public string PaymentTypeName { get; set; }

        [DataMember]
        public string CategoryName { get; set; }

    }
}
