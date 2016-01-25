using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_medical_monitoring
    {
        public ehs_medical_monitoring()
        {
            this.docs_assigned = new List<docs_assigned>();
            this.ehs_medical_mon_results = new List<ehs_medical_mon_results>();
            this.ehs_restrictions = new List<ehs_restrictions>();
            this.work_categories = new List<work_categories>();
        }

        public Nullable<System.DateTime> date_recurrence_end { get; set; }
        public string description { get; set; }
        public short is_recurring { get; set; }
        public string monitoring_type { get; set; }
        public string recurring_rule { get; set; }
        public string reg_program { get; set; }
        public string reg_requirement { get; set; }
        public string regulation { get; set; }
        public int medical_monitoring_id { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
        public virtual ICollection<ehs_medical_mon_results> ehs_medical_mon_results { get; set; }
        public virtual regprogram regprogram { get; set; }
        public virtual regrequirement regrequirement { get; set; }
        public virtual regulation regulation1 { get; set; }
        public virtual ICollection<ehs_restrictions> ehs_restrictions { get; set; }
        public virtual ICollection<work_categories> work_categories { get; set; }
    }
}
