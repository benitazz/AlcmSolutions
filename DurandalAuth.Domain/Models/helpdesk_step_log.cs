using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class helpdesk_step_log
    {
        public string activity_id { get; set; }
        public string cf_id { get; set; }
        public string comments { get; set; }
        public string condition { get; set; }
        public System.DateTime date_created { get; set; }
        public Nullable<System.DateTime> date_response { get; set; }
        public string em_id { get; set; }
        public short email_sent { get; set; }
        public string field_name { get; set; }
        public short multiple_required { get; set; }
        public int pkey_value { get; set; }
        public string role_name { get; set; }
        public string status { get; set; }
        public string step { get; set; }
        public string step_code { get; set; }
        public int step_order { get; set; }
        public string step_status_result { get; set; }
        public string step_type { get; set; }
        public string table_name { get; set; }
        public System.DateTime time_created { get; set; }
        public Nullable<System.DateTime> time_response { get; set; }
        public string user_name { get; set; }
        public string vn_id { get; set; }
        public int step_log_id { get; set; }
        public virtual afm_activities afm_activities { get; set; }
        public virtual afm_flds afm_flds { get; set; }
        public virtual afm_roles afm_roles { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
        public virtual afm_users afm_users { get; set; }
        public virtual afm_wf_steps afm_wf_steps { get; set; }
        public virtual cf cf { get; set; }
        public virtual Em em { get; set; }
        public virtual vn vn { get; set; }
    }
}
