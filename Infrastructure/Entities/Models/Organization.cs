using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class Organization
    {
        public Organization()
        {
            this.Parties = new List<Party>();
        }

        public int OrganizationID { get; set; }
        public string OrganizationName { get; set; }
        public string FirmFSANumber { get; set; }
        public string FirmMetLifeID { get; set; }
        public virtual ICollection<Party> Parties { get; set; }
    }
}
