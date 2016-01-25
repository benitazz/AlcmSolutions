using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class portcfg
    {
        public string card_std { get; set; }
        public string description { get; set; }
        public string eq_std { get; set; }
        public string netdev_std { get; set; }
        public short num_ports { get; set; }
        public string pn_std { get; set; }
        public string port_std { get; set; }
        public string prefix { get; set; }
        public short start_number { get; set; }
        public string tc_level { get; set; }
        public int auto_number { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual cardstd cardstd { get; set; }
        public virtual eqstd eqstd { get; set; }
        public virtual netdevstd netdevstd { get; set; }
        public virtual pnstd pnstd { get; set; }
        public virtual portstd portstd { get; set; }
    }
}
