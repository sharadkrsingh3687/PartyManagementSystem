using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class EntityMap : EntityTypeConfiguration<Entity>
    {
        public EntityMap()
        {
            // Primary Key
            this.HasKey(t => t.EntityID);

            // Properties
            this.Property(t => t.EntityName)
                .HasMaxLength(100);

            this.Property(t => t.EntityURL)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("tblEntity");
            this.Property(t => t.EntityID).HasColumnName("EntityID");
            this.Property(t => t.EntityName).HasColumnName("EntityName");
            this.Property(t => t.EntityURL).HasColumnName("EntityURL");
        }
    }
}
