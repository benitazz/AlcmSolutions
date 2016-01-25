using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_s1_co_airc
    {
        public string aircraft_type { get; set; }
        public string bl_id { get; set; }
        public short calc_year { get; set; }
        public decimal hours { get; set; }
        public decimal kg_co2 { get; set; }
        public string scenario_id { get; set; }
        public int source_id { get; set; }
        public virtual gb_fp_setup gb_fp_setup { get; set; }
    }
}
