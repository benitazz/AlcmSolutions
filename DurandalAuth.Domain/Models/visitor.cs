using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class visitor
    {
        public string authorized_by { get; set; }
        public string bl_id { get; set; }
        public string car_make { get; set; }
        public string car_registration { get; set; }
        public string cellular_number { get; set; }
        public string comments { get; set; }
        public string company { get; set; }
        public string contact { get; set; }
        public string contact_phone { get; set; }
        public string contact_relation { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string em_id { get; set; }
        public string email { get; set; }
        public string entered_by { get; set; }
        public string fl_id { get; set; }
        public short has_parking { get; set; }
        public string honorific { get; set; }
        public string image_file { get; set; }
        public short is_authorized { get; set; }
        public string name_first { get; set; }
        public string name_last { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string rm_id { get; set; }
        public string rm_name { get; set; }
        public string security_type { get; set; }
        public string visitor_photo { get; set; }
        public int visitor_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Em em { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Rm rm { get; set; }
    }
}
