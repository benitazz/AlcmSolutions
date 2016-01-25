using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_metric_scard_defs
    {
        public afm_metric_scard_defs()
        {
            this.afm_metric_scards = new List<afm_metric_scards>();
        }

        public string scorecard_title { get; set; }
        public string scorecard_code { get; set; }
        public virtual ICollection<afm_metric_scards> afm_metric_scards { get; set; }
    }
}
