using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class activity_log_sync
    {
        public string bl_id { get; set; }
        public string completed_by { get; set; }
        public short cond_priority { get; set; }
        public short cond_value { get; set; }
        public decimal cost_act_cap { get; set; }
        public decimal cost_est_cap { get; set; }
        public decimal cost_estimated { get; set; }
        public decimal cost_to_replace { get; set; }
        public string csi_id { get; set; }
        public Nullable<System.DateTime> date_assessed { get; set; }
        public System.DateTime date_requested { get; set; }
        public Nullable<System.DateTime> date_verified { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string doc1 { get; set; }
        public string doc2 { get; set; }
        public string doc3 { get; set; }
        public string doc4 { get; set; }
        public string eq_id { get; set; }
        public string fl_id { get; set; }
        public string location { get; set; }
        public Nullable<short> mob_is_changed { get; set; }
        public string mob_locked_by { get; set; }
        public string phone_requestor { get; set; }
        public string prob_type { get; set; }
        public string project_id { get; set; }
        public string questionnaire_id { get; set; }
        public short rec_action { get; set; }
        public string requestor { get; set; }
        public string rm_id { get; set; }
        public string site_id { get; set; }
        public string status { get; set; }
        public short sust_priority { get; set; }
        public string verified_by { get; set; }
        public string act_quest { get; set; }
        public Nullable<int> activity_log_id { get; set; }
        public string activity_type { get; set; }
        public string assessed_by { get; set; }
        public int auto_number { get; set; }
        public virtual activitytype activitytype { get; set; }
        public virtual probtype probtype { get; set; }
        public virtual Em em { get; set; }
    }
}
