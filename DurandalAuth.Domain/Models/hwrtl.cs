using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class hwrtl
    {
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public decimal hours_diff { get; set; }
        public decimal hours_est { get; set; }
        public decimal hours_over { get; set; }
        public decimal hours_straight { get; set; }
        public decimal hours_total { get; set; }
        public string comments { get; set; }
        public decimal cost_estimated { get; set; }
        public decimal cost_over { get; set; }
        public decimal cost_straight { get; set; }
        public decimal cost_total { get; set; }
        public Nullable<System.DateTime> time_end { get; set; }
        public Nullable<System.DateTime> time_start { get; set; }
        public int wr_id { get; set; }
        public string tool_id { get; set; }
        public System.DateTime date_assigned { get; set; }
        public System.DateTime time_assigned { get; set; }
        public virtual hwr hwr { get; set; }
    }
}
