using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class dep_reports
    {
        public dep_reports()
        {
            this.eq_dep = new List<eq_dep>();
            this.pa_dep = new List<pa_dep>();
            this.ta_dep = new List<ta_dep>();
        }

        public string active { get; set; }
        public System.DateTime last_date { get; set; }
        public string report_id { get; set; }
        public virtual ICollection<eq_dep> eq_dep { get; set; }
        public virtual ICollection<pa_dep> pa_dep { get; set; }
        public virtual ICollection<ta_dep> ta_dep { get; set; }
    }
}
