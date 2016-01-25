using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rmpctmob_sync
    {
        public string bl_id { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public short day_part { get; set; }
        public string del_user_name { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string em_id { get; set; }
        public string fl_id { get; set; }
        public Nullable<short> mob_is_changed { get; set; }
        public string mob_locked_by { get; set; }
        public string pct_id { get; set; }
        public Nullable<decimal> pct_space { get; set; }
        public Nullable<short> primary_em { get; set; }
        public Nullable<short> primary_rm { get; set; }
        public string rm_cat { get; set; }
        public string rm_id { get; set; }
        public string rm_type { get; set; }
        public short status { get; set; }
        public string survey_id { get; set; }
        public string user_name { get; set; }
        public Nullable<int> visitor_id { get; set; }
        public string action { get; set; }
        public Nullable<int> activity_log_id { get; set; }
        public int auto_number { get; set; }
        public virtual activity_log activity_log { get; set; }
        public virtual bl bl { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Rm rm { get; set; }
        public virtual rmcat rmcat { get; set; }
        public virtual rmtype rmtype { get; set; }
    }
}
