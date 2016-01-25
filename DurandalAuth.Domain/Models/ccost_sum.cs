using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ccost_sum
    {
        public decimal amount_base_rent { get; set; }
        public decimal amount_operating { get; set; }
        public decimal amount_other { get; set; }
        public decimal amount_pct_rent { get; set; }
        public decimal amount_security { get; set; }
        public decimal amount_taxes { get; set; }
        public decimal amount_tot_rent_exp { get; set; }
        public decimal amount_tot_rent_inc { get; set; }
        public string bl_id { get; set; }
        public decimal cost_operating_total { get; set; }
        public decimal cost_other_total { get; set; }
        public decimal cost_tax_total { get; set; }
        public decimal cost_utility_total { get; set; }
        public Nullable<System.DateTime> date_costs_last_calcd { get; set; }
        public decimal income_total { get; set; }
        public string ls_id { get; set; }
        public string pr_id { get; set; }
        public string report_name { get; set; }
        public string user_name { get; set; }
        public int auto_number { get; set; }
        public virtual afm_users afm_users { get; set; }
        public virtual bl bl { get; set; }
        public virtual l l { get; set; }
        public virtual Property property { get; set; }
    }
}
