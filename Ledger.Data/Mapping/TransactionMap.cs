using System.Data.Entity.ModelConfiguration;
using Ledger.Core;


namespace Ledger.Data.Mapping
{
    public class TransactionMap:EntityTypeConfiguration<Transaction>
    {
        public TransactionMap()
        {

            this.HasKey(t => t.Id);

            this.ToTable("Transaction");

            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IsDeposit).HasColumnName("IsDeposit");
            this.Property(t => t.PaymentTypeId).HasColumnName("PaymentTypeId");
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }


    }
}
