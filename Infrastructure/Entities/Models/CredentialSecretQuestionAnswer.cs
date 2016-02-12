using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class CredentialSecretQuestionAnswer
    {
        public int CredentialSecretQuestionID { get; set; }
        public int CredentialID { get; set; }
        public int SecretQuestionID { get; set; }
        public string SecretQuestionAnswer { get; set; }
        public virtual Credential Credential { get; set; }
        public virtual SecretQuestion SecretQuestion { get; set; }
    }
}
