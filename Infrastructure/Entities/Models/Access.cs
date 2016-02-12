using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class Access
    {
        public int AccessID { get; set; }
        public Nullable<int> MembershipID { get; set; }
        public Nullable<int> ComponentID { get; set; }
        public string AccessTypeID { get; set; }
        public string ApplicationID { get; set; }
        public virtual AccessType AccessType { get; set; }
        public virtual Component Component { get; set; }
        public virtual Role Role { get; set; }
    }
}
