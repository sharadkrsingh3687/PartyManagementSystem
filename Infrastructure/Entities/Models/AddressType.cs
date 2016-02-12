using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class AddressType
    {
        public AddressType()
        {
            this.PartyAddresses = new List<PartyAddress>();
        }

        public int AddressTypeID { get; set; }
        public string AddressTypeName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<PartyAddress> PartyAddresses { get; set; }
    }
}
