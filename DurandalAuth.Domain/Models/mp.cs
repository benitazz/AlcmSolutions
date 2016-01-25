using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class mp
    {
        public mp()
        {
            this.moes = new List<mo>();
        }

        public decimal cost_comp_eq { get; set; }
        public decimal cost_comp_fn { get; set; }
        public decimal cost_comp_other { get; set; }
        public decimal cost_comp_ta { get; set; }
        public decimal cost_comp_total { get; set; }
        public decimal cost_moving_eq { get; set; }
        public decimal cost_moving_fn { get; set; }
        public decimal cost_moving_other { get; set; }
        public decimal cost_moving_ta { get; set; }
        public decimal cost_moving_total { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public string description { get; set; }
        public string em_id { get; set; }
        public string mp_id { get; set; }
        public virtual Em em { get; set; }
        public virtual ICollection<mo> moes { get; set; }
    }
}
