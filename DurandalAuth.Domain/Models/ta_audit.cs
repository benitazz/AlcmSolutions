using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ta_audit
    {
        public string bl_id { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string em_id { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public string status { get; set; }
        public string survey_id { get; set; }
        public string ta_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Em em { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Rm rm { get; set; }
        public virtual survey survey { get; set; }
    }
}
