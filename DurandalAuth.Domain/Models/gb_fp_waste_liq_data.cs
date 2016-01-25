using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_waste_liq_data
    {
        public decimal bod5_wastewater { get; set; }
        public decimal bod5_wastewater_entry { get; set; }
        public decimal ch4_bod5 { get; set; }
        public decimal percent_anaerobic { get; set; }
        public string units { get; set; }
        public string units_type { get; set; }
        public string version_type { get; set; }
        public string version_name { get; set; }
        public string treatment_id { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual gb_fp_versions gb_fp_versions { get; set; }
    }
}
