using System.Data.Entity.ModelConfiguration;
using Ledger.Core;

namespace Ledger.Data.Mapping
{
    public class PaymentTypeMap : EntityTypeConfiguration<PaymentType>
    {
        public PaymentTypeMap()
        {
            HasKey(t => t.Id);

            ToTable("PaymentType");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}