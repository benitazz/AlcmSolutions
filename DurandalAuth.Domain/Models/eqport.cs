using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class eqport
    {
        public string description { get; set; }
        public string hardware_address { get; set; }
        public string net_address { get; set; }
        public string port_std { get; set; }
        public string segment { get; set; }
        public string tc_level { get; set; }
        public string tc_use_status { get; set; }
        public string eq_id { get; set; }
        public string port_id { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual eq eq { get; set; }
        public virtual portstd portstd { get; set; }
    }
}
