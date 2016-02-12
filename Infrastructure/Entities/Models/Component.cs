using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class Component
    {
        public Component()
        {
            this.Accesses = new List<Access>();
        }

        public int ComponentID { get; set; }
        public string ComponentName { get; set; }
        public string ComponentDescription { get; set; }
        public virtual ICollection<Access> Accesses { get; set; }
    }
}
