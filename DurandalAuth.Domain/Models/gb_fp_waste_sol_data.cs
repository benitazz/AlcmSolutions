using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_waste_sol_data
    {
        public decimal carbon_sequestration { get; set; }
        public decimal carbon_sequestration_entry { get; set; }
        public decimal combustion { get; set; }
        public decimal combustion_entry { get; set; }
        public decimal composite_disposal { get; set; }
        public decimal composite_disposal_entry { get; set; }
        public decimal composite_downstream { get; set; }
        public decimal composite_downstream_entry { get; set; }
        public string composition { get; set; }
        public decimal landfilling { get; set; }
        public decimal landfilling_entry { get; set; }
        public decimal manufacture_mix { get; set; }
        public decimal manufacture_mix_entry { get; set; }
        public decimal manufacture_recycled { get; set; }
        public decimal manufacture_recycled_entry { get; set; }
        public decimal raw_acquisition { get; set; }
        public decimal raw_acquisition_entry { get; set; }
        public decimal recycling { get; set; }
        public decimal recycling_entry { get; set; }
        public string units { get; set; }
        public string units_type { get; set; }
        public string version_type { get; set; }
        public string version_name { get; set; }
        public string waste_name { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual gb_fp_versions gb_fp_versions { get; set; }
    }
}
