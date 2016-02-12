using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.Infrastructure.DataAccess.Mapping
{
    public class CredentialSecretQuestionAnswerMap : EntityTypeConfiguration<CredentialSecretQuestionAnswer>
    {
        public CredentialSecretQuestionAnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.CredentialSecretQuestionID);

            // Properties
            this.Property(t => t.SecretQuestionAnswer)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblCredentialSecretQuestionAnswer");
            this.Property(t => t.CredentialSecretQuestionID).HasColumnName("CredentialSecretQuestionID");
            this.Property(t => t.CredentialID).HasColumnName("CredentialID");
            this.Property(t => t.SecretQuestionID).HasColumnName("SecretQuestionID");
            this.Property(t => t.SecretQuestionAnswer).HasColumnName("SecretQuestionAnswer");

            // Relationships
            this.HasRequired(t => t.Credential)
                .WithMany(t => t.CredentialSecretQuestionAnswers)
                .HasForeignKey(d => d.CredentialID);
            this.HasRequired(t => t.SecretQuestion)
                .WithMany(t => t.CredentialSecretQuestionAnswers)
                .HasForeignKey(d => d.SecretQuestionID);

        }
    }
}
