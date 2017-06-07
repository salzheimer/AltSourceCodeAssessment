using System.Data.Entity.ModelConfiguration;
using Ledger.Core;

namespace Ledger.Data.Mapping
{
    
public class PaymentTypeMap: EntityTypeConfiguration<PaymentType>
    {
        public PaymentTypeMap()
        {

            this.HasKey(t => t.Id);

            this.ToTable("PaymentType");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
