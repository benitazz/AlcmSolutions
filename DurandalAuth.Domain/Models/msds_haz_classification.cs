using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class msds_haz_classification
    {
        public int msds_id { get; set; }
        public string hazard_system_id { get; set; }
        public string hazard_class_id { get; set; }
        public string hazard_category_id { get; set; }
        public virtual msds_data msds_data { get; set; }
        public virtual msds_hazard_category msds_hazard_category { get; set; }
        public virtual msds_hazard_class msds_hazard_class { get; set; }
        public virtual msds_hazard_system msds_hazard_system { get; set; }
    }
}
