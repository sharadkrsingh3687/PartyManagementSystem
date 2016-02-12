using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class PartyMap : EntityTypeConfiguration<Party>
    {
        public PartyMap()
        {
            // Primary Key
            this.HasKey(t => t.PartyID);

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MiddleName)
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblParty");
            this.Property(t => t.PartyID).HasColumnName("PartyID");
            this.Property(t => t.PartyTypeID).HasColumnName("PartyTypeID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.DOB).HasColumnName("DOB");
            this.Property(t => t.OrganizationID).HasColumnName("OrganizationID");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.CredentialID).HasColumnName("CredentialID");

            // Relationships
            this.HasOptional(t => t.Credential)
                .WithMany(t => t.Parties)
                .HasForeignKey(d => d.CredentialID);
            this.HasOptional(t => t.Organization)
                .WithMany(t => t.Parties)
                .HasForeignKey(d => d.OrganizationID);
            this.HasRequired(t => t.tblPartyType)
                .WithMany(t => t.Parties)
                .HasForeignKey(d => d.PartyTypeID);
            this.HasRequired(t => t.Status)
                .WithMany(t => t.Parties)
                .HasForeignKey(d => d.StatusID);

        }
    }
}
