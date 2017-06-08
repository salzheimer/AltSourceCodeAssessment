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
    public class AccountRepositoryTest
    {
        private DbContextOptionsBuilder<LedgerContext> _optionBuilder;
        private IAccountRepository _repo;
        [TestInitialize]
        public void TestInitialization()
        {
            _optionBuilder = new DbContextOptionsBuilder<LedgerContext>();
            _optionBuilder.UseInMemoryDatabase();

            _repo = new AccountRepository();
        }

        [TestMethod]
        public void Can_Create_Account()
        {
            

            var account = new Account();
            account.FirstName = "Scott";
            account.LastName = "Alzheimer";
            account.UserName = "salzheimer";
            account.Password = "XXevJ9G>*bh'(c$W";
            var result = _repo.Create(account, _optionBuilder);

            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void Can_Get_Account_By_UserName()
        {

           var account = _repo.GetAccount("salzheimer", _optionBuilder);

            Assert.IsNotNull(account,"Cannot locate account with username salzheimer");
        }

        [TestMethod]
        public void Can_Get_Account_By_UserName_Fail()
        {

           var account = _repo.GetAccount("sddalzheimer", _optionBuilder);

            Assert.IsNull(account, "Located account with username sddalzheimer should be null");
        }
    }
}
