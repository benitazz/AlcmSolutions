using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rrappdet
    {
        public int res_id { get; set; }
        public System.DateTime date_start { get; set; }
        public System.DateTime time_start { get; set; }
        public System.DateTime time_end { get; set; }
        public string user_requested_by { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public string rm_arrange_type_id { get; set; }
        public string resource_id { get; set; }
        public Nullable<short> quantity { get; set; }
        public string status { get; set; }
        public string ctry_id { get; set; }
        public string site_id { get; set; }
        public string config_id { get; set; }
    }
}
