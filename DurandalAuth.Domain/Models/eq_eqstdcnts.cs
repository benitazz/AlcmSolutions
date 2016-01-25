using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class eq_eqstdcnts
    {
        public string bl_id { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string em_id { get; set; }
        public string eq_std { get; set; }
        public int eqstd_count { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public int auto_number { get; set; }
        public virtual bl bl { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Em em { get; set; }
        public virtual eqstd eqstd { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Rm rm { get; set; }
    }
}
