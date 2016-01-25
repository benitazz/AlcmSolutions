using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wrtl_sync
    {
        public decimal cost_estimated { get; set; }
        public decimal cost_straight { get; set; }
        public decimal cost_total { get; set; }
        public System.DateTime date_assigned { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public decimal hours_est { get; set; }
        public decimal hours_straight { get; set; }
        public decimal hours_total { get; set; }
        public Nullable<short> mob_is_changed { get; set; }
        public string mob_locked_by { get; set; }
        public Nullable<int> mob_wr_id { get; set; }
        public System.DateTime time_assigned { get; set; }
        public Nullable<System.DateTime> time_end { get; set; }
        public Nullable<System.DateTime> time_start { get; set; }
        public string tool_id { get; set; }
        public int wr_id { get; set; }
        public int auto_number { get; set; }
    }
}
