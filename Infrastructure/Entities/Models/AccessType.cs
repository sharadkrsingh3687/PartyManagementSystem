using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class AccessType
    {
        public AccessType()
        {
            this.Accesses = new List<Access>();
        }

        public string AccessTypeID { get; set; }
        public string AccessTypeDescription { get; set; }
        public virtual ICollection<Access> Accesses { get; set; }
    }
}
