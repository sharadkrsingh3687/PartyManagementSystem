using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class PartyAddress
    {
        public PartyAddress()
        {
            this.PartyContacts = new List<PartyContact>();
        }

        public int AddressID { get; set; }
        public string House { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string Postcode { get; set; }
        public string LandlineNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public int AddressTypeID { get; set; }
        public virtual AddressType AddressType { get; set; }
        public virtual ICollection<PartyContact> PartyContacts { get; set; }
    }
}
