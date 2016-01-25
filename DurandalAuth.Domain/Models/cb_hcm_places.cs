using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cb_hcm_places
    {
        public int activity_log_id { get; set; }
        public string bl_id { get; set; }
        public string comments { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public int hcm_places_id { get; set; }
        public virtual activity_log activity_log { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Rm rm { get; set; }
    }
}
