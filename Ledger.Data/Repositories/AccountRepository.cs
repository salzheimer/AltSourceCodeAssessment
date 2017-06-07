using System;
using System.Data.Entity.Validation;
using Ledger.Core;
using Ledger.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ledger.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public int Create(Account account, DbContextOptionsBuilder<LedgerContext> context)
        {
            try
            {
                using (var ctx = new LedgerContext(context.Options))
                {
                    ctx.Accounts.Add(account);
                    return ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Account GetAccount(string userName, DbContextOptionsBuilder<LedgerContext> context)
        {
            throw new NotImplementedException();
        }
    }
}