using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ledger.Core;

namespace Ledger.Services.Api.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CategoryServices" in both code and config file together.
    public class CategoryServices : ICategoryServices
    {
        public string CreateCategory(Category category)
        {
            if (StartUp.OptionsBuilder == null) { return "Service is not started"; }
            Data.Interfaces.ICategoryRepository repo = new Data.Repositories.CategoryRepository();

            var result = repo.Create(category, StartUp.OptionsBuilder);

            if (result == 1)
            {
                return "Category created successfully";
            }
            else
            {
                return "Category creation failed";
            }
        }

        public void DoWork()
        {
        }

        public List<Category> GetCategories()
        {
            if (StartUp.OptionsBuilder == null) { throw new Exception( "Service is not started"); }
            Data.Interfaces.ICategoryRepository repo = new Data.Repositories.CategoryRepository();
            return repo.GetCategories(StartUp.OptionsBuilder);
        }

        public Category GetCategory(int id)
        {
            if (StartUp.OptionsBuilder == null) { throw new Exception("Service is not started"); }
            Data.Interfaces.ICategoryRepository repo = new Data.Repositories.CategoryRepository();

            return repo.GetCategory(id, StartUp.OptionsBuilder);
        }
    }
}
