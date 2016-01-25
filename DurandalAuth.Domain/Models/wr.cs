using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wr
    {
        public wr()
        {
            this.wr_other = new List<wr_other>();
            this.wrcfs = new List<wrcf>();
            this.wrpts = new List<wrpt>();
            this.wrtls = new List<wrtl>();
            this.wrtrs = new List<wrtr>();
            this.wrtts = new List<wrtt>();
        }

        public string ac_id { get; set; }
        public decimal act_labor_hours { get; set; }
        public Nullable<int> activity_log_id { get; set; }
        public string activity_type { get; set; }
        public short allow_work_on_holidays { get; set; }
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
        public Nullable<decimal> curr_meter_val { get; set; }
        public Nullable<System.DateTime> date_assigned { get; set; }
        public Nullable<System.DateTime> date_closed { get; set; }
        public Nullable<System.DateTime> date_completed { get; set; }
        public Nullable<System.DateTime> date_escalation_completion { get; set; }
        public Nullable<System.DateTime> date_escalation_response { get; set; }
        public Nullable<System.DateTime> date_est_completion { get; set; }
        public Nullable<System.DateTime> date_requested { get; set; }
        public Nullable<System.DateTime> date_stat_chg { get; set; }
        public string desc_other_costs { get; set; }
        public string description { get; set; }
        public string dispatcher { get; set; }
        public string doc1 { get; set; }
        public string doc2 { get; set; }
        public string doc3 { get; set; }
        public string doc4 { get; set; }
        public Nullable<decimal> down_time { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string eq_id { get; set; }
        public short escalated_completion { get; set; }
        public short escalated_response { get; set; }
        public decimal est_labor_hours { get; set; }
        public string fl_id { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public Nullable<decimal> lat { get; set; }
        public string location { get; set; }
        public Nullable<decimal> lon { get; set; }
        public string manager { get; set; }
        public string msg_delivery_status { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string phone { get; set; }
        public string pmp_id { get; set; }
        public Nullable<int> pms_id { get; set; }
        public short priority { get; set; }
        public string prob_type { get; set; }
        public string repair_type { get; set; }
        public string requestor { get; set; }
        public Nullable<int> res_id { get; set; }
        public string rm_id { get; set; }
        public Nullable<int> rmres_id { get; set; }
        public Nullable<int> rsres_id { get; set; }
        public Nullable<short> satisfaction { get; set; }
        public string satisfaction_notes { get; set; }
        public string serv_window_days { get; set; }
        public Nullable<System.DateTime> serv_window_end { get; set; }
        public Nullable<System.DateTime> serv_window_start { get; set; }
        public string site_id { get; set; }
        public string status { get; set; }
        public string step_status { get; set; }
        public string supervisor { get; set; }
        public Nullable<System.DateTime> time_assigned { get; set; }
        public Nullable<System.DateTime> time_completed { get; set; }
        public Nullable<System.DateTime> time_escalation_completion { get; set; }
        public Nullable<System.DateTime> time_escalation_response { get; set; }
        public Nullable<System.DateTime> time_requested { get; set; }
        public Nullable<System.DateTime> time_stat_chg { get; set; }
        public string tr_id { get; set; }
        public string vn_id { get; set; }
        public Nullable<int> wo_id { get; set; }
        public string work_team_id { get; set; }
        public int wr_id { get; set; }
        public virtual ac ac { get; set; }
        public virtual activity_log activity_log { get; set; }
        public virtual activitytype activitytype { get; set; }
        public virtual bl bl { get; set; }
        public virtual causetyp causetyp { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Em em { get; set; }
        public virtual Em em1 { get; set; }
        public virtual Em em2 { get; set; }
        public virtual Em em3 { get; set; }
        public virtual Em em4 { get; set; }
        public virtual eq eq { get; set; }
        public virtual Fl fl { get; set; }
        public virtual pmp pmp { get; set; }
        public virtual Pm pm { get; set; }
        public virtual probtype probtype { get; set; }
        public virtual repairty repairty { get; set; }
        public virtual Rm rm { get; set; }
        public virtual site site { get; set; }
        public virtual tr tr { get; set; }
        public virtual vn vn { get; set; }
        public virtual wo wo { get; set; }
        public virtual work_team work_team { get; set; }
        public virtual ICollection<wr_other> wr_other { get; set; }
        public virtual ICollection<wrcf> wrcfs { get; set; }
        public virtual ICollection<wrpt> wrpts { get; set; }
        public virtual ICollection<wrtl> wrtls { get; set; }
        public virtual ICollection<wrtr> wrtrs { get; set; }
        public virtual ICollection<wrtt> wrtts { get; set; }
    }
}
