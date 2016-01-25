using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class dr
    {
        public string fr_fnsh { get; set; }
        public string fr_matl { get; set; }
        public string fr_type { get; set; }
        public string head_det { get; set; }
        public string head_pf { get; set; }
        public string height { get; set; }
        public string jamb_det { get; set; }
        public string jamb_pf { get; set; }
        public string key_rmno { get; set; }
        public string layer_name { get; set; }
        public string remarks { get; set; }
        public string rm_name { get; set; }
        public string setno { get; set; }
        public string thkns { get; set; }
        public string thrs_det { get; set; }
        public string thrs_pf { get; set; }
        public string width { get; set; }
        public string dr_matl { get; set; }
        public string dr_std { get; set; }
        public string dr_type { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string fire_lbl { get; set; }
        public string dr_fnsh { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string dr_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual drfnsh drfnsh { get; set; }
        public virtual drmatl drmatl { get; set; }
        public virtual drstd drstd { get; set; }
        public virtual drtype drtype { get; set; }
        public virtual Fl fl { get; set; }
        public virtual drfrmatl drfrmatl { get; set; }
    }
}
