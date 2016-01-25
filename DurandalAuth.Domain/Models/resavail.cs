using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class resavail
    {
        public string cf_id { get; set; }
        public Nullable<System.DateTime> date_assigned { get; set; }
        public decimal hours_avail_total { get; set; }
        public decimal hours_commited_total { get; set; }
        public decimal hours_remaining { get; set; }
        public decimal od_hours_commited { get; set; }
        public decimal pm_hours_commited { get; set; }
        public string tool_id { get; set; }
        public string tool_type { get; set; }
        public string tr_id { get; set; }
        public int auto_number { get; set; }
    }
}
