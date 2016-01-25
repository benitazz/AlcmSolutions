using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_medical_mon_results
    {
        public string comments { get; set; }
        public Nullable<int> incident_id { get; set; }
        public string monitoring_type { get; set; }
        public string resulting_actions { get; set; }
        public string status { get; set; }
        public string tracking_number { get; set; }
        public int medical_monitoring_id { get; set; }
        public string em_id { get; set; }
        public System.DateTime date_actual { get; set; }
        public virtual ehs_incidents ehs_incidents { get; set; }
        public virtual Em em { get; set; }
        public virtual ehs_medical_monitoring ehs_medical_monitoring { get; set; }
    }
}
