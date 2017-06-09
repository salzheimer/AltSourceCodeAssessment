using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ledger.Data.Interfaces;
using Ledger.Data.Repositories;
using Ledger.Services.Api.Models;

namespace Ledger.Services.Api.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TransactionService" in both code and config file together.
    public class TransactionService : ITransactionService
    {
        public string DeleteTransaction(Guid transactionId)
        {
            throw new NotImplementedException();
        }

        
        public TransactionModel GetTransaction(Guid transactionId)
        {
            if (StartUp.OptionsBuilder == null) { throw new Exception("Service is not started"); }
            ITransactionRepository repo = new TransactionRepository();
            return (Models.TransactionModel)repo.GetTransaction(transactionId, StartUp.OptionsBuilder);
        }

        public List<TransactionModel> GetTransactions(Guid accountId)
        {
            var returnList = new List<Models.TransactionModel>();
            if (StartUp.OptionsBuilder == null) { throw new Exception("Service is not started"); }
            ITransactionRepository repo = new TransactionRepository();
            var accountTranactions = repo.GetTransactions(accountId, StartUp.OptionsBuilder);
            ICategoryRepository catRepo = new CategoryRepository();
            IPaymentTypeRepository pTypeRepo = new PaymentTypeRepository();

            for (int i = 0; i < accountTranactions.Count; i++)
            {
                var returnValue = new TransactionModel();
                returnValue.IsDeposit   =accountTranactions[i].IsDeposit;
                returnValue.CategoryName = catRepo.GetCategory(accountTranactions[i].CategoryId,StartUp.OptionsBuilder).CategoryName;
                returnValue.CategoryId = accountTranactions[i].CategoryId;
                returnValue.PaymentTypeName = pTypeRepo.GetPaymentType(accountTranactions[i].PaymentTypeId,StartUp.OptionsBuilder).Name;
                returnValue.PaymentTypeId = accountTranactions[i].PaymentTypeId;
                returnValue.AccountId = accountTranactions[i].AccountId;
                returnValue.Amount = accountTranactions[i].Amount;
                returnValue.Description = accountTranactions[i].Description;
                returnValue.Id = accountTranactions[i].Id;
                returnValue.TransactionDate = accountTranactions[i].TransactionDate;

                returnList.Add(returnValue);
            }

            return returnList;
        }

        public string MakeDeposit(TransactionModel deposit)
        {
            if (StartUp.OptionsBuilder == null) { throw new Exception("Service is not started"); }
            if (!deposit.IsDeposit){return "This is not a deposit";}

            ITransactionRepository repo = new TransactionRepository();


            return repo.Create(deposit, StartUp.OptionsBuilder).ToString();

        }

        public string MakeWithdrawal(TransactionModel withdrawal)
        {
            if (StartUp.OptionsBuilder == null) { throw new Exception("Service is not started"); }

            if (withdrawal.IsDeposit){return "This is not a withdrawal";}
            ITransactionRepository repo = new TransactionRepository();
            return repo.Create(withdrawal, StartUp.OptionsBuilder).ToString();
        }

        public string UpdateTransaction(TransactionModel transaction)
        {
            throw new NotImplementedException();
        }
    }
}
