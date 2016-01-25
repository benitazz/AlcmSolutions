using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class hwrsum
    {
        public decimal avg_response_time { get; set; }
        public string bl_id { get; set; }
        public string cause_type { get; set; }
        public decimal cost_est_total { get; set; }
        public decimal cost_labor { get; set; }
        public decimal cost_other { get; set; }
        public decimal cost_parts { get; set; }
        public decimal cost_tools { get; set; }
        public decimal cost_total { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string eq_id { get; set; }
        public string eq_std { get; set; }
        public decimal est_labor_hours { get; set; }
        public int hwr_count { get; set; }
        public Nullable<short> is_pm { get; set; }
        public Nullable<short> month { get; set; }
        public string prob_type { get; set; }
        public string repair_type { get; set; }
        public string tr_id { get; set; }
        public Nullable<short> year { get; set; }
        public string ac_id { get; set; }
        public decimal act_labor_hours { get; set; }
        public int auto_number { get; set; }
    }
}
