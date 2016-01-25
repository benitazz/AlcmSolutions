using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wr_sync
    {
        public string bl_id { get; set; }
        public string cause_type { get; set; }
        public string cf_notes { get; set; }
        public string completed_by { get; set; }
        public decimal cost_est_labor { get; set; }
        public decimal cost_est_other { get; set; }
        public decimal cost_est_parts { get; set; }
        public decimal cost_est_tools { get; set; }
        public decimal cost_est_total { get; set; }
        public decimal cost_labor { get; set; }
        public decimal cost_other { get; set; }
        public decimal cost_parts { get; set; }
        public decimal cost_tools { get; set; }
        public decimal cost_total { get; set; }
        public Nullable<System.DateTime> date_assigned { get; set; }
        public Nullable<System.DateTime> date_closed { get; set; }
        public Nullable<System.DateTime> date_completed { get; set; }
        public Nullable<System.DateTime> date_escalation_completion { get; set; }
        public Nullable<System.DateTime> date_escalation_response { get; set; }
        public Nullable<System.DateTime> date_est_completion { get; set; }
        public System.DateTime date_requested { get; set; }
        public string desc_other_costs { get; set; }
        public string description { get; set; }
        public string doc1 { get; set; }
        public string doc2 { get; set; }
        public string doc3 { get; set; }
        public string doc4 { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string eq_id { get; set; }
        public short escalated_completion { get; set; }
        public short escalated_response { get; set; }
        public string fl_id { get; set; }
        public string fwd_supervisor { get; set; }
        public string fwd_work_team_id { get; set; }
        public Nullable<short> is_req_craftsperson { get; set; }
        public Nullable<short> is_req_supervisor { get; set; }
        public Nullable<short> is_wt_self_assign { get; set; }
        public string location { get; set; }
        public string manager { get; set; }
        public Nullable<short> mob_is_changed { get; set; }
        public string mob_locked_by { get; set; }
        public string mob_pending_action { get; set; }
        public Nullable<short> mob_stat_step_chg { get; set; }
        public string mob_step_action { get; set; }
        public string mob_step_comments { get; set; }
        public Nullable<int> mob_wr_id { get; set; }
        public string pmp_id { get; set; }
        public Nullable<short> priority { get; set; }
        public string prob_type { get; set; }
        public string repair_type { get; set; }
        public Nullable<short> request_type { get; set; }
        public string requestor { get; set; }
        public string rm_id { get; set; }
        public string site_id { get; set; }
        public string status { get; set; }
        public string step { get; set; }
        public string step_em_id { get; set; }
        public Nullable<int> step_log_id { get; set; }
        public string step_role_name { get; set; }
        public string step_status { get; set; }
        public string step_type { get; set; }
        public string step_user_name { get; set; }
        public string supervisor { get; set; }
        public Nullable<System.DateTime> time_assigned { get; set; }
        public Nullable<System.DateTime> time_completed { get; set; }
        public Nullable<System.DateTime> time_requested { get; set; }
        public string tr_id { get; set; }
        public string work_team_id { get; set; }
        public Nullable<int> wr_id { get; set; }
        public int auto_number { get; set; }
    }
}
