using System;
using System.Collections.Generic;
using Ledger.Core;
using Microsoft.EntityFrameworkCore;

namespace Ledger.Data.Interfaces
{
    public interface ITransactionRepository
    {
        Guid Create(Transaction transaction, DbContextOptionsBuilder<LedgerContext> context);
        Transaction GetTransaction(Guid id, DbContextOptionsBuilder<LedgerContext> context);
        List<Transaction> GetTransactions(Guid accountId, DbContextOptionsBuilder<LedgerContext> context);

        int RemoveTransaction(Guid transId, DbContextOptionsBuilder<LedgerContext> context);
        int UpdateTransaction(Guid transId, DbContextOptionsBuilder<LedgerContext> context);
    }
}