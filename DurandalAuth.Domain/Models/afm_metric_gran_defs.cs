using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_metric_gran_defs
    {
        public afm_metric_gran_defs()
        {
            this.afm_metric_grans = new List<afm_metric_grans>();
            this.afm_metric_trend_values = new List<afm_metric_trend_values>();
        }

        public short fields_present { get; set; }
        public string fields_required { get; set; }
        public string granularity_title { get; set; }
        public string collect_group_by { get; set; }
        public virtual ICollection<afm_metric_grans> afm_metric_grans { get; set; }
        public virtual ICollection<afm_metric_trend_values> afm_metric_trend_values { get; set; }
    }
}
