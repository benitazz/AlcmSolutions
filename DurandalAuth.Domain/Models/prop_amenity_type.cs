using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class prop_amenity_type
    {
        public prop_amenity_type()
        {
            this.bl_amenity = new List<bl_amenity>();
            this.prop_amenity = new List<prop_amenity>();
        }

        public string amenity_type { get; set; }
        public virtual ICollection<bl_amenity> bl_amenity { get; set; }
        public virtual ICollection<prop_amenity> prop_amenity { get; set; }
    }
}
