using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class work_categories
    {
        public work_categories()
        {
            this.work_categories_em = new List<work_categories_em>();
            this.ehs_medical_monitoring = new List<ehs_medical_monitoring>();
            this.ehs_ppe_types = new List<ehs_ppe_types>();
            this.ehs_training = new List<ehs_training>();
        }

        public string description { get; set; }
        public string hierarchy_ids { get; set; }
        public string work_category_id { get; set; }
        public virtual ICollection<work_categories_em> work_categories_em { get; set; }
        public virtual ICollection<ehs_medical_monitoring> ehs_medical_monitoring { get; set; }
        public virtual ICollection<ehs_ppe_types> ehs_ppe_types { get; set; }
        public virtual ICollection<ehs_training> ehs_training { get; set; }
    }
}
