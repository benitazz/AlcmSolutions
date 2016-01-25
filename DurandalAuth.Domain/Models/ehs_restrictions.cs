using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_restrictions
    {
        public ehs_restrictions()
        {
            this.docs_assigned = new List<docs_assigned>();
        }

        public Nullable<System.DateTime> date_actual { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public System.DateTime date_start { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string em_id { get; set; }
        public Nullable<int> incident_id { get; set; }
        public decimal lost_work_days { get; set; }
        public Nullable<int> medical_monitoring_id { get; set; }
        public string restriction_category_id { get; set; }
        public string restriction_class { get; set; }
        public string restriction_type_id { get; set; }
        public int restriction_id { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
        public virtual ehs_incidents ehs_incidents { get; set; }
        public virtual ehs_medical_monitoring ehs_medical_monitoring { get; set; }
        public virtual ehs_restriction_cat ehs_restriction_cat { get; set; }
        public virtual Em em { get; set; }
    }
}
