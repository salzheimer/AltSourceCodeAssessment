using System.Data.Entity.ModelConfiguration;
using Ledger.Core;

namespace Ledger.Data.Mapping
{
    public class TransactionMap : EntityTypeConfiguration<Transaction>
    {
        public TransactionMap()
        {
            HasKey(t => t.Id);

            ToTable("Transaction");

            Property(t => t.CategoryId).HasColumnName("CategoryId");
            Property(t => t.Amount).HasColumnName("Amount");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.IsDeposit).HasColumnName("IsDeposit");
            Property(t => t.PaymentTypeId).HasColumnName("PaymentTypeId");
            Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}