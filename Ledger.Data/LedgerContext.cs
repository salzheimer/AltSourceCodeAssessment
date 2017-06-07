using Ledger.Core;
using Microsoft.EntityFrameworkCore;

namespace Ledger.Data
{
    public class LedgerContext : DbContext
    {
        public LedgerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
    }
}