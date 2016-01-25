using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cb_sample_result
    {
        public string cb_units_id { get; set; }
        public string qualifier { get; set; }
        public decimal result_1 { get; set; }
        public Nullable<decimal> result_2 { get; set; }
        public string sample_comp_id { get; set; }
        public int sample_id { get; set; }
        public int result_id { get; set; }
        public virtual cb_sample_comp cb_sample_comp { get; set; }
        public virtual cb_units cb_units { get; set; }
        public virtual cb_samples cb_samples { get; set; }
    }
}
