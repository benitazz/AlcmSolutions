using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rrressheetplu
    {
        public int res_id { get; set; }
        public System.DateTime date_start { get; set; }
        public string ctry_id { get; set; }
        public string site_id { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public string user_created_by { get; set; }
        public string user_requested_by { get; set; }
        public string user_requested_for { get; set; }
        public string dv_id { get; set; }
        public string dp_id { get; set; }
        public string reservation_name { get; set; }
        public string status { get; set; }
    }
}
