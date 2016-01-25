using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class prop_amenity
    {
        public string comments { get; set; }
        public string pr_id { get; set; }
        public string amenity_type { get; set; }
        public virtual prop_amenity_type prop_amenity_type { get; set; }
        public virtual Property property { get; set; }
    }
}
