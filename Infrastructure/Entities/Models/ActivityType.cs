using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class ActivityType
    {
        public ActivityType()
        {
            this.PartyApplicationActivities = new List<PartyApplicationActivity>();
        }

        public int ActivityTypeID { get; set; }
        public string ActivityTypeName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<PartyApplicationActivity> PartyApplicationActivities { get; set; }
    }
}
