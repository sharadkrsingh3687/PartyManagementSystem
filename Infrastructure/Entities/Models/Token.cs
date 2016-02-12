using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class Token
    {
        public int TokenID { get; set; }
        public string TokenHash { get; set; }
        public int PartyID { get; set; }
        public string Description { get; set; }
        public string ApplicationID { get; set; }
        public System.DateTime TokenIssueTime { get; set; }
        public virtual Application Application { get; set; }
        public virtual Party Party { get; set; }
    }
}
