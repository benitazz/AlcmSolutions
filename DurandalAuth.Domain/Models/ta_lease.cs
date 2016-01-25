using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ta_lease
    {
        public ta_lease()
        {
            this.eqs = new List<eq>();
            this.fnstds = new List<fnstd>();
            this.tas = new List<ta>();
        }

        public Nullable<short> cancel_option { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public string description { get; set; }
        public string lessor_id { get; set; }
        public Nullable<short> renew_option { get; set; }
        public Nullable<short> retain_option { get; set; }
        public string ta_lease_id { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<fnstd> fnstds { get; set; }
        public virtual lessor lessor { get; set; }
        public virtual ICollection<ta> tas { get; set; }
    }
}
