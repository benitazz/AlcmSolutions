using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wr_step_waiting
    {
        public int wr_id { get; set; }
        public string em_id { get; set; }
        public string vn_id { get; set; }
        public string cf_id { get; set; }
        public string user_name { get; set; }
        public System.DateTime date_created { get; set; }
        public System.DateTime time_created { get; set; }
        public Nullable<System.DateTime> date_response { get; set; }
        public Nullable<System.DateTime> time_response { get; set; }
        public string status { get; set; }
        public string comments { get; set; }
        public string step { get; set; }
        public string step_code { get; set; }
        public string step_type { get; set; }
        public int step_log_id { get; set; }
        public string activity_id { get; set; }
        public string role_name { get; set; }
    }
}
