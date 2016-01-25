using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class servsum
    {
        public decimal area { get; set; }
        public decimal area_avg { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public decimal pct_gross_int { get; set; }
        public decimal pct_rentable { get; set; }
        public string serv_std { get; set; }
        public string site_id { get; set; }
        public int tot_count { get; set; }
        public int serv_id { get; set; }
    }
}
