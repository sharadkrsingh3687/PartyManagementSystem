using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class ApplicationMap : EntityTypeConfiguration<Application>
    {
        public ApplicationMap()
        {
            // Primary Key
            this.HasKey(t => t.ApplicationID);

            // Properties
            this.Property(t => t.ApplicationID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Description)
                .HasMaxLength(2000);

            this.Property(t => t.URL)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("tblApplication");
            this.Property(t => t.ApplicationID).HasColumnName("ApplicationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.URL).HasColumnName("URL");
            this.Property(t => t.StatusID).HasColumnName("StatusID");

            // Relationships
            this.HasRequired(t => t.Status)
                .WithMany(t => t.Applications)
                .HasForeignKey(d => d.StatusID);

        }
    }
}
