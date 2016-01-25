using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class vertstd
    {
        public vertstd()
        {
            this.verts = new List<vert>();
        }

        public decimal area { get; set; }
        public string description { get; set; }
        public string hpattern { get; set; }
        public string hpattern_acad { get; set; }
        public short tot_count { get; set; }
        public string vert_std { get; set; }
        public virtual ICollection<vert> verts { get; set; }
    }
}
