using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rf_activity
    {
        public string bl_id { get; set; }
        public Nullable<System.DateTime> date_activity { get; set; }
        public Nullable<int> direction { get; set; }
        public Nullable<decimal> epoch_time { get; set; }
        public string fl_id { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public Nullable<decimal> lat { get; set; }
        public Nullable<decimal> lon { get; set; }
        public string reader_id { get; set; }
        public string rm_id { get; set; }
        public string site_id { get; set; }
        public string tag_id { get; set; }
        public Nullable<System.DateTime> time_activity { get; set; }
        public int rf_act_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual rf_reader rf_reader { get; set; }
        public virtual Rm rm { get; set; }
        public virtual site site { get; set; }
    }
}
