using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class netdevstd
    {
        public netdevstd()
        {
            this.netdevs = new List<netdev>();
            this.portcfgs = new List<portcfg>();
        }

        public decimal cost_purchase { get; set; }
        public string description { get; set; }
        public string image_file { get; set; }
        public short is_multiplexing { get; set; }
        public string netdev_type { get; set; }
        public string symbol { get; set; }
        public string tc_contained_tbls { get; set; }
        public string tc_level { get; set; }
        public short tc_npositions { get; set; }
        public string netdev_std { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual ICollection<netdev> netdevs { get; set; }
        public virtual ICollection<portcfg> portcfgs { get; set; }
    }
}
