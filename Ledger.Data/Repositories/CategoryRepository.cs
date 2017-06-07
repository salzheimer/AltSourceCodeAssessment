using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using Ledger.Core;
using Ledger.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ledger.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public int Create(Category category, DbContextOptionsBuilder<LedgerContext> context)
        {
            try
            {
                using (var ctx = new LedgerContext(context.Options))
                {
                    ctx.Categories.Add(category);
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

        public List<Category> GetCategories(DbContextOptionsBuilder<LedgerContext> context)
        {
            using (var ctx = new LedgerContext(context.Options))
            {
                return ctx.Categories.ToList();
            }
        }

        public Category GetCategory(int id, DbContextOptionsBuilder<LedgerContext> context)
        {
            using (var ctx = new LedgerContext(context.Options))
            {
                var cat = ctx.Categories.FirstOrDefault(c => c.Id == id);
                if (cat == null)
                    throw new Exception("Cannot find a category with this parameter");
                return cat;
            }
        }
    }
}