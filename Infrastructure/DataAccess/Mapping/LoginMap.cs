using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class LoginMap : EntityTypeConfiguration<Login>
    {
        public LoginMap()
        {
            // Primary Key
            this.HasKey(t => t.LoginID);

            // Properties
            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ResetCode)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblLogin");
            this.Property(t => t.LoginID).HasColumnName("LoginID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.IsReset).HasColumnName("IsReset");
            this.Property(t => t.ResetCode).HasColumnName("ResetCode");
            this.Property(t => t.StatusID).HasColumnName("StatusID");

            // Relationships
            this.HasRequired(t => t.Status)
                .WithMany(t => t.Logins)
                .HasForeignKey(d => d.StatusID);

        }
    }
}
