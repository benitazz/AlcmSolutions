using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class surveyrm_sync
    {
        public string bl_id { get; set; }
        public short cap_em { get; set; }
        public Nullable<System.DateTime> date_last_surveyed { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string fl_id { get; set; }
        public short mob_is_changed { get; set; }
        public string mob_locked_by { get; set; }
        public string name { get; set; }
        public string prorate { get; set; }
        public string rm_cat { get; set; }
        public string rm_id { get; set; }
        public string rm_std { get; set; }
        public string rm_type { get; set; }
        public string rm_use { get; set; }
        public string status { get; set; }
        public string survey_comments_rm { get; set; }
        public string survey_id { get; set; }
        public string survey_photo { get; set; }
        public string survey_redline_rm { get; set; }
        public string transfer_status { get; set; }
        public int auto_number { get; set; }
        public virtual bl bl { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Fl fl { get; set; }
        public virtual rmcat rmcat { get; set; }
        public virtual rmstd rmstd { get; set; }
        public virtual rmtype rmtype { get; set; }
    }
}
