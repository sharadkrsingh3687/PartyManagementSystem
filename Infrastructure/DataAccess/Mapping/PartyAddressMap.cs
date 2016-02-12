using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class PartyAddressMap : EntityTypeConfiguration<PartyAddress>
    {
        public PartyAddressMap()
        {
            // Primary Key
            this.HasKey(t => t.AddressID);

            // Properties
            this.Property(t => t.House)
                .HasMaxLength(200);

            this.Property(t => t.Street)
                .HasMaxLength(200);

            this.Property(t => t.Area)
                .HasMaxLength(200);

            this.Property(t => t.Postcode)
                .HasMaxLength(10);

            this.Property(t => t.LandlineNumber)
                .HasMaxLength(50);

            this.Property(t => t.MobileNumber)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tblPartyAddress");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.House).HasColumnName("House");
            this.Property(t => t.Street).HasColumnName("Street");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.LandlineNumber).HasColumnName("LandlineNumber");
            this.Property(t => t.MobileNumber).HasColumnName("MobileNumber");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.AddressTypeID).HasColumnName("AddressTypeID");

            // Relationships
            this.HasRequired(t => t.AddressType)
                .WithMany(t => t.PartyAddresses)
                .HasForeignKey(d => d.AddressTypeID);

        }
    }
}
