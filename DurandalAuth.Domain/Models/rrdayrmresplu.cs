using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rrdayrmresplu
    {
        public string bl_id { get; set; }
        public System.DateTime date_start { get; set; }
        public System.DateTime time_start { get; set; }
        public System.DateTime time_end { get; set; }
        public Nullable<int> res_id { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public string resource_id { get; set; }
        public int quantity { get; set; }
        public string user_requested_for { get; set; }
        public string phone { get; set; }
        public string dv_id { get; set; }
        public string dp_id { get; set; }
        public string comments { get; set; }
        public string rm_arrange_type_id { get; set; }
        public Nullable<int> total_guest { get; set; }
        public string status { get; set; }
        public string ctry_id { get; set; }
        public string site_id { get; set; }
        public string reservation_name { get; set; }
        public string tr_id { get; set; }
        public string vn_id { get; set; }
    }
}
