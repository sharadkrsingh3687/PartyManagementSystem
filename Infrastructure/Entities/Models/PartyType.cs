using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class PartyType
    {
        public PartyType()
        {
            this.Parties = new List<Party>();
        }

        public int PartyTypeID { get; set; }
        public string PartyTypeName { get; set; }
        public string Description { get; set; }
        public int StatusID { get; set; }
        public virtual ICollection<Party> Parties { get; set; }
    }
}
