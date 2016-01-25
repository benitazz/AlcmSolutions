using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gpstd
    {
        public gpstd()
        {
            this.gps = new List<gp>();
        }

        public decimal area { get; set; }
        public string description { get; set; }
        public string hpattern { get; set; }
        public string hpattern_acad { get; set; }
        public short tot_count { get; set; }
        public string gp_std { get; set; }
        public virtual ICollection<gp> gps { get; set; }
    }
}
