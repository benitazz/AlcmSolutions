using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_egrid_zip
    {
        public string city_id { get; set; }
        public string state_id { get; set; }
        public string version_type { get; set; }
        public string version_name { get; set; }
        public string subregion_code { get; set; }
        public string zip { get; set; }
        public virtual City city { get; set; }
        public virtual gb_fp_egrid_subregions gb_fp_egrid_subregions { get; set; }
        public virtual state state { get; set; }
        public virtual gb_fp_versions gb_fp_versions { get; set; }
    }
}
