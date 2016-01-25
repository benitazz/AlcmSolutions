using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class actscn
    {
        public short fiscal_year { get; set; }
        public string proj_scenario_id { get; set; }
        public int activity_log_id { get; set; }
        public virtual activity_log activity_log { get; set; }
    }
}
