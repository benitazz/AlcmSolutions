using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_gwp_data
    {
        public string gas_ref_type { get; set; }
        public decimal gwp { get; set; }
        public string version_type { get; set; }
        public string version_name { get; set; }
        public string gas_ref_name { get; set; }
        public virtual gb_fp_versions gb_fp_versions { get; set; }
    }
}
