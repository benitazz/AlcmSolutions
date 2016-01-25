using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class msds_hazard_system
    {
        public msds_hazard_system()
        {
            this.msds_haz_classification = new List<msds_haz_classification>();
            this.msds_hazard_category = new List<msds_hazard_category>();
            this.msds_hazard_class = new List<msds_hazard_class>();
        }

        public string description { get; set; }
        public string hazard_system_id { get; set; }
        public virtual ICollection<msds_haz_classification> msds_haz_classification { get; set; }
        public virtual ICollection<msds_hazard_category> msds_hazard_category { get; set; }
        public virtual ICollection<msds_hazard_class> msds_hazard_class { get; set; }
    }
}
