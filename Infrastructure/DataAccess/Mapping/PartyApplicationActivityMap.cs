using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class PartyApplicationActivityMap : EntityTypeConfiguration<PartyApplicationActivity>
    {
        public PartyApplicationActivityMap()
        {
            // Primary Key
            this.HasKey(t => t.PartyAplicationActivityID);

            // Properties
            this.Property(t => t.ApplicationID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("tblPartyApplicationActivity");
            this.Property(t => t.PartyAplicationActivityID).HasColumnName("PartyAplicationActivityID");
            this.Property(t => t.ActivityTypeID).HasColumnName("ActivityTypeID");
            this.Property(t => t.ApplicationID).HasColumnName("ApplicationID");
            this.Property(t => t.PartyID).HasColumnName("PartyID");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasRequired(t => t.ActivityType)
                .WithMany(t => t.PartyApplicationActivities)
                .HasForeignKey(d => d.ActivityTypeID);
            this.HasRequired(t => t.Application)
                .WithMany(t => t.PartyApplicationActivities)
                .HasForeignKey(d => d.ApplicationID);
            this.HasRequired(t => t.Party)
                .WithMany(t => t.PartyApplicationActivities)
                .HasForeignKey(d => d.PartyID);

        }
    }
}
