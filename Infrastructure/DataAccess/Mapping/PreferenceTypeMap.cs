using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class PreferenceTypeMap : EntityTypeConfiguration<PreferenceType>
    {
        public PreferenceTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.PreferenceTypeID);

            // Properties
            this.Property(t => t.PreferenceTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblPreferenceType");
            this.Property(t => t.PreferenceTypeID).HasColumnName("PreferenceTypeID");
            this.Property(t => t.PreferenceTypeName).HasColumnName("PreferenceType");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.StatusID).HasColumnName("StatusID");

            // Relationships
            this.HasRequired(t => t.Status)
                .WithMany(t => t.PreferenceTypes)
                .HasForeignKey(d => d.StatusID);

        }
    }
}
