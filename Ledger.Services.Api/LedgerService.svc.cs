using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ledger.Core;
using Ledger.Services.Api.Models;
using Ledger.Services.Api.Services;
using Ledger.Data;
using Ledger.Data.Interfaces;
using Ledger.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ledger.Services.Api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LedgerService" in both code and config file together.
    public class LedgerService : ILedgerService, IAccountService, ICategoryService, IPaymentTypeService, ITransactionService
    {
        #region Start up test data
        public static DbContextOptionsBuilder<LedgerContext> OptionsBuilder;

        public void UseTestDatabase(bool isInMemoryDb)
        {
            if (isInMemoryDb)
            {
                OptionsBuilder = new DbContextOptionsBuilder<LedgerContext>();
                OptionsBuilder.UseInMemoryDatabase();

                CreateTestData();
            }
        }

        private void CreateTestData()
        {
            var account = new Core.Account();
            account.FirstName = "Scott";
            account.LastName = "Alzheimer";
            account.UserName = "salzheimer";
            account.Password = "XXevJ9G>*bh'(c$W";

            Data.Interfaces.IAccountRepository repo = new Data.Repositories.AccountRepository();
            repo.Create(account, OptionsBuilder);

            CreatePaymentTypes();
            CreateCategories();
        }

        private void CreatePaymentTypes()
        {

            //Payment Types
            var pType1 = new Core.PaymentType() { Name = "credit" };
            var pType2 = new Core.PaymentType() { Name = "cash" };
            var pType3 = new Core.PaymentType() { Name = "check" };

            Data.Interfaces.IPaymentTypeRepository pTypeRepo = new Data.Repositories.PaymentTypeRepository();
            pTypeRepo.Create(pType1, OptionsBuilder);
            pTypeRepo.Create(pType2, OptionsBuilder);
            pTypeRepo.Create(pType3, OptionsBuilder);
        }

        private void CreateCategories()
        {
            var categories =
                "groceries,gas,movies & dvds,atm fee, coffee shop, paycheck, credit card payment,mortgage & rent,loan payment, transfer,pharmacy, phone, utilities,bank fee,restaurant,charity,gym,doctor,home insurance,lawn & garden,withdrawal,deposit,electronics & software,clothing, books";

            string[] catArray = categories.Split(',');

            Data.Interfaces.ICategoryRepository catRepo = new CategoryRepository();
            for (int i = 0; i < catArray.Length; i++)
            {

                var currentCat = new Core.Category() { CategoryName = catArray[i].Trim() };
                catRepo.Create(currentCat, OptionsBuilder);

            }
        }

        #endregion

        #region Category

        public string CreateCategory(Category category)
        {
            if (OptionsBuilder == null) { return "Service is not started"; }
            Data.Interfaces.ICategoryRepository repo = new Data.Repositories.CategoryRepository();

            var result = repo.Create(category, OptionsBuilder);

            if (result == 1)
            {
                return "Category created successfully";
            }
            else
            {
                return "Category creation failed";
            }
        }



        public List<Category> GetCategories()
        {
            if (OptionsBuilder == null) { throw new Exception("Service is not started"); }
            Data.Interfaces.ICategoryRepository repo = new Data.Repositories.CategoryRepository();
            return repo.GetCategories(OptionsBuilder);
        }

        public Category GetCategory(int id)
        {
            if (OptionsBuilder == null) { throw new Exception("Service is not started"); }
            Data.Interfaces.ICategoryRepository repo = new Data.Repositories.CategoryRepository();

            return repo.GetCategory(id, OptionsBuilder);
        }

        #endregion

        #region Account
        public string CreateAccount(Core.Account account)
        {
            //validate if in memory db has been started
            if (OptionsBuilder == null)
            {
                return "Service not started";
            }
            IAccountRepository repo = new AccountRepository();

            var success = repo.Create(account, OptionsBuilder);
            if (success == 1)
            {
                return string.Format("Account for user {0} was created successfully", account.UserName);
            }
            else
            {
                return string.Format("Account creation for user {0} failed", account.UserName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>account number</returns>
        public string LogIn(string userName, string password)
        {
            //validate if in memory db has been started
            if (OptionsBuilder == null)
            {
                return "Service not started";
            }

            IAccountRepository repo = new AccountRepository();

            var user = repo.GetAccount(userName, OptionsBuilder);

            if (user != null && user.Password == password)
            {
                return user.Id.ToString();
            }
            else
            {
                return "User Name or password are not in our system. Please try again";
            }
        }

        /// <summary>
        /// LogOut disables connection to in memory database 
        /// </summary>
        public void LogOut()
        {
            OptionsBuilder = null;
        }

        #endregion


        #region PaymentTypes
        public string CreatePaymentType(PaymentType pType)
        {
            if (OptionsBuilder == null) { throw new Exception("Service is not started"); }
            Data.Interfaces.IPaymentTypeRepository pTypeRepo = new Data.Repositories.PaymentTypeRepository();
            var result = pTypeRepo.Create(pType, OptionsBuilder);
            if (result == 1)
            {
                return "Payment type create successfully";
            }
            else
            {
                return "Payment type creation failed";
            }
        }



        public PaymentType GetPaymentType(int id)
        {
            if (OptionsBuilder == null) { throw new Exception("Service is not started"); }
            Data.Interfaces.IPaymentTypeRepository pTypeRepo = new Data.Repositories.PaymentTypeRepository();
            return pTypeRepo.GetPaymentType(id, OptionsBuilder);
        }

        public List<PaymentType> GetPaymentTypes()
        {
            if (OptionsBuilder == null) { throw new Exception("Service is not started"); }
            Data.Interfaces.IPaymentTypeRepository pTypeRepo = new Data.Repositories.PaymentTypeRepository();

            return pTypeRepo.GetPaymentTypes(OptionsBuilder);
        }
        #endregion

        #region Transaction 
        public string DeleteTransaction(Guid transactionId)
        {
            throw new NotImplementedException();
        }


        public TransactionModel GetTransaction(Guid transactionId)
        {
            if (OptionsBuilder == null) { throw new Exception("Service is not started"); }
            ITransactionRepository repo = new TransactionRepository();
            return (Models.TransactionModel)repo.GetTransaction(transactionId, OptionsBuilder);
        }

        public List<TransactionModel> GetTransactions(Guid accountId)
        {
            var returnList = new List<Models.TransactionModel>();
            if (OptionsBuilder == null) { throw new Exception("Service is not started"); }
            ITransactionRepository repo = new TransactionRepository();
            var accountTranactions = repo.GetTransactions(accountId, OptionsBuilder);
            ICategoryRepository catRepo = new CategoryRepository();
            IPaymentTypeRepository pTypeRepo = new PaymentTypeRepository();

            for (int i = 0; i < accountTranactions.Count; i++)
            {
                var returnValue = new TransactionModel();
                returnValue.IsDeposit = accountTranactions[i].IsDeposit;
                returnValue.CategoryName = catRepo.GetCategory(accountTranactions[i].CategoryId, OptionsBuilder).CategoryName;
                returnValue.CategoryId = accountTranactions[i].CategoryId;
                returnValue.PaymentTypeName = pTypeRepo.GetPaymentType(accountTranactions[i].PaymentTypeId, OptionsBuilder).Name;
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
            if (OptionsBuilder == null) { throw new Exception("Service is not started"); }
            if (!deposit.IsDeposit) { return "This is not a deposit"; }

            ITransactionRepository repo = new TransactionRepository();
            var trans = new Transaction();
            trans.AccountId = deposit.AccountId;
            trans.Amount = deposit.Amount;
            trans.CategoryId = deposit.CategoryId;
            trans.PaymentTypeId = deposit.PaymentTypeId;
            trans.CreatedBy = deposit.CreatedBy;
            trans.Description = deposit.Description;
            trans.IsDeposit = deposit.IsDeposit;
            trans.TransactionDate = deposit.TransactionDate;

            return repo.Create(trans, OptionsBuilder).ToString();

        }

        public string MakeWithdrawal(TransactionModel withdrawal)
        {
            if (OptionsBuilder == null) { throw new Exception("Service is not started"); }

            if (withdrawal.IsDeposit) { return "This is not a withdrawal"; }
            ITransactionRepository repo = new TransactionRepository();
            var trans = new Transaction();
            trans.AccountId = withdrawal.AccountId;
            trans.Amount = withdrawal.Amount;
            trans.CategoryId = withdrawal.CategoryId;
            trans.PaymentTypeId = withdrawal.PaymentTypeId;
            trans.CreatedBy = withdrawal.CreatedBy;
            trans.Description = withdrawal.Description;
            trans.IsDeposit = withdrawal.IsDeposit;
            trans.TransactionDate = withdrawal.TransactionDate;

            return repo.Create(trans, OptionsBuilder).ToString();
        }

        public string UpdateTransaction(TransactionModel transaction)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
