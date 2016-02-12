using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class PartyTypeMap : EntityTypeConfiguration<PartyType>
    {
        public PartyTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.PartyTypeID);

            // Properties
            this.Property(t => t.PartyTypeName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblPartyType");
            this.Property(t => t.PartyTypeID).HasColumnName("PartyTypeID");
            this.Property(t => t.PartyTypeName).HasColumnName("PartyType");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
        }
    }
}
