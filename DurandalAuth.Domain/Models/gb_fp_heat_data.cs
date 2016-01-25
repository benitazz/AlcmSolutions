using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_heat_data
    {
        public decimal content { get; set; }
        public decimal content_entry { get; set; }
        public decimal conv_factor { get; set; }
        public decimal conv_gcv { get; set; }
        public string units { get; set; }
        public string units_type { get; set; }
        public string version_type { get; set; }
        public string version_name { get; set; }
        public string fuel_base_code { get; set; }
        public string fuel_mode { get; set; }
        public string fuel_name { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual gb_fp_fuel_types gb_fp_fuel_types { get; set; }
        public virtual gb_fp_fuels gb_fp_fuels { get; set; }
        public virtual gb_fp_versions gb_fp_versions { get; set; }
    }
}
