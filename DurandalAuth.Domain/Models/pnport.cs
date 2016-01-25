using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pnport
    {
        public string description { get; set; }
        public string pairs { get; set; }
        public string port_std { get; set; }
        public string tc_level { get; set; }
        public string tc_use_status { get; set; }
        public string pn_id { get; set; }
        public string port_id { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual pn pn { get; set; }
        public virtual portstd portstd { get; set; }
    }
}
