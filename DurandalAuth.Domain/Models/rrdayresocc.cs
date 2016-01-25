using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rrdayresocc
    {
        public string monthtxt { get; set; }
        public Nullable<int> total_hours { get; set; }
        public string resource_name { get; set; }
        public string resource_id { get; set; }
        public string status { get; set; }
        public System.DateTime time_start { get; set; }
        public System.DateTime time_end { get; set; }
        public string ctry_id { get; set; }
        public string site_id { get; set; }
        public string bl_id { get; set; }
        public System.DateTime date_start { get; set; }
        public int rsres_id { get; set; }
        public int res_id { get; set; }
        public string resource_std { get; set; }
    }
}
