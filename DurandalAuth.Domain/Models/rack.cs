using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rack
    {
        public rack()
        {
            this.eqs = new List<eq>();
            this.netdevs = new List<netdev>();
            this.pbs = new List<pb>();
            this.pns = new List<pn>();
            this.ports = new List<port>();
        }

        public string description { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string tc_level { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public string rack_id { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual bl bl { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual Fl fl { get; set; }
        public virtual ICollection<netdev> netdevs { get; set; }
        public virtual ICollection<pb> pbs { get; set; }
        public virtual ICollection<pn> pns { get; set; }
        public virtual ICollection<port> ports { get; set; }
        public virtual Rm rm { get; set; }
    }
}
