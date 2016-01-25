using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cardstd
    {
        public cardstd()
        {
            this.cards = new List<card>();
            this.portcfgs = new List<portcfg>();
        }

        public string description { get; set; }
        public short is_multiplexing { get; set; }
        public string netdev_type { get; set; }
        public string tc_contained_tbls { get; set; }
        public string tc_level { get; set; }
        public short tc_npositions { get; set; }
        public string card_std { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual ICollection<card> cards { get; set; }
        public virtual ICollection<portcfg> portcfgs { get; set; }
    }
}
