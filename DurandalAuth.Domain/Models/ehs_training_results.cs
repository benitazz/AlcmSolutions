using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_training_results
    {
        public decimal hours_training { get; set; }
        public Nullable<int> incident_id { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string training_id { get; set; }
        public string em_id { get; set; }
        public System.DateTime date_actual { get; set; }
        public virtual ehs_incidents ehs_incidents { get; set; }
        public virtual ehs_training ehs_training { get; set; }
        public virtual Em em { get; set; }
    }
}
