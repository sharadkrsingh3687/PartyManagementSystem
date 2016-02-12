using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class SecretQuestionMap : EntityTypeConfiguration<SecretQuestion>
    {
        public SecretQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.SecretQuestionID);

            // Properties
            this.Property(t => t.SecretQustionDescription)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblSecretQuestion");
            this.Property(t => t.SecretQuestionID).HasColumnName("SecretQuestionID");
            this.Property(t => t.SecretQustionDescription).HasColumnName("SecretQustionDescription");
            this.Property(t => t.StatusID).HasColumnName("StatusID");

            // Relationships
            this.HasRequired(t => t.Status)
                .WithMany(t => t.SecretQuestions)
                .HasForeignKey(d => d.StatusID);

        }
    }
}
