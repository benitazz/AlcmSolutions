using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_mobile_data
    {
        public decimal ch4 { get; set; }
        public decimal ch4_entry { get; set; }
        public string ch4_n2o_units { get; set; }
        public string ch4_n2o_units_type { get; set; }
        public decimal co2 { get; set; }
        public decimal co2_entry { get; set; }
        public string co2_units { get; set; }
        public string co2_units_type { get; set; }
        public decimal n2o { get; set; }
        public decimal n2o_entry { get; set; }
        public string transp_type { get; set; }
        public string version_type { get; set; }
        public string version_name { get; set; }
        public string vehicle_type { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_type bill_type1 { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual bill_unit bill_unit1 { get; set; }
        public virtual gb_fp_versions gb_fp_versions { get; set; }
    }
}
