using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class OrganizationMap : EntityTypeConfiguration<Organization>
    {
        public OrganizationMap()
        {
            // Primary Key
            this.HasKey(t => t.OrganizationID);

            // Properties
            this.Property(t => t.OrganizationName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FirmFSANumber)
                .HasMaxLength(200);

            this.Property(t => t.FirmMetLifeID)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("tblOrganization");
            this.Property(t => t.OrganizationID).HasColumnName("OrganizationID");
            this.Property(t => t.OrganizationName).HasColumnName("OrganizationName");
            this.Property(t => t.FirmFSANumber).HasColumnName("FirmFSANumber");
            this.Property(t => t.FirmMetLifeID).HasColumnName("FirmMetLifeID");
        }
    }
}
