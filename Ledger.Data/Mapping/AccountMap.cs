using System.Data.Entity.ModelConfiguration;
using Ledger.Core;

namespace Ledger.Data.Mapping
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            HasKey(t => t.Id);

            ToTable("Account");
            Property(t => t.FirstName).HasColumnName("FirstName");
            Property(t => t.LastName).HasColumnName("LastName");
            Property(t => t.UserName).HasColumnName("UserName");
            Property(t => t.Password).HasColumnName("Password");
            Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}