using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class Status
    {
        public Status()
        {
            this.Applications = new List<Application>();
            this.Certificates = new List<Certificate>();
            this.Logins = new List<Login>();
            this.Parties = new List<Party>();
            this.PreferenceCategories = new List<PreferenceCategory>();
            this.PreferenceTypes = new List<PreferenceType>();
            this.SecretQuestions = new List<SecretQuestion>();
        }

        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<Certificate> Certificates { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<Party> Parties { get; set; }
        public virtual ICollection<PreferenceCategory> PreferenceCategories { get; set; }
        public virtual ICollection<PreferenceType> PreferenceTypes { get; set; }
        public virtual ICollection<SecretQuestion> SecretQuestions { get; set; }
    }
}
