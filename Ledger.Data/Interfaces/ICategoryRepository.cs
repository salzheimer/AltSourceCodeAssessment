using System.Collections.Generic;
using Ledger.Core;
using Microsoft.EntityFrameworkCore;

namespace Ledger.Data.Interfaces
{
    public interface ICategoryRepository
    {
        int Create(Category category, DbContextOptionsBuilder<LedgerContext> context);
        Category GetCategory(int id, DbContextOptionsBuilder<LedgerContext> context);

        List<Category> GetCategories(DbContextOptionsBuilder<LedgerContext> context);
    }
}