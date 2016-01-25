using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pmgp
    {
        public pmgp()
        {
            this.pmgens = new List<pmgen>();
            this.pms = new List<Pm>();
        }

        public string description { get; set; }
        public string pm_group { get; set; }
        public virtual ICollection<pmgen> pmgens { get; set; }
        public virtual ICollection<Pm> pms { get; set; }
    }
}
