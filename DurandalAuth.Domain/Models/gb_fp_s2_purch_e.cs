using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_s2_purch_e
    {
        public string bl_id { get; set; }
        public short calc_year { get; set; }
        public decimal consumption { get; set; }
        public decimal consumption_entry { get; set; }
        public decimal kg_co2 { get; set; }
        public string scenario_id { get; set; }
        public string units { get; set; }
        public string units_type { get; set; }
        public int source_id { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual gb_fp_setup gb_fp_setup { get; set; }
    }
}
