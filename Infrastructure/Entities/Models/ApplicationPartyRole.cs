using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class ApplicationPartyRole
    {
        public string ApplicationID { get; set; }
        public int PartyID { get; set; }
        public int MembershipID { get; set; }
        public string Description { get; set; }
        public int ApplicationPartyRoleId { get; set; }
        public virtual Application Application { get; set; }
        public virtual Role Role { get; set; }
        public virtual Party Party { get; set; }
    }
}
