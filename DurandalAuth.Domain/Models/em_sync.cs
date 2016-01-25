using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class em_sync
    {
        public string bl_id { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string em_id { get; set; }
        public string em_number { get; set; }
        public string em_photo { get; set; }
        public string em_std { get; set; }
        public string email { get; set; }
        public string fl_id { get; set; }
        public Nullable<short> mob_is_changed { get; set; }
        public string mob_locked_by { get; set; }
        public string name_first { get; set; }
        public string name_last { get; set; }
        public string phone { get; set; }
        public string rm_id { get; set; }
        public string survey_id { get; set; }
        public int auto_number { get; set; }
        public virtual bl bl { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual emstd emstd { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Rm rm { get; set; }
    }
}
