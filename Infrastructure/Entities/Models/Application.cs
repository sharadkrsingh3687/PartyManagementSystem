using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class Application
    {
        public Application()
        {
            this.ApplicationPartyRoles = new List<ApplicationPartyRole>();
            this.PartyApplicationActivities = new List<PartyApplicationActivity>();
            this.Tokens = new List<Token>();
        }

        public string ApplicationID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public int StatusID { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<ApplicationPartyRole> ApplicationPartyRoles { get; set; }
        public virtual ICollection<PartyApplicationActivity> PartyApplicationActivities { get; set; }
        public virtual ICollection<Token>Tokens { get; set; }
    }
}
