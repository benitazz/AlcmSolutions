using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class eq_audit
    {
        public string eq_std { get; set; }
        public string fl_id { get; set; }
        public Nullable<short> marked_for_deletion { get; set; }
        public Nullable<short> mob_is_changed { get; set; }
        public string mob_locked_by { get; set; }
        public string rm_id { get; set; }
        public string site_id { get; set; }
        public string status { get; set; }
        public string survey_comments { get; set; }
        public string bl_id { get; set; }
        public Nullable<System.DateTime> date_last_surveyed { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string em_id { get; set; }
        public string survey_photo_eq { get; set; }
        public string survey_redline_eq { get; set; }
        public string transfer_status { get; set; }
        public string survey_id { get; set; }
        public string eq_id { get; set; }
        public virtual survey survey { get; set; }
    }
}
