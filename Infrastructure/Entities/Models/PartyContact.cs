using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class PartyContact
    {
        public int ContactID { get; set; }
        public int PartyID { get; set; }
        public int AddressID { get; set; }
        public string Description { get; set; }
        public int StatusID { get; set; }
        public virtual Party Party { get; set; }
        public virtual PartyAddress PartyAddress { get; set; }
    }
}
