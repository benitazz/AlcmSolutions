using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wr_other_sync
    {
        public decimal cost_estimated { get; set; }
        public decimal cost_total { get; set; }
        public System.DateTime date_used { get; set; }
        public string description { get; set; }
        public Nullable<short> mob_is_changed { get; set; }
        public string mob_locked_by { get; set; }
        public Nullable<int> mob_wr_id { get; set; }
        public string other_rs_type { get; set; }
        public decimal qty_used { get; set; }
        public string units_used { get; set; }
        public Nullable<int> wr_id { get; set; }
        public int auto_number { get; set; }
    }
}
