using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class CredentialMap : EntityTypeConfiguration<Credential>
    {
        public CredentialMap()
        {
            // Primary Key
            this.HasKey(t => t.CredentialID);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblCredential");
            this.Property(t => t.CredentialID).HasColumnName("CredentialID");
            this.Property(t => t.LoginID).HasColumnName("LoginID");
            this.Property(t => t.CertificateID).HasColumnName("CertificateID");

            // Relationships
            this.HasOptional(t => t.Certificate)
                .WithMany(t => t.Credentials)
                .HasForeignKey(d => d.CertificateID);
            this.HasOptional(t => t.Login)
                .WithMany(t => t.Credentials)
                .HasForeignKey(d => d.LoginID);

        }
    }
}
