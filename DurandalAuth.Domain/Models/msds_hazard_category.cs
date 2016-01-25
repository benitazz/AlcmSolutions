using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class msds_hazard_category
    {
        public msds_hazard_category()
        {
            this.msds_haz_classification = new List<msds_haz_classification>();
        }

        public string description { get; set; }
        public string hazard_system_id { get; set; }
        public string hazard_class_id { get; set; }
        public string hazard_category_id { get; set; }
        public virtual ICollection<msds_haz_classification> msds_haz_classification { get; set; }
        public virtual msds_hazard_class msds_hazard_class { get; set; }
        public virtual msds_hazard_system msds_hazard_system { get; set; }
    }
}
