using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wr_other
    {
        public decimal cost_estimated { get; set; }
        public decimal cost_total { get; set; }
        public string description { get; set; }
        public decimal qty_used { get; set; }
        public string units_used { get; set; }
        public int wr_id { get; set; }
        public System.DateTime date_used { get; set; }
        public string other_rs_type { get; set; }
        public virtual other_rs other_rs { get; set; }
        public virtual wr wr { get; set; }
    }
}
