using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class mo_eq
    {
        public string eq_new_jk_id { get; set; }
        public string eq_std { get; set; }
        public string eq_trace { get; set; }
        public string from_bl_id { get; set; }
        public string from_fl_id { get; set; }
        public string from_rm_id { get; set; }
        public decimal cost_moving { get; set; }
        public string em_id { get; set; }
        public string status { get; set; }
        public int mo_id { get; set; }
        public string eq_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Em em { get; set; }
        public virtual eq eq { get; set; }
        public virtual eqstd eqstd { get; set; }
        public virtual Fl fl { get; set; }
        public virtual jk jk { get; set; }
        public virtual mo mo { get; set; }
        public virtual Rm rm { get; set; }
    }
}
