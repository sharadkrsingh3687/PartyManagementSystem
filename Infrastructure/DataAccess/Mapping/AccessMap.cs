using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class AccessMap : EntityTypeConfiguration<Access>
    {
        public AccessMap()
        {
            // Primary Key
            this.HasKey(t => t.AccessID);

            // Properties
            this.Property(t => t.AccessTypeID)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ApplicationID)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tblAccess");
            this.Property(t => t.AccessID).HasColumnName("AccessID");
            this.Property(t => t.MembershipID).HasColumnName("MembershipID");
            this.Property(t => t.ComponentID).HasColumnName("ComponentID");
            this.Property(t => t.AccessTypeID).HasColumnName("AccessTypeID");
            this.Property(t => t.ApplicationID).HasColumnName("ApplicationID");

            // Relationships
            this.HasRequired(t => t.AccessType)
                .WithMany(t => t.Accesses)
                .HasForeignKey(d => d.AccessTypeID);
            this.HasOptional(t => t.Component)
                .WithMany(t => t.Accesses)
                .HasForeignKey(d => d.ComponentID);
            this.HasOptional(t => t.Role)
                .WithMany(t => t.Accesses)
                .HasForeignKey(d => d.MembershipID);

        }
    }
}
