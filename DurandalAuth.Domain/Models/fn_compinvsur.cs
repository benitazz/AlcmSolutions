using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class fn_compinvsur
    {
        public string bl_id { get; set; }
        public int count_audit { get; set; }
        public int count_inv { get; set; }
        public string fl_id { get; set; }
        public string fn_std { get; set; }
        public string rm_id { get; set; }
        public string survey_id { get; set; }
        public int auto_number { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual fnstd fnstd { get; set; }
        public virtual Rm rm { get; set; }
        public virtual survey survey { get; set; }
    }
}
