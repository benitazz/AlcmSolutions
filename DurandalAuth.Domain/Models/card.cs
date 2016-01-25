using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class card
    {
        public card()
        {
            this.cdports = new List<cdport>();
        }

        public string card_std { get; set; }
        public string description { get; set; }
        public string eq_id { get; set; }
        public string hardware_address { get; set; }
        public short is_multiplexing { get; set; }
        public string net_address { get; set; }
        public string net_id { get; set; }
        public string netdev_id { get; set; }
        public string netdev_type { get; set; }
        public string slot_id { get; set; }
        public string tc_level { get; set; }
        public string card_id { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual cardstd cardstd { get; set; }
        public virtual eq eq { get; set; }
        public virtual net net { get; set; }
        public virtual netdev netdev { get; set; }
        public virtual ICollection<cdport> cdports { get; set; }
    }
}
