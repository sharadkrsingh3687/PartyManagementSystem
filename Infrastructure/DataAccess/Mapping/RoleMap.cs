using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.MembershipID);

            // Properties
            this.Property(t => t.MembershipName)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.MembershipDescription)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("tblRole");
            this.Property(t => t.MembershipID).HasColumnName("MembershipID");
            this.Property(t => t.MembershipName).HasColumnName("MembershipName");
            this.Property(t => t.MembershipDescription).HasColumnName("MembershipDescription");
        }
    }
}
