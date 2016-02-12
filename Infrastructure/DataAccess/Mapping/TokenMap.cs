using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class TokenMap : EntityTypeConfiguration<Token>
    {
        public TokenMap()
        {
            // Primary Key
            this.HasKey(t => t.TokenID);

            // Properties
            this.Property(t => t.TokenHash)
                .HasMaxLength(4000);

            this.Property(t => t.Description)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.ApplicationID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblToken");
            this.Property(t => t.TokenID).HasColumnName("TokenID");
            this.Property(t => t.TokenHash).HasColumnName("TokenHash");
            this.Property(t => t.PartyID).HasColumnName("PartyID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ApplicationID).HasColumnName("ApplicationID");
            this.Property(t => t.TokenIssueTime).HasColumnName("TokenIssueTime");

            // Relationships
            this.HasRequired(t => t.Application)
                .WithMany(t => t.Tokens)
                .HasForeignKey(d => d.ApplicationID);
            this.HasRequired(t => t.Party)
                .WithMany(t => t.Tokens)
                .HasForeignKey(d => d.PartyID);

        }
    }
}
