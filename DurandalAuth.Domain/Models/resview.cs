using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class resview
    {
        public string ac_id { get; set; }
        public string attendees { get; set; }
        public string comments { get; set; }
        public string contact { get; set; }
        public decimal cost_res { get; set; }
        public Nullable<System.DateTime> date_cancelled { get; set; }
        public System.DateTime date_created { get; set; }
        public System.DateTime date_end { get; set; }
        public Nullable<System.DateTime> date_last_modified { get; set; }
        public System.DateTime date_start { get; set; }
        public string doc_event { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public short recurring_date_modified { get; set; }
        public string recurring_rule { get; set; }
        public int res_id { get; set; }
        public Nullable<int> res_parent { get; set; }
        public string res_type { get; set; }
        public string reservation_name { get; set; }
        public string status { get; set; }
        public System.DateTime time_end { get; set; }
        public System.DateTime time_start { get; set; }
        public string user_created_by { get; set; }
        public string user_last_modified_by { get; set; }
        public string user_requested_by { get; set; }
        public string user_requested_for { get; set; }
        public Nullable<int> res_conference { get; set; }
    }
}
