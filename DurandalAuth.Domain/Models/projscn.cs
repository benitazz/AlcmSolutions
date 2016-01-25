using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class projscn
    {
        public decimal costs_est_cap { get; set; }
        public decimal costs_est_exp { get; set; }
        public string proj_scenario_id { get; set; }
        public string project_id { get; set; }
        public short fiscal_year { get; set; }
        public string fund_id { get; set; }
        public virtual funding funding { get; set; }
        public virtual project project { get; set; }
        public virtual scenario scenario { get; set; }
    }
}
