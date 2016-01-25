using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_s3_mat
    {
        public decimal amount_purchased { get; set; }
        public int amount_purchased_entry { get; set; }
        public string bl_id { get; set; }
        public short calc_year { get; set; }
        public decimal kg_co2 { get; set; }
        public decimal recycled_content { get; set; }
        public string scenario_id { get; set; }
        public string units { get; set; }
        public string units_type { get; set; }
        public string waste_name { get; set; }
        public int source_id { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual gb_fp_setup gb_fp_setup { get; set; }
    }
}
