using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_s3_waste_liq
    {
        public string bl_id { get; set; }
        public short calc_year { get; set; }
        public decimal ch4_emiss { get; set; }
        public decimal mtce_ch4 { get; set; }
        public decimal qty_treated { get; set; }
        public int qty_treated_entry { get; set; }
        public string scenario_id { get; set; }
        public string treatment_id { get; set; }
        public string units { get; set; }
        public string units_type { get; set; }
        public int source_id { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual gb_fp_setup gb_fp_setup { get; set; }
    }
}
