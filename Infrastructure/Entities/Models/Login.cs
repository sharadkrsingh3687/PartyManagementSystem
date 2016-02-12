using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class Login
    {
        public Login()
        {
            this.Credentials = new List<Credential>();
        }

        public int LoginID { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public bool IsReset { get; set; }
        public string ResetCode { get; set; }
        public int StatusID { get; set; }
        public virtual ICollection<Credential> Credentials { get; set; }
        public virtual Status Status { get; set; }
    }
}
