using System;
using Ledger.Core;
using Ledger.Data;
using Ledger.Data.Interfaces;
using Ledger.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Ledger.Data.RespositoryTests
{
    [TestClass]
    public class TransactionRepositoryTest
    {
        private DbContextOptionsBuilder<LedgerContext> _optionBuilder;
        private ITransactionRepository _repo;
        private Guid _accountId;

        [TestInitialize]
        public void TestInitialization()
        {
            _repo = new TransactionRepository();
            _accountId = Guid.Parse("df8a1e7b-eb9d-4c48-a9b3-b8d628fe5709");

            _optionBuilder = new DbContextOptionsBuilder<LedgerContext>();
            _optionBuilder.UseInMemoryDatabase();
        }

        [TestMethod]
        public void Can_Create_Transaction()
        {
            var transaction =new Transaction()
            {
                AccountId = _accountId,
                Amount = 1000,
                CategoryId = 2,
                Description = "New cell phone",
                IsDeposit = false,
                PaymentTypeId = 3,
                TransactionDate = DateTime.Now,
                CreatedBy = "salzheimer",
                 DateCreated = DateTime.Now
            };

            var result =_repo.Create(transaction, _optionBuilder);

            Assert.IsTrue(result!=Guid.Empty,"Transaction was not successful");

            _repo.RemoveTransaction(result, _optionBuilder);

        }

        [TestMethod]
        public void Can_Get_Transaction_By_TransactionId()
        {
            var withdrawal = new Transaction()
            {
                AccountId = _accountId,
                Amount = 1000,
                CategoryId = 2,
                Description = "New cell phone",
                IsDeposit = false,
                PaymentTypeId = 3,
                TransactionDate = DateTime.Now,
                CreatedBy = "salzheimer",
                DateCreated = DateTime.Now
            };
            var transactionId = _repo.Create(withdrawal, _optionBuilder);
            var trans= _repo.GetTransaction(transactionId, _optionBuilder);

            Assert.IsNotNull(trans,string.Format("Transaction with id {0} does not exist",transactionId));

            _repo.RemoveTransaction(transactionId, _optionBuilder);
        }

        [TestMethod]
        public void Can_Get_Account_Transactions()
        {
            CreateTransactions();

            var history = _repo.GetTransactions(_accountId, _optionBuilder);

            Assert.IsNotNull(history,"No transactions were returned");
            Assert.IsTrue(history.Count == 4,string.Format("Number of account transactions do not match what was created: Expected {0} Actual {1}",4,history.Count));
        }

        private void CreateTransactions()
        { 
            
             var trans1= new Transaction()
            {
                AccountId = _accountId,
                Amount = 1000,
                CategoryId = 2,
                Description = "New cell phone",
                IsDeposit = false,
                PaymentTypeId = 3,
                TransactionDate = DateTime.Now.AddDays(-1),
                CreatedBy = "salzheimer",
                DateCreated = DateTime.Now
             };

            var trans2 = new Transaction()
            {
                AccountId = _accountId,
                Amount = 1000,
                CategoryId = 3,
                Description = "loan payment" ,
                IsDeposit = false,
                PaymentTypeId = 1,
                TransactionDate = DateTime.Now,
                CreatedBy = "salzheimer",
                DateCreated = DateTime.Now
            };
            var trans3 = new Transaction()
            {
                AccountId = _accountId,
                Amount = 2000,
                CategoryId = 1,
                Description = "pay check deposit",
                IsDeposit = true,
                PaymentTypeId = 1,
                TransactionDate = DateTime.Now,
                CreatedBy = "salzheimer",
                DateCreated = DateTime.Now
            };
            var trans4 = new Transaction()
            {
                AccountId = _accountId,
                Amount = 1000,
                CategoryId = 1,
                Description = "birthday money deposited",
                IsDeposit = true,
                PaymentTypeId = 5,
                TransactionDate = DateTime.Now,
                CreatedBy = "salzheimer",
                DateCreated = DateTime.Now
            };

            _repo.Create(trans1, _optionBuilder);
            _repo.Create(trans2, _optionBuilder);
            _repo.Create(trans3, _optionBuilder);
            _repo.Create(trans4, _optionBuilder);
        }
    }
}
