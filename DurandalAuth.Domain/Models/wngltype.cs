using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wngltype
    {
        public wngltype()
        {
            this.wns = new List<wn>();
            this.wnstds = new List<wnstd>();
        }

        public string description { get; set; }
        public string gl_type { get; set; }
        public virtual ICollection<wn> wns { get; set; }
        public virtual ICollection<wnstd> wnstds { get; set; }
    }
}
