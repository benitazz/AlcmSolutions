using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class reserve
    {
        public reserve()
        {
            this.reserve_rm = new List<reserve_rm>();
            this.reserve_rs = new List<reserve_rs>();
        }

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
        public short occurrence_index { get; set; }
        public string outlook_unique_id { get; set; }
        public string phone { get; set; }
        public short recurring_date_modified { get; set; }
        public string recurring_rule { get; set; }
        public Nullable<int> res_conference { get; set; }
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
        public int res_id { get; set; }
        public virtual ac ac { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Em em { get; set; }
        public virtual Em em1 { get; set; }
        public virtual Em em2 { get; set; }
        public virtual Em em3 { get; set; }
        public virtual ICollection<reserve_rm> reserve_rm { get; set; }
        public virtual ICollection<reserve_rs> reserve_rs { get; set; }
    }
}
