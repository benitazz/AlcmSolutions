using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cost_index_trans
    {
        public int cost_tran_recur_id { get; set; }
        public System.DateTime date_index { get; set; }
        public Nullable<System.DateTime> date_index_last { get; set; }
        public Nullable<System.DateTime> date_index_next { get; set; }
        public System.DateTime date_index_value_new { get; set; }
        public decimal index_pct_change { get; set; }
        public decimal index_value_initial { get; set; }
        public decimal index_value_new { get; set; }
        public string indexing_frequency { get; set; }
        public string ls_id { get; set; }
        public decimal pct_change_adjust { get; set; }
        public Nullable<decimal> rent_indexed { get; set; }
        public decimal rent_initial { get; set; }
        public decimal rent_new { get; set; }
        public decimal rent_pct_change_act { get; set; }
        public decimal rent_pct_change_calc { get; set; }
        public short rent_round_to { get; set; }
        public short reset_initial_values { get; set; }
        public string cost_index_id { get; set; }
        public int cost_index_trans_id { get; set; }
        public virtual cost_index cost_index { get; set; }
        public virtual cost_tran_recur cost_tran_recur { get; set; }
        public virtual l l { get; set; }
    }
}
