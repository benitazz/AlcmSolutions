using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_metric_grans
    {
        public string dflt_view { get; set; }
        public string tables_required { get; set; }
        public string metric_name { get; set; }
        public string collect_group_by { get; set; }
        public virtual afm_metric_definitions afm_metric_definitions { get; set; }
        public virtual afm_metric_gran_defs afm_metric_gran_defs { get; set; }
    }
}
