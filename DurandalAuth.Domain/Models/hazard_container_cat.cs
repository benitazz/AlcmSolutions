using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class hazard_container_cat
    {
        public hazard_container_cat()
        {
            this.hazard_container_type = new List<hazard_container_type>();
            this.msds_location = new List<msds_location>();
            this.waste_out = new List<waste_out>();
        }

        public string activity_id { get; set; }
        public string description { get; set; }
        public string container_cat { get; set; }
        public virtual afm_activities afm_activities { get; set; }
        public virtual ICollection<hazard_container_type> hazard_container_type { get; set; }
        public virtual ICollection<msds_location> msds_location { get; set; }
        public virtual ICollection<waste_out> waste_out { get; set; }
    }
}
