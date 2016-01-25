using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pmp1
    {
        public pmp1()
        {
            this.pmpspts = new List<pmpspt>();
            this.pmpstrs = new List<pmpstr>();
            this.pmpstts = new List<pmpstt>();
        }

        public string doc { get; set; }
        public string instructions { get; set; }
        public string pmp_id { get; set; }
        public short pmps_id { get; set; }
        public virtual pmp pmp { get; set; }
        public virtual ICollection<pmpspt> pmpspts { get; set; }
        public virtual ICollection<pmpstr> pmpstrs { get; set; }
        public virtual ICollection<pmpstt> pmpstts { get; set; }
    }
}
