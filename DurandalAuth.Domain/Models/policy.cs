using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class policy
    {
        public policy()
        {
            this.eqs = new List<eq>();
            this.fnstds = new List<fnstd>();
            this.tas = new List<ta>();
        }

        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public string description { get; set; }
        public string insurer_id { get; set; }
        public decimal value { get; set; }
        public string policy_id { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<fnstd> fnstds { get; set; }
        public virtual insurer insurer { get; set; }
        public virtual ICollection<ta> tas { get; set; }
    }
}
