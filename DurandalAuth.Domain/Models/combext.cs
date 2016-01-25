using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class combext
    {
        public string bl_id { get; set; }
        public string description { get; set; }
        public string em_id { get; set; }
        public string extension { get; set; }
        public string fl_id { get; set; }
        public string fp_id { get; set; }
        public string jk_id { get; set; }
        public string phone { get; set; }
        public string rm_id { get; set; }
        public string source_table { get; set; }
        public string tc_use { get; set; }
        public string telext_id { get; set; }
        public int auto_number { get; set; }
        public virtual bl bl { get; set; }
        public virtual Em em { get; set; }
        public virtual Fl fl { get; set; }
        public virtual fp fp { get; set; }
        public virtual jk jk { get; set; }
        public virtual Rm rm { get; set; }
        public virtual telext telext { get; set; }
    }
}
