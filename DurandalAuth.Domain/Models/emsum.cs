using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class emsum
    {
        public decimal area { get; set; }
        public decimal area_avg { get; set; }
        public string bl_id { get; set; }
        public string bu_id { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string em_std { get; set; }
        public string fl_id { get; set; }
        public decimal pct_dp { get; set; }
        public decimal pct_rm { get; set; }
        public string site_id { get; set; }
        public int tot_count { get; set; }
        public int em_id { get; set; }
    }
}
