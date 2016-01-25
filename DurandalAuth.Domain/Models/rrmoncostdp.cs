using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rrmoncostdp
    {
        public string ctry_id { get; set; }
        public string site_id { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public string rm_arrange_type_id { get; set; }
        public string config_id { get; set; }
        public System.DateTime date_start { get; set; }
        public string dv_id { get; set; }
        public string dp_id { get; set; }
        public string dv_dp_id { get; set; }
        public int res_id { get; set; }
        public string resource_id { get; set; }
        public decimal cost { get; set; }
        public string monthtxt { get; set; }
    }
}
