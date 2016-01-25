using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class tt
    {
        public tt()
        {
            this.pmpstts = new List<pmpstt>();
            this.tls = new List<tl>();
            this.wrtts = new List<wrtt>();
        }

        public string description { get; set; }
        public Nullable<short> out_of_svc_qty { get; set; }
        public decimal rate_hourly { get; set; }
        public decimal rate_over { get; set; }
        public Nullable<short> reserved_qty { get; set; }
        public decimal std_hours_avail { get; set; }
        public Nullable<short> total_quantity { get; set; }
        public string tool_type { get; set; }
        public virtual ICollection<pmpstt> pmpstts { get; set; }
        public virtual ICollection<tl> tls { get; set; }
        public virtual ICollection<wrtt> wrtts { get; set; }
    }
}
