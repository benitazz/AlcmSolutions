using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class regprogtype
    {
        public regprogtype()
        {
            this.regprograms = new List<regprogram>();
        }

        public string description { get; set; }
        public string summary { get; set; }
        public string regprog_cat { get; set; }
        public string regprog_type { get; set; }
        public virtual regprogcat regprogcat { get; set; }
        public virtual ICollection<regprogram> regprograms { get; set; }
    }
}
