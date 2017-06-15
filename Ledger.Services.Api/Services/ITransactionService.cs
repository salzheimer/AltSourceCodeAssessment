using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Ledger.Services.Api.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITransactionService" in both code and config file together.
    [ServiceContract]
    public interface ITransactionService
    {
        [OperationContract]
        string MakeDeposit(Models.TransactionModel deposit);

        [OperationContract]
        string MakeWithdrawal(Models.TransactionModel withdrawal);

        [OperationContract]
        List<Models.TransactionModel> GetTransactions(Guid accountId);

        [OperationContract]
        Models.TransactionModel GetTransaction(Guid transactionId);

        [OperationContract]
        string DeleteTransaction(Guid transactionId);

        
        [OperationContract]
        string UpdateTransaction(Models.TransactionModel transaction);
    }
}
