using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_metric_scards
    {
        public short is_displayed { get; set; }
        public string value_disp_decimals_ovr { get; set; }
        public string metric_name { get; set; }
        public string scorecard_code { get; set; }
        public virtual afm_metric_definitions afm_metric_definitions { get; set; }
        public virtual afm_metric_scard_defs afm_metric_scard_defs { get; set; }
    }
}
