using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rm_amenity_type
    {
        public rm_amenity_type()
        {
            this.rm_amenity = new List<rm_amenity>();
        }

        public string amenity_type { get; set; }
        public virtual ICollection<rm_amenity> rm_amenity { get; set; }
    }
}
