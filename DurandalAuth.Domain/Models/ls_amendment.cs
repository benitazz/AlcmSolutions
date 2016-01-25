using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ls_amendment
    {
        public string comments { get; set; }
        public Nullable<System.DateTime> date_effective { get; set; }
        public Nullable<System.DateTime> date_requested { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string exercised_by { get; set; }
        public string ls_id { get; set; }
        public int ls_amend_id { get; set; }
        public virtual Em em { get; set; }
        public virtual l l { get; set; }
    }
}
