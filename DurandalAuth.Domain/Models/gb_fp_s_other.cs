using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_s_other
    {
        public string bl_id { get; set; }
        public short calc_year { get; set; }
        public decimal mt_co2 { get; set; }
        public string scenario_id { get; set; }
        public string source_name { get; set; }
        public int source_id { get; set; }
        public virtual gb_fp_setup gb_fp_setup { get; set; }
    }
}
