﻿using System.Linq;
using Ledger.Core;
using Ledger.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ledger.Test.Data
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void Can_Create_Account()
        {
            var optionBuilder = new DbContextOptionsBuilder<LedgerContext>();
            optionBuilder.UseInMemoryDatabase();

            using (var context = new LedgerContext(optionBuilder.Options))
            {
                context.Accounts.Add(new Account
                {
                    FirstName = "Bob",
                    LastName = "Villa",
                    UserName = "BVilla",
                    Password = "I am Awesome"
                });
                context.SaveChanges();

                var account = context.Accounts.FirstOrDefault(a => a.UserName == "BVilla");

                Assert.IsNotNull(account, "Account was not successfully created");
            }
        }

        [TestMethod]
        public void Can_Get_Account()
        {
            var optionBuilder = new DbContextOptionsBuilder<LedgerContext>();
            optionBuilder.UseInMemoryDatabase();

            using (var context = new LedgerContext(optionBuilder.Options))
            {
                var account = context.Accounts.FirstOrDefault(a => a.UserName == "BVilla");

                Assert.IsNotNull(account, "Can not locate account");
            }
        }
    }
}