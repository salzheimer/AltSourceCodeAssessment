using System.Data.Entity.ModelConfiguration;
using Ledger.Core;

namespace Ledger.Data.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            HasKey(t => t.Id);

            ToTable("Category");

            Property(t => t.CatergoryName).HasColumnName("Name");

            Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}