using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class PreferenceCategory
    {
        public PreferenceCategory()
        {
            this.PartyPreferences = new List<PartyPreference>();
        }

        public int PreferenceCategoryID { get; set; }
        public string PreferenceCategoryName { get; set; }
        public string Description { get; set; }
        public int StatusID { get; set; }
        public virtual ICollection<PartyPreference> PartyPreferences { get; set; }
        public virtual Status Status { get; set; }
    }
}
