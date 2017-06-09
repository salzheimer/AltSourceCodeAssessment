using Ledger.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ledger.Data.Repositories;

namespace Ledger.Services.Api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StartUp" in both code and config file together.
    public class StartUp : IStartUp
    {

        public static DbContextOptionsBuilder<LedgerContext> OptionsBuilder;

        public void UseTestDatabase(bool IsInMemoryDb)
        {
            if (IsInMemoryDb)
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

            Data.Interfaces.ICategoryRepository catRepo= new CategoryRepository();
            for (int i = 0; i < catArray.Length; i++)
            {
                
                var currentCat = new Core.Category() {CategoryName = catArray[i]};
                catRepo.Create(currentCat, OptionsBuilder);

            }
        }
    }
}
