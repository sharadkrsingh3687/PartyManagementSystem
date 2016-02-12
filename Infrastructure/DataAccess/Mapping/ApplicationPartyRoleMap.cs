using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class ApplicationPartyRoleMap : EntityTypeConfiguration<ApplicationPartyRole>
    {
        public ApplicationPartyRoleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ApplicationID, t.PartyID, t.MembershipID, t.ApplicationPartyRoleId });

            // Properties
            this.Property(t => t.ApplicationID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PartyID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MembershipID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Description)
                .HasMaxLength(2000);

            this.Property(t => t.ApplicationPartyRoleId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("tblApplicationPartyRole");
            this.Property(t => t.ApplicationID).HasColumnName("ApplicationID");
            this.Property(t => t.PartyID).HasColumnName("PartyID");
            this.Property(t => t.MembershipID).HasColumnName("MembershipID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ApplicationPartyRoleId).HasColumnName("ApplicationPartyRoleId");

            // Relationships
            this.HasRequired(t => t.Application)
                .WithMany(t => t.ApplicationPartyRoles)
                .HasForeignKey(d => d.ApplicationID);
            this.HasRequired(t => t.Role)
                .WithMany(t => t.ApplicationPartyRoles)
                .HasForeignKey(d => d.MembershipID);
            this.HasRequired(t => t.Party)
                .WithMany(t => t.ApplicationPartyRoles)
                .HasForeignKey(d => d.PartyID);

        }
    }
}
