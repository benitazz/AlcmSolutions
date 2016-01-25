using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cp
    {
        public string description { get; set; }
        public string tc_level { get; set; }
        public string tc_use_status { get; set; }
        public string ca_id { get; set; }
        public string cp_id { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual ca ca { get; set; }
    }
}
