using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class hazard_container_type
    {
        public hazard_container_type()
        {
            this.msds_location = new List<msds_location>();
        }

        public decimal container_size { get; set; }
        public string description { get; set; }
        public string units { get; set; }
        public string units_type { get; set; }
        public string container_cat { get; set; }
        public string container_type { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual hazard_container_cat hazard_container_cat { get; set; }
        public virtual ICollection<msds_location> msds_location { get; set; }
    }
}
