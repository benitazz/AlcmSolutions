using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rrwrrestr
    {
        public string bl_id { get; set; }
        public string name { get; set; }
        public string tr_id { get; set; }
        public Nullable<System.DateTime> date_assigned { get; set; }
        public Nullable<System.DateTime> time_assigned { get; set; }
        public string prob_type { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public string resource_name { get; set; }
        public Nullable<int> quantity { get; set; }
        public string rm_arrange_type_id { get; set; }
        public Nullable<int> total_guest { get; set; }
        public string requestor { get; set; }
        public string phone { get; set; }
        public string dv_id { get; set; }
        public string dp_id { get; set; }
        public string description { get; set; }
        public string ctry_id { get; set; }
        public string site_id { get; set; }
        public Nullable<int> res_id { get; set; }
        public string status { get; set; }
        public string vn_id { get; set; }
        public string config_id { get; set; }
    }
}
