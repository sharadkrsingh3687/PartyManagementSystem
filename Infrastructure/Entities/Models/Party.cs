using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class Party
    {
        public Party()
        {
            this.ApplicationPartyRoles = new List<ApplicationPartyRole>();
            this.PartyContacts = new List<PartyContact>();
            this.PartyApplicationActivities = new List<PartyApplicationActivity>();
            this.PartyPreferences = new List<PartyPreference>();
            this.Tokens = new List<Token>();
        }

        public int PartyID { get; set; }
        public int PartyTypeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> OrganizationID { get; set; }
        public int StatusID { get; set; }
        public Nullable<int> CredentialID { get; set; }
        public virtual ICollection<ApplicationPartyRole> ApplicationPartyRoles { get; set; }
        public virtual Credential Credential { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<PartyContact> PartyContacts { get; set; }
        public virtual PartyType tblPartyType { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<PartyApplicationActivity> PartyApplicationActivities { get; set; }
        public virtual ICollection<PartyPreference> PartyPreferences { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
    }
}
