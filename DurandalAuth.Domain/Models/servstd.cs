using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class servstd
    {
        public servstd()
        {
            this.servs = new List<serv>();
        }

        public decimal area { get; set; }
        public string description { get; set; }
        public string hpattern { get; set; }
        public string hpattern_acad { get; set; }
        public short tot_count { get; set; }
        public string serv_std { get; set; }
        public virtual ICollection<serv> servs { get; set; }
    }
}
