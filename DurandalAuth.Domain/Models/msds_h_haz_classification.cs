using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class msds_h_haz_classification
    {
        public int msds_id { get; set; }
        public string hazard_system_id { get; set; }
        public string hazard_class_id { get; set; }
        public string hazard_category_id { get; set; }
        public System.DateTime date_archived { get; set; }
        public System.DateTime time_archived { get; set; }
    }
}
