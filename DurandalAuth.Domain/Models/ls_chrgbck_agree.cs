using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ls_chrgbck_agree
    {
        public Nullable<decimal> amount_cap_lower { get; set; }
        public Nullable<decimal> amount_fixed { get; set; }
        public string charge_type { get; set; }
        public string comments { get; set; }
        public Nullable<decimal> pct_factor { get; set; }
        public string ls_id { get; set; }
        public string cost_cat_id { get; set; }
        public virtual cost_cat cost_cat { get; set; }
        public virtual l l { get; set; }
    }
}
