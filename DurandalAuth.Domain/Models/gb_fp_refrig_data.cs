using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_refrig_data
    {
        public decimal charge { get; set; }
        public decimal charge_entry { get; set; }
        public string eq_std { get; set; }
        public decimal operation_emiss { get; set; }
        public string units { get; set; }
        public string units_type { get; set; }
        public string version_type { get; set; }
        public string version_name { get; set; }
        public string refrig_ac_type { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual eqstd eqstd { get; set; }
        public virtual gb_fp_versions gb_fp_versions { get; set; }
    }
}
