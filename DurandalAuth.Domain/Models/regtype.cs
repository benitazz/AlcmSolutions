using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class regtype
    {
        public regtype()
        {
            this.regulations = new List<regulation>();
        }

        public string description { get; set; }
        public string summary { get; set; }
        public string reg_cat { get; set; }
        public string reg_type { get; set; }
        public virtual regcat regcat { get; set; }
        public virtual ICollection<regulation> regulations { get; set; }
    }
}
