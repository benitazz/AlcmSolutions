using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ta_fnstdcnts
    {
        public string bl_id { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string em_id { get; set; }
        public string fl_id { get; set; }
        public string fn_std { get; set; }
        public int fnstd_count { get; set; }
        public string rm_id { get; set; }
        public int auto_number { get; set; }
        public virtual bl bl { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Em em { get; set; }
        public virtual Fl fl { get; set; }
        public virtual fnstd fnstd { get; set; }
        public virtual Rm rm { get; set; }
    }
}
