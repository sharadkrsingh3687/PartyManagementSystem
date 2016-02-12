using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class PartyPreferenceMap : EntityTypeConfiguration<PartyPreference>
    {
        public PartyPreferenceMap()
        {
            // Primary Key
            this.HasKey(t => t.PartyPreferenceID);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblPartyPreference");
            this.Property(t => t.PartyPreferenceID).HasColumnName("PartyPreferenceID");
            this.Property(t => t.PartyID).HasColumnName("PartyID");
            this.Property(t => t.PreferenceCategoryID).HasColumnName("PreferenceCategoryID");
            this.Property(t => t.PreferenceTypeID).HasColumnName("PreferenceTypeID");
            this.Property(t => t.IsMarketing).HasColumnName("IsMarketing");

            // Relationships
            this.HasRequired(t => t.Party)
                .WithMany(t => t.PartyPreferences)
                .HasForeignKey(d => d.PartyID);
            this.HasRequired(t => t.PreferenceCategory)
                .WithMany(t => t.PartyPreferences)
                .HasForeignKey(d => d.PreferenceCategoryID);
            this.HasRequired(t => t.PreferenceType)
                .WithMany(t => t.PartyPreferences)
                .HasForeignKey(d => d.PreferenceTypeID);

        }
    }
}
