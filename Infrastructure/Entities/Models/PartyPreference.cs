using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class PartyPreference
    {
        public int PartyPreferenceID { get; set; }
        public int PartyID { get; set; }
        public int PreferenceCategoryID { get; set; }
        public int PreferenceTypeID { get; set; }
        public Nullable<bool> IsMarketing { get; set; }
        public virtual Party Party { get; set; }
        public virtual PreferenceCategory PreferenceCategory { get; set; }
        public virtual PreferenceType PreferenceType { get; set; }
    }
}
