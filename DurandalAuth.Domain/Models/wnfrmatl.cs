using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wnfrmatl
    {
        public wnfrmatl()
        {
            this.wns = new List<wn>();
            this.wnstds = new List<wnstd>();
        }

        public string description { get; set; }
        public string fr_matl { get; set; }
        public virtual ICollection<wn> wns { get; set; }
        public virtual ICollection<wnstd> wnstds { get; set; }
    }
}
