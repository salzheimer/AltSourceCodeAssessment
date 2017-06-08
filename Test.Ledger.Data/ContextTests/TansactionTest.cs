using System;
using System.Linq;
using Ledger.Core;
using Ledger.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;

namespace Test.Ledger.Data.ContextTests
{
    [TestClass]
    public class TansactionTest
    {
        private Guid _acctId;
        private DbContextOptionsBuilder<LedgerContext> _optionBuilder;
            
            [TestInitialize()]
        public void TransactionInitialize()
        {
            _acctId = Guid.Parse("396760ea-d0cf-4ff3-996e-52bc970e4fac");
            _optionBuilder = new DbContextOptionsBuilder<LedgerContext>();
            _optionBuilder.UseInMemoryDatabase();
        }

        [TestMethod]
        public void Can_Create_Tranaction()
        {
            

            using (var context = new LedgerContext(_optionBuilder.Options))
            {
                
                context.Transactions.Add(new Transaction
                {
                    AccountId =_acctId,
                    Amount = 100,
                    CategoryId = 1,
                    Description = "New shoes",
                    IsDeposit = false,
                    PaymentTypeId = 1,
                    TransactionDate = DateTime.Now,
                    CreatedBy = "BVilla",
                    DateCreated = DateTime.Now,

                    
                });
                context.SaveChanges();

                var trans = context.Transactions.FirstOrDefault(t => t.AccountId == _acctId);

                Assert.IsNotNull(trans, "Transaction was not successfully created");
            }
        

            
        }

        [TestMethod]
        public void Can_Get_Transaction()
        {
            using (var context = new LedgerContext(_optionBuilder.Options))
            {
                var trans = context.Transactions.FirstOrDefault(t => t.AccountId == _acctId);

                Assert.IsNotNull(trans, "Transaction was not successfully created");
            }
        }
    }
}
