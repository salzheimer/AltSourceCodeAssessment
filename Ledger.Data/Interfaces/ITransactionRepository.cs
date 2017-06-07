using System;
using System.Collections.Generic;
using Ledger.Core;
using Microsoft.EntityFrameworkCore;

namespace Ledger.Data.Interfaces
{
    public interface ITransactionRepository
    {
        int Create(Transaction transaction, DbContextOptionsBuilder<LedgerContext> context);
        Transaction GeTransaction(Guid id, DbContextOptionsBuilder<LedgerContext> context);
        List<Transaction> GeTransactions(Guid accountId, DbContextOptionsBuilder<LedgerContext> context);
    }
}