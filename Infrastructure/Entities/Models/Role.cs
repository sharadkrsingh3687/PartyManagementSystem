using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class Role
    {
        public Role()
        {
            this.Accesses = new List<Access>();
            this.ApplicationPartyRoles = new List<ApplicationPartyRole>();
        }

        public int MembershipID { get; set; }
        public string MembershipName { get; set; }
        public string MembershipDescription { get; set; }
        public virtual ICollection<Access> Accesses { get; set; }
        public virtual ICollection<ApplicationPartyRole> ApplicationPartyRoles { get; set; }
    }
}
