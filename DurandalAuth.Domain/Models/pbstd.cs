using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pbstd
    {
        public pbstd()
        {
            this.pbs = new List<pb>();
        }

        public string description { get; set; }
        public string doc_image { get; set; }
        public string image_file { get; set; }
        public string symbol { get; set; }
        public string tc_contained_tbls { get; set; }
        public string tc_level { get; set; }
        public short tc_npositions { get; set; }
        public string vn_id { get; set; }
        public string pb_std { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual ICollection<pb> pbs { get; set; }
        public virtual vn vn { get; set; }
    }
}
