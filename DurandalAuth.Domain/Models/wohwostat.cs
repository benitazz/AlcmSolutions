using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wohwostat
    {
        public string perform_date { get; set; }
        public string wo_type { get; set; }
        public string tr_id { get; set; }
        public string is_complete { get; set; }
        public Nullable<int> count_wo { get; set; }
        public Nullable<decimal> est_cost_sum { get; set; }
        public Nullable<decimal> act_cost_sum { get; set; }
        public Nullable<decimal> avg_cost_dif { get; set; }
    }
}
