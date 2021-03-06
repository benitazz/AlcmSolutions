using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rrdayrmocc
    {
        public string status { get; set; }
        public string monthtxt { get; set; }
        public Nullable<decimal> total_hours { get; set; }
        public string rm_arrange_type_id { get; set; }
        public Nullable<int> rmres_id { get; set; }
        public Nullable<int> res_id { get; set; }
        public string config_id { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public string rm_arrange_type { get; set; }
        public Nullable<System.DateTime> time_start { get; set; }
        public Nullable<System.DateTime> time_end { get; set; }
        public string ctry_id { get; set; }
        public string site_id { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
    }
}
