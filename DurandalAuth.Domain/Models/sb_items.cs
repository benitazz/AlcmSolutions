using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class sb_items
    {
        public string bl_id { get; set; }
        public string bu_id { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string fg_title { get; set; }
        public string fl_id { get; set; }
        public string p00_expr { get; set; }
        public decimal p00_value { get; set; }
        public string p01_expr { get; set; }
        public decimal p01_value { get; set; }
        public string p02_expr { get; set; }
        public decimal p02_value { get; set; }
        public string p03_expr { get; set; }
        public decimal p03_value { get; set; }
        public string p04_expr { get; set; }
        public decimal p04_value { get; set; }
        public string p05_expr { get; set; }
        public decimal p05_value { get; set; }
        public string p06_expr { get; set; }
        public decimal p06_value { get; set; }
        public string p07_expr { get; set; }
        public decimal p07_value { get; set; }
        public string p08_expr { get; set; }
        public decimal p08_value { get; set; }
        public string p09_expr { get; set; }
        public decimal p09_value { get; set; }
        public string p10_expr { get; set; }
        public decimal p10_value { get; set; }
        public string p11_expr { get; set; }
        public decimal p11_value { get; set; }
        public string p12_expr { get; set; }
        public decimal p12_value { get; set; }
        public string rm_std { get; set; }
        public string sb_name { get; set; }
        public int alloc_score { get; set; }
        public int alloc_score_ext { get; set; }
        public short auto_allocated { get; set; }
        public int auto_number { get; set; }
        public virtual bl bl { get; set; }
        public virtual bu bu { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Fl fl { get; set; }
        public virtual rmstd rmstd { get; set; }
        public virtual sb sb { get; set; }
    }
}
