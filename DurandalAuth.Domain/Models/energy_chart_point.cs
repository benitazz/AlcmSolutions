using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class energy_chart_point
    {
        public short outlier { get; set; }
        public decimal value { get; set; }
        public string bl_id { get; set; }
        public string time_period { get; set; }
        public string value_name { get; set; }
        public virtual bl bl { get; set; }
        public virtual energy_time_period energy_time_period { get; set; }
    }
}
