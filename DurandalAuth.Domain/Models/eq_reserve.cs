using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class eq_reserve
    {
        public string bl_id { get; set; }
        public string comments { get; set; }
        public string contact { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public System.DateTime date_start { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string eq_id { get; set; }
        public string eventType { get; set; }
        public string fl_id { get; set; }
        public short group_size { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string rm_id { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> time_end { get; set; }
        public Nullable<System.DateTime> time_start { get; set; }
        public int auto_number { get; set; }
        public virtual bl bl { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Em em { get; set; }
        public virtual eq eq { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Rm rm { get; set; }
    }
}
