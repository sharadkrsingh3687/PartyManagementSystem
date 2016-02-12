using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class Credential
    {
        public Credential()
        {
            this.CredentialSecretQuestionAnswers = new List<CredentialSecretQuestionAnswer>();
            this.Parties = new List<Party>();
        }

        public int CredentialID { get; set; }
        public Nullable<int> LoginID { get; set; }
        public Nullable<int> CertificateID { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual Login Login { get; set; }
        public virtual ICollection<CredentialSecretQuestionAnswer> CredentialSecretQuestionAnswers { get; set; }
        public virtual ICollection<Party> Parties { get; set; }
    }
}
