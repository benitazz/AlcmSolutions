using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class hwr_month
    {
        public int wr_id { get; set; }
        public string site_id { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public string requestor { get; set; }
        public string status { get; set; }
        public string dv_id { get; set; }
        public string dp_id { get; set; }
        public string ac_id { get; set; }
        public string repair_type { get; set; }
        public string cause_type { get; set; }
        public string prob_type { get; set; }
        public Nullable<System.DateTime> date_requested { get; set; }
        public Nullable<System.DateTime> time_requested { get; set; }
        public Nullable<System.DateTime> date_assigned { get; set; }
        public Nullable<System.DateTime> time_assigned { get; set; }
        public Nullable<System.DateTime> date_escalation_response { get; set; }
        public Nullable<System.DateTime> time_escalation_response { get; set; }
        public Nullable<System.DateTime> date_escalation_completion { get; set; }
        public Nullable<System.DateTime> time_escalation_completion { get; set; }
        public Nullable<System.DateTime> date_completed { get; set; }
        public Nullable<System.DateTime> time_completed { get; set; }
        public string tr_id { get; set; }
        public string eq_id { get; set; }
        public decimal cost_est_total { get; set; }
        public decimal cost_total { get; set; }
        public Nullable<int> wo_id { get; set; }
        public string work_team_id { get; set; }
        public short escalated_response { get; set; }
        public short escalated_completion { get; set; }
        public string supervisor { get; set; }
        public string month { get; set; }
        public string week { get; set; }
        public string eq_std { get; set; }
        public Nullable<decimal> cost_var { get; set; }
        public Nullable<short> satisfaction { get; set; }
    }
}
