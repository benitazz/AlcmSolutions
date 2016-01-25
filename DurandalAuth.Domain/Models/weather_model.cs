using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class weather_model
    {
        public decimal coefficient_base_load { get; set; }
        public decimal coefficient_cdd { get; set; }
        public decimal coefficient_hdd { get; set; }
        public decimal cooling { get; set; }
        public decimal heating { get; set; }
        public decimal oat_c1 { get; set; }
        public decimal oat_c2 { get; set; }
        public decimal oat_h1 { get; set; }
        public decimal oat_h2 { get; set; }
        public string bl_id { get; set; }
        public string time_period { get; set; }
        public string model_type { get; set; }
        public string aggregation_type { get; set; }
        public virtual bl bl { get; set; }
        public virtual energy_time_period energy_time_period { get; set; }
    }
}
