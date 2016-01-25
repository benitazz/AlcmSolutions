using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class it
    {
        public string ac_id { get; set; }
        public decimal cost_total { get; set; }
        public decimal cost_when_used { get; set; }
        public string part_id { get; set; }
        public string performed_by { get; set; }
        public System.DateTime trans_date { get; set; }
        public decimal trans_quantity { get; set; }
        public System.DateTime trans_time { get; set; }
        public string trans_type { get; set; }
        public int trans_id { get; set; }
        public virtual pt pt { get; set; }
    }
}
