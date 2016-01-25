using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wrcf
    {
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public decimal hours_diff { get; set; }
        public decimal hours_double { get; set; }
        public decimal hours_est { get; set; }
        public decimal hours_over { get; set; }
        public decimal hours_straight { get; set; }
        public decimal hours_total { get; set; }
        public string msg_delivery_status { get; set; }
        public string scheduled_from_tr_id { get; set; }
        public string status_from_remote_cf { get; set; }
        public string comments { get; set; }
        public decimal cost_double { get; set; }
        public decimal cost_estimated { get; set; }
        public decimal cost_over { get; set; }
        public decimal cost_straight { get; set; }
        public decimal cost_total { get; set; }
        public Nullable<System.DateTime> time_end { get; set; }
        public Nullable<System.DateTime> time_start { get; set; }
        public string work_type { get; set; }
        public int wr_id { get; set; }
        public string cf_id { get; set; }
        public System.DateTime date_assigned { get; set; }
        public System.DateTime time_assigned { get; set; }
        public virtual cf cf { get; set; }
        public virtual tr tr { get; set; }
        public virtual wr wr { get; set; }
    }
}
