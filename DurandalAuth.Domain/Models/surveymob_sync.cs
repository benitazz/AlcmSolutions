using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class surveymob_sync
    {
        public string description { get; set; }
        public string em_id { get; set; }
        public Nullable<short> mob_is_changed { get; set; }
        public string mob_locked_by { get; set; }
        public string status { get; set; }
        public System.DateTime survey_date { get; set; }
        public string survey_id { get; set; }
        public string survey_type { get; set; }
        public string transfer_status { get; set; }
        public int auto_number { get; set; }
        public virtual Em em { get; set; }
    }
}
