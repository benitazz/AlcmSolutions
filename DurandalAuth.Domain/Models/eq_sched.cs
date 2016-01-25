using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class eq_sched
    {
        public string comments { get; set; }
        public decimal hours_commited { get; set; }
        public Nullable<System.DateTime> time_start { get; set; }
        public string eq_id { get; set; }
        public System.DateTime date_scheduled { get; set; }
        public string schedule_type { get; set; }
        public virtual eq eq { get; set; }
    }
}
