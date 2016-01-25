using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pa_dep
    {
        public Nullable<decimal> value_accum_dep { get; set; }
        public Nullable<decimal> value_current { get; set; }
        public Nullable<decimal> value_current_dep { get; set; }
        public string report_id { get; set; }
        public string pr_id { get; set; }
        public string pa_name { get; set; }
        public virtual dep_reports dep_reports { get; set; }
        public virtual pa pa { get; set; }
        public virtual Property property { get; set; }
    }
}
