using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class workflow_substitutes
    {
        public string cf_id { get; set; }
        public string comments { get; set; }
        public string em_id { get; set; }
        public Nullable<System.DateTime> end_date_unavailable { get; set; }
        public Nullable<System.DateTime> start_date_unavailable { get; set; }
        public string steptype_or_role { get; set; }
        public string substitute_cf_id { get; set; }
        public string substitute_em_id { get; set; }
        public int autonumber { get; set; }
        public virtual cf cf { get; set; }
        public virtual cf cf1 { get; set; }
        public virtual Em em { get; set; }
        public virtual Em em1 { get; set; }
    }
}
