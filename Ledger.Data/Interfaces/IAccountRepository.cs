using Ledger.Core;
using Microsoft.EntityFrameworkCore;

namespace Ledger.Data.Interfaces
{
    public interface IAccountRepository
    {
        int Create(Account account, DbContextOptionsBuilder<LedgerContext> context);
        Account GetAccount(string userName, DbContextOptionsBuilder<LedgerContext> context);
    }
}