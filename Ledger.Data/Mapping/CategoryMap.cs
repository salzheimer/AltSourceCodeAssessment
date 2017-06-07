using System.Data.Entity.ModelConfiguration;
using Ledger.Core;

namespace Ledger.Data.Mapping
{
    public class CategoryMap:EntityTypeConfiguration<Category>
    {


        public CategoryMap()
        {

            this.HasKey(t => t.Id);

            this.ToTable("Category");

            this.Property(t => t.CatergoryName).HasColumnName("Name");

            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
