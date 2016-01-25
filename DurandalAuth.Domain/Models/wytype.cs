using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wytype
    {
        public wytype()
        {
            this.wies = new List<wy>();
        }

        public string wy_type { get; set; }
        public virtual ICollection<wy> wies { get; set; }
    }
}
