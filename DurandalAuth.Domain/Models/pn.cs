using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pn
    {
        public pn()
        {
            this.pnports = new List<pnport>();
        }

        public string bl_id { get; set; }
        public string cross_connect_level { get; set; }
        public string description { get; set; }
        public string detail_dwg { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string fl_id { get; set; }
        public string pn_std { get; set; }
        public string rack_id { get; set; }
        public string rm_id { get; set; }
        public string shelf_id { get; set; }
        public string tc_level { get; set; }
        public string tc_service { get; set; }
        public string pn_id { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual pnstd pnstd { get; set; }
        public virtual rack rack { get; set; }
        public virtual Rm rm { get; set; }
        public virtual ICollection<pnport> pnports { get; set; }
    }
}
