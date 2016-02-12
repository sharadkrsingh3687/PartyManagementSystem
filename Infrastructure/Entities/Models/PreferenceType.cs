using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class PreferenceType
    {
        public PreferenceType()
        {
            this.PartyPreferences = new List<PartyPreference>();
        }

        public int PreferenceTypeID { get; set; }
        public string PreferenceTypeName { get; set; }
        public string Description { get; set; }
        public int StatusID { get; set; }
        public virtual ICollection<PartyPreference> PartyPreferences { get; set; }
        public virtual Status Status { get; set; }
    }
}
