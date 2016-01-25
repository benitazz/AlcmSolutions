using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wn
    {
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
        public string layer_name { get; set; }
        public string remarks { get; set; }
        public string sill_det { get; set; }
        public string sill_sec { get; set; }
        public string thkns { get; set; }
        public string vm_det { get; set; }
        public string vm_sec { get; set; }
        public string width { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string wn_std { get; set; }
        public string wn_type { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string wn_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual wnfrmatl wnfrmatl { get; set; }
        public virtual wngltype wngltype { get; set; }
        public virtual wnstd wnstd { get; set; }
        public virtual wntype wntype { get; set; }
    }
}
