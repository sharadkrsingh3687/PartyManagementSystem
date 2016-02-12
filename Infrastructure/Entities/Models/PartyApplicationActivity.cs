using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class PartyApplicationActivity
    {
        public int PartyAplicationActivityID { get; set; }
        public int ActivityTypeID { get; set; }
        public string ApplicationID { get; set; }
        public int PartyID { get; set; }
        public string Description { get; set; }
        public virtual ActivityType ActivityType { get; set; }
        public virtual Application Application { get; set; }
        public virtual Party Party { get; set; }
    }
}
