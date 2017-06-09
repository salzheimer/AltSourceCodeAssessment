using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ledger.Data.Repositories;
using Ledger.Data.Interfaces;

namespace Ledger.Services.Api.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Account" in both code and config file together.
    public class AccountService : IAccountService
    {
        public string CreateAccount(Core.Account account)
        {
            //validate if in memory db has been started
            if (StartUp.OptionsBuilder == null)
            {
                return "Service not started";
            }
            IAccountRepository repo = new AccountRepository();

            var success = repo.Create(account, StartUp.OptionsBuilder);
            if (success == 1)
            {
                return string.Format("Account for user {0} was created successfully", account.UserName);
            }
            else
            {
                return string.Format("Account creation for user {0} failed", account.UserName);
            }
        }

        public void DoWork()
        {
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
            if (StartUp.OptionsBuilder == null)
            {
                return "Service not started";
            }

            IAccountRepository repo = new AccountRepository();

            var user = repo.GetAccount(userName, StartUp.OptionsBuilder);

            if (user != null && user.Password == password)
            {
                return user.Id.ToString();
            }
            else {
                return "User Name or password are not in our system. Please try again";
            }
        }

        /// <summary>
        /// LogOut disables connection to in memory database 
        /// </summary>
        public void LogOut()
        {
            StartUp.OptionsBuilder = null;
        }
    }
}
