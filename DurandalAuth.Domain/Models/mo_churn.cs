using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class mo_churn
    {
        public string bl_id { get; set; }
        public int count_em { get; set; }
        public int count_eq { get; set; }
        public int count_ta { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string fl_id { get; set; }
        public Nullable<short> month { get; set; }
        public int num_em_moves { get; set; }
        public int num_eq_moves { get; set; }
        public int num_ta_moves { get; set; }
        public decimal rate_em_moves { get; set; }
        public decimal rate_eq_moves { get; set; }
        public decimal rate_ta_moves { get; set; }
        public Nullable<short> year { get; set; }
        public int auto_number { get; set; }
        public virtual bl bl { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Fl fl { get; set; }
    }
}
