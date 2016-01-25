using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_s1_s3_mobile
    {
        public string bl_id { get; set; }
        public short calc_year { get; set; }
        public decimal distance { get; set; }
        public int distance_entry { get; set; }
        public decimal kg_co2 { get; set; }
        public string scenario_id { get; set; }
        public string scope_cat { get; set; }
        public string units { get; set; }
        public string units_type { get; set; }
        public string vehicle_type { get; set; }
        public int source_id { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual gb_fp_setup gb_fp_setup { get; set; }
    }
}
