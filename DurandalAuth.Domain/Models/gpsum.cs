using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gpsum
    {
        public decimal area { get; set; }
        public decimal area_avg { get; set; }
        public string bl_id { get; set; }
        public string bu_id { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string fl_id { get; set; }
        public string gp_std { get; set; }
        public decimal pct_dp { get; set; }
        public decimal pct_gross_int { get; set; }
        public decimal pct_rentable { get; set; }
        public decimal pct_usable { get; set; }
        public string prorate { get; set; }
        public string site_id { get; set; }
        public int tot_count { get; set; }
        public int gp_id { get; set; }
    }
}
