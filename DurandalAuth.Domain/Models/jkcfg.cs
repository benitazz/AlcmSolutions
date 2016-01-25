using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class jkcfg
    {
        public string description { get; set; }
        public string fp_std { get; set; }
        public string jk_std { get; set; }
        public short num_ports { get; set; }
        public string prefix { get; set; }
        public short start_number { get; set; }
        public string tc_level { get; set; }
        public int auto_number { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual fpstd fpstd { get; set; }
        public virtual jkstd jkstd { get; set; }
    }
}
