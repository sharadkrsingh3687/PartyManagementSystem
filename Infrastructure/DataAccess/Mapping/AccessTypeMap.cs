using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class AccessTypeMap : EntityTypeConfiguration<AccessType>
    {
        public AccessTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.AccessTypeID);

            // Properties
            this.Property(t => t.AccessTypeID)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.AccessTypeDescription)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblAccessType");
            this.Property(t => t.AccessTypeID).HasColumnName("AccessTypeID");
            this.Property(t => t.AccessTypeDescription).HasColumnName("AccessTypeDescription");
        }
    }
}
