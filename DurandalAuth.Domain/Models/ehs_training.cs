using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_training
    {
        public ehs_training()
        {
            this.docs_assigned = new List<docs_assigned>();
            this.ehs_training_results = new List<ehs_training_results>();
            this.work_categories = new List<work_categories>();
        }

        public string chemical_name { get; set; }
        public string comments { get; set; }
        public Nullable<System.DateTime> date_recurrence_end { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string eq_std { get; set; }
        public decimal hours_training { get; set; }
        public short needs_refresh { get; set; }
        public string ppe_type_id { get; set; }
        public string recurring_rule { get; set; }
        public string reg_program { get; set; }
        public string reg_requirement { get; set; }
        public string regulation { get; set; }
        public string requirements_description { get; set; }
        public string training_category_id { get; set; }
        public string training_name { get; set; }
        public string training_type_id { get; set; }
        public string vn_id { get; set; }
        public string training_id { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
        public virtual ehs_chemicals ehs_chemicals { get; set; }
        public virtual ehs_ppe_types ehs_ppe_types { get; set; }
        public virtual eqstd eqstd { get; set; }
        public virtual regprogram regprogram { get; set; }
        public virtual regrequirement regrequirement { get; set; }
        public virtual regulation regulation1 { get; set; }
        public virtual ICollection<ehs_training_results> ehs_training_results { get; set; }
        public virtual ehs_training_cat ehs_training_cat { get; set; }
        public virtual ehs_training_types ehs_training_types { get; set; }
        public virtual vn vn { get; set; }
        public virtual ICollection<work_categories> work_categories { get; set; }
    }
}
