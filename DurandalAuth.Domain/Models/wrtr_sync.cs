using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wrtr_sync
    {
        public decimal cost_estimated { get; set; }
        public System.DateTime date_assigned { get; set; }
        public decimal hours_est { get; set; }
        public Nullable<short> mob_is_changed { get; set; }
        public string mob_locked_by { get; set; }
        public Nullable<int> mob_wr_id { get; set; }
        public System.DateTime time_assigned { get; set; }
        public string tr_id { get; set; }
        public int wr_id { get; set; }
        public int auto_number { get; set; }
    }
}
