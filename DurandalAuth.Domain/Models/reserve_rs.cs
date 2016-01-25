using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class reserve_rs
    {
        public string bl_id { get; set; }
        public string comments { get; set; }
        public decimal cost_rsres { get; set; }
        public Nullable<System.DateTime> date_cancelled { get; set; }
        public System.DateTime date_created { get; set; }
        public Nullable<System.DateTime> date_last_modified { get; set; }
        public Nullable<System.DateTime> date_rejected { get; set; }
        public System.DateTime date_start { get; set; }
        public string fl_id { get; set; }
        public short quantity { get; set; }
        public short recurring_order { get; set; }
        public int res_id { get; set; }
        public string resource_id { get; set; }
        public string rm_id { get; set; }
        public string status { get; set; }
        public System.DateTime time_end { get; set; }
        public System.DateTime time_start { get; set; }
        public string user_last_modified_by { get; set; }
        public int rsres_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Em em { get; set; }
        public virtual Fl fl { get; set; }
        public virtual reserve reserve { get; set; }
        public virtual resource resource { get; set; }
        public virtual Rm rm { get; set; }
    }
}
