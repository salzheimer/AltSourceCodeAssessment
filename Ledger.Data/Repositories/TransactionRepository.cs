using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using Ledger.Core;
using Ledger.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ledger.Data.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public int Create(Transaction transaction, DbContextOptionsBuilder<LedgerContext> context)
        {
            try
            {
                using (var ctx = new LedgerContext(context.Options))
                {
                    ctx.Transactions.Add(transaction);
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

        public Transaction GeTransaction(Guid id, DbContextOptionsBuilder<LedgerContext> context)
        {
            using (var ctx = new LedgerContext(context.Options))
            {
                var trans = ctx.Transactions.FirstOrDefault(t => t.Id == id);

                if (trans == null)
                    throw new Exception("Cannot locate transaction with this id");
                return trans;
            }
        }

        public List<Transaction> GeTransactions(Guid accountId, DbContextOptionsBuilder<LedgerContext> context)
        {
            using (var ctx = new LedgerContext(context.Options))
            {
                return ctx.Transactions.ToList();
            }
        }
    }
}