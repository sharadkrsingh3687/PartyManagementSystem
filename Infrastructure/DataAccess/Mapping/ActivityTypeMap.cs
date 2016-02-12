using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class ActivityTypeMap : EntityTypeConfiguration<ActivityType>
    {
        public ActivityTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ActivityTypeID);

            // Properties
            this.Property(t => t.ActivityTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblActivityType");
            this.Property(t => t.ActivityTypeID).HasColumnName("ActivityTypeID");
            this.Property(t => t.ActivityTypeName).HasColumnName("ActivityTypeName");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
