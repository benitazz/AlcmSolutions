using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_wf_log
    {
        public string category { get; set; }
        public Nullable<int> column_position { get; set; }
        public System.DateTime date_of_event { get; set; }
        public string description { get; set; }
        public string event_id { get; set; }
        public string event_type { get; set; }
        public string help_context { get; set; }
        public string help_file { get; set; }
        public Nullable<int> line { get; set; }
        public string rule_id { get; set; }
        public string script { get; set; }
        public string scripting_code { get; set; }
        public string source { get; set; }
        public System.DateTime time_of_event { get; set; }
        public string transfer_status { get; set; }
        public string user_name { get; set; }
        public Nullable<int> activity_id { get; set; }
        public string activitydef_id { get; set; }
        public string attributes { get; set; }
        public int autonumbered_id { get; set; }
    }
}
