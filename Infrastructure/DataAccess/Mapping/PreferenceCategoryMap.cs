using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class PreferenceCategoryMap : EntityTypeConfiguration<PreferenceCategory>
    {
        public PreferenceCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.PreferenceCategoryID);

            // Properties
            this.Property(t => t.PreferenceCategoryName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblPreferenceCategory");
            this.Property(t => t.PreferenceCategoryID).HasColumnName("PreferenceCategoryID");
            this.Property(t => t.PreferenceCategoryName).HasColumnName("PreferenceCategory");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.StatusID).HasColumnName("StatusID");

            // Relationships
            this.HasRequired(t => t.Status)
                .WithMany(t => t.PreferenceCategories)
                .HasForeignKey(d => d.StatusID);

        }
    }
}
