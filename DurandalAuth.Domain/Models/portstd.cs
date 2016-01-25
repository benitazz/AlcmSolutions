using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class portstd
    {
        public portstd()
        {
            this.cdports = new List<cdport>();
            this.eqports = new List<eqport>();
            this.ndports = new List<ndport>();
            this.pnports = new List<pnport>();
            this.ports = new List<port>();
            this.portcfgs = new List<portcfg>();
        }

        public string connector_type { get; set; }
        public string description { get; set; }
        public string tc_level { get; set; }
        public string port_std { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual ICollection<cdport> cdports { get; set; }
        public virtual ICollection<eqport> eqports { get; set; }
        public virtual ICollection<ndport> ndports { get; set; }
        public virtual ICollection<pnport> pnports { get; set; }
        public virtual ICollection<port> ports { get; set; }
        public virtual ICollection<portcfg> portcfgs { get; set; }
    }
}
