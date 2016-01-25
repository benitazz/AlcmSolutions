using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_ppe_types
    {
        public ehs_ppe_types()
        {
            this.docs_assigned = new List<docs_assigned>();
            this.ehs_em_ppe_types = new List<ehs_em_ppe_types>();
            this.ehs_training = new List<ehs_training>();
            this.work_categories = new List<work_categories>();
        }

        public Nullable<System.DateTime> date_recurrence_end { get; set; }
        public string description { get; set; }
        public string eq_std { get; set; }
        public short needs_renewal { get; set; }
        public string recurring_rule { get; set; }
        public string ppe_type_id { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
        public virtual ICollection<ehs_em_ppe_types> ehs_em_ppe_types { get; set; }
        public virtual eqstd eqstd { get; set; }
        public virtual ICollection<ehs_training> ehs_training { get; set; }
        public virtual ICollection<work_categories> work_categories { get; set; }
    }
}
