using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class jkstd
    {
        public jkstd()
        {
            this.jks = new List<jk>();
            this.jkcfgs = new List<jkcfg>();
        }

        public string ca_std { get; set; }
        public string connector_type { get; set; }
        public string description { get; set; }
        public string image_file { get; set; }
        public string symbol { get; set; }
        public string tc_level { get; set; }
        public string tc_service { get; set; }
        public string jk_std { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual castd castd { get; set; }
        public virtual ICollection<jk> jks { get; set; }
        public virtual ICollection<jkcfg> jkcfgs { get; set; }
    }
}
