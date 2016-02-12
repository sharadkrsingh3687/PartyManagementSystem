using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class PartyContactMap : EntityTypeConfiguration<PartyContact>
    {
        public PartyContactMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactID);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblPartyContact");
            this.Property(t => t.ContactID).HasColumnName("ContactID");
            this.Property(t => t.PartyID).HasColumnName("PartyID");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.StatusID).HasColumnName("StatusID");

            // Relationships
            this.HasRequired(t => t.Party)
                .WithMany(t => t.PartyContacts)
                .HasForeignKey(d => d.PartyID);
            this.HasRequired(t => t.PartyAddress)
                .WithMany(t => t.PartyContacts)
                .HasForeignKey(d => d.AddressID);

        }
    }
}
