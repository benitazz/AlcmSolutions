using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wnstd
    {
        public wnstd()
        {
            this.wns = new List<wn>();
        }

        public string fr_elev { get; set; }
        public string fr_matl { get; set; }
        public string gl_thkns { get; set; }
        public string gl_type { get; set; }
        public string head_det { get; set; }
        public string head_sec { get; set; }
        public string height { get; set; }
        public string hm_det { get; set; }
        public string hm_sec { get; set; }
        public string jamb_det { get; set; }
        public string jamb_sec { get; set; }
        public string remarks { get; set; }
        public string sill_det { get; set; }
        public string sill_sec { get; set; }
        public string thkns { get; set; }
        public string vm_det { get; set; }
        public string vm_sec { get; set; }
        public string width { get; set; }
        public string wn_type { get; set; }
        public string wn_std { get; set; }
        public virtual ICollection<wn> wns { get; set; }
        public virtual wnfrmatl wnfrmatl { get; set; }
        public virtual wngltype wngltype { get; set; }
        public virtual wntype wntype { get; set; }
    }
}
