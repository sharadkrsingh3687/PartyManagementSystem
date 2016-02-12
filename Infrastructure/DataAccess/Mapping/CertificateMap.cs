using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class CertificateMap : EntityTypeConfiguration<Certificate>
    {
        public CertificateMap()
        {
            // Primary Key
            this.HasKey(t => t.CertificateID);

            // Properties
            this.Property(t => t.CommonName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OrganizationalUnit)
                .HasMaxLength(200);

            this.Property(t => t.Country)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblCertificate");
            this.Property(t => t.CertificateID).HasColumnName("CertificateID");
            this.Property(t => t.CommonName).HasColumnName("CommonName");
            this.Property(t => t.OrganizationalUnit).HasColumnName("OrganizationalUnit");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.StatusID).HasColumnName("StatusID");

            // Relationships
            this.HasRequired(t => t.Status)
                .WithMany(t => t.Certificates)
                .HasForeignKey(d => d.StatusID);

        }
    }
}
