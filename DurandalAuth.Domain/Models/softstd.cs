using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class softstd
    {
        public softstd()
        {
            this.softinvs = new List<softinv>();
        }

        public string description { get; set; }
        public string mfr { get; set; }
        public string version { get; set; }
        public string soft_std { get; set; }
        public virtual ICollection<softinv> softinvs { get; set; }
    }
}
