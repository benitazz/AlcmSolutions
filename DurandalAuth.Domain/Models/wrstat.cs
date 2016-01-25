using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wrstat
    {
        public string perform_date { get; set; }
        public string prob_type { get; set; }
        public string status { get; set; }
        public int status_sort { get; set; }
        public Nullable<int> count_wr { get; set; }
        public Nullable<decimal> est_labor_sum { get; set; }
        public Nullable<decimal> act_labor_sum { get; set; }
        public Nullable<decimal> avg_labor_dif { get; set; }
        public Nullable<decimal> est_cost_sum { get; set; }
        public Nullable<decimal> act_cost_sum { get; set; }
        public Nullable<decimal> avg_cost_dif { get; set; }
    }
}
