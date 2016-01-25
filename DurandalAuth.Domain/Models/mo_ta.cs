using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class mo_ta
    {
        public decimal cost_moving { get; set; }
        public string em_id { get; set; }
        public string fn_std { get; set; }
        public string from_bl_id { get; set; }
        public string from_fl_id { get; set; }
        public string from_rm_id { get; set; }
        public string status { get; set; }
        public int mo_id { get; set; }
        public string ta_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Em em { get; set; }
        public virtual Fl fl { get; set; }
        public virtual fnstd fnstd { get; set; }
        public virtual mo mo { get; set; }
        public virtual Rm rm { get; set; }
        public virtual ta ta { get; set; }
    }
}
