using System;
using System.Collections.Generic;

namespace Metlife.PMS.Infrastructure.Entities
{
    public partial class Certificate
    {
        public Certificate()
        {
            this.Credentials = new List<Credential>();
        }

        public int CertificateID { get; set; }
        public string CommonName { get; set; }
        public string OrganizationalUnit { get; set; }
        public string Country { get; set; }
        public int StatusID { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Credential> Credentials { get; set; }
    }
}
