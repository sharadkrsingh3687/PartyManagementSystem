using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class SecretQuestion
    {
        public SecretQuestion()
        {
            this.CredentialSecretQuestionAnswers = new List<CredentialSecretQuestionAnswer>();
        }

        public int SecretQuestionID { get; set; }
        public string SecretQustionDescription { get; set; }
        public int StatusID { get; set; }
        public virtual ICollection<CredentialSecretQuestionAnswer> CredentialSecretQuestionAnswers { get; set; }
        public virtual Status Status { get; set; }
    }
}
