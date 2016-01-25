using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class msds_h_constituent
    {
        public Nullable<decimal> pct_high { get; set; }
        public Nullable<decimal> pct_low { get; set; }
        public string pct_operator { get; set; }
        public int msds_id { get; set; }
        public string chemical_id { get; set; }
        public System.DateTime date_archived { get; set; }
        public System.DateTime time_archived { get; set; }
    }
}
