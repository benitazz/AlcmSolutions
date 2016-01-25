using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class regviolationtyp
    {
        public regviolationtyp()
        {
            this.regviolations = new List<regviolation>();
        }

        public string description { get; set; }
        public string summary { get; set; }
        public string violation_type { get; set; }
        public virtual ICollection<regviolation> regviolations { get; set; }
    }
}
