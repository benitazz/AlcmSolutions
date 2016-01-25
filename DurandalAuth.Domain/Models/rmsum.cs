using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rmsum
    {
        public decimal area { get; set; }
        public decimal area_avg { get; set; }
        public string bl_id { get; set; }
        public string bu_id { get; set; }
        public string description { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string fl_id { get; set; }
        public decimal pct_dp { get; set; }
        public decimal pct_rm { get; set; }
        public decimal pct_rm_dp { get; set; }
        public string prorate { get; set; }
        public string rm_cat { get; set; }
        public string rm_std { get; set; }
        public string rm_type { get; set; }
        public string site_id { get; set; }
        public int tot_count { get; set; }
        public int rm_id { get; set; }
    }
}
