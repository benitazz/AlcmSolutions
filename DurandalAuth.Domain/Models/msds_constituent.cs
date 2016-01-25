using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class msds_constituent
    {
        public Nullable<decimal> pct_high { get; set; }
        public Nullable<decimal> pct_low { get; set; }
        public string pct_operator { get; set; }
        public int msds_id { get; set; }
        public string chemical_id { get; set; }
        public virtual msds_chemical msds_chemical { get; set; }
        public virtual msds_data msds_data { get; set; }
    }
}
