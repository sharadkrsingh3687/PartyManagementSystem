using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class ComponentMap : EntityTypeConfiguration<Component>
    {
        public ComponentMap()
        {
            // Primary Key
            this.HasKey(t => t.ComponentID);

            // Properties
            this.Property(t => t.ComponentName)
                .HasMaxLength(50);

            this.Property(t => t.ComponentDescription)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("tblComponent");
            this.Property(t => t.ComponentID).HasColumnName("ComponentID");
            this.Property(t => t.ComponentName).HasColumnName("ComponentName");
            this.Property(t => t.ComponentDescription).HasColumnName("ComponentDescription");
        }
    }
}
