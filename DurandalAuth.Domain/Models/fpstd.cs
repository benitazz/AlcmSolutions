using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class fpstd
    {
        public fpstd()
        {
            this.fps = new List<fp>();
            this.jkcfgs = new List<jkcfg>();
        }

        public string fp_type { get; set; }
        public string image_file { get; set; }
        public string symbol { get; set; }
        public string tc_contained_tbls { get; set; }
        public string tc_level { get; set; }
        public short tc_npositions { get; set; }
        public string description { get; set; }
        public string doc_image { get; set; }
        public string fp_std { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual ICollection<fp> fps { get; set; }
        public virtual ICollection<jkcfg> jkcfgs { get; set; }
    }
}
