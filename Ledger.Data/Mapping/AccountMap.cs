
using System.Data.Entity.ModelConfiguration;
using  Ledger.Core;

namespace Ledger.Data.Mapping
{
    public class AccountMap:EntityTypeConfiguration<Account>
    {

        public AccountMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("Account");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
