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
        public Guid Create(Transaction transaction, DbContextOptionsBuilder<LedgerContext> context)
        {
            try
            {
                using (var ctx = new LedgerContext(context.Options))
                {
                    transaction.DateCreated = DateTime.Now;
                    ctx.Transactions.Add(transaction);
                    if( ctx.SaveChanges()!=1)
                    {
                        return Guid.Empty;
                    }
                   
                        return transaction.Id;
                    
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

        public Transaction GetTransaction(Guid id, DbContextOptionsBuilder<LedgerContext> context)
        {
            using (var ctx = new LedgerContext(context.Options))
            {
                var trans = ctx.Transactions.FirstOrDefault(t => t.Id == id);

                if (trans == null)
                    throw new Exception("Cannot locate transaction with this id");
                return trans;
            }
        }

        public List<Transaction> GetTransactions(Guid accountId, DbContextOptionsBuilder<LedgerContext> context)
        {
            using (var ctx = new LedgerContext(context.Options))
            {
                return ctx.Transactions.ToList();
            }
        }

        public int RemoveTransaction(Guid transId, DbContextOptionsBuilder<LedgerContext> context)
        {
            using (var ctx = new LedgerContext(context.Options))
            {
                var entity = ctx.Transactions.FirstOrDefault(t => t.Id == transId);
                if (entity != null)
                {
                    ctx.Entry(entity).State = EntityState.Deleted;
                    
                }

                return ctx.SaveChanges();
            }
        }

        public int UpdateTransaction(Transaction transaction, DbContextOptionsBuilder<LedgerContext> context)
        {
            throw new NotImplementedException();
        }
    }
}