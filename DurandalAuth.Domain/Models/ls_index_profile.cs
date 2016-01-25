using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ls_index_profile
    {
        public string comments { get; set; }
        public string cost_index_id { get; set; }
        public Nullable<System.DateTime> date_index_end { get; set; }
        public Nullable<System.DateTime> date_index_next { get; set; }
        public System.DateTime date_index_start { get; set; }
        public decimal index_value_initial { get; set; }
        public string indexing_frequency { get; set; }
        public Nullable<decimal> limit_max { get; set; }
        public Nullable<decimal> limit_min { get; set; }
        public string ls_page { get; set; }
        public string ls_section { get; set; }
        public Nullable<decimal> max_rent { get; set; }
        public Nullable<decimal> min_rent { get; set; }
        public decimal pct_change_adjust { get; set; }
        public decimal rent_initial { get; set; }
        public short rent_round_to { get; set; }
        public short reset_initial_values { get; set; }
        public string ls_id { get; set; }
        public virtual cost_index cost_index { get; set; }
        public virtual l l { get; set; }
    }
}
