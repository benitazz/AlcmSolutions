using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class reserve_rm
    {
        public short attendees_in_room { get; set; }
        public string bl_id { get; set; }
        public string comments { get; set; }
        public string config_id { get; set; }
        public decimal cost_rmres { get; set; }
        public Nullable<System.DateTime> date_cancelled { get; set; }
        public System.DateTime date_created { get; set; }
        public Nullable<System.DateTime> date_last_modified { get; set; }
        public Nullable<System.DateTime> date_rejected { get; set; }
        public System.DateTime date_start { get; set; }
        public string fl_id { get; set; }
        public short guests_external { get; set; }
        public short guests_internal { get; set; }
        public short recurring_order { get; set; }
        public int res_id { get; set; }
        public string rm_arrange_type_id { get; set; }
        public string rm_id { get; set; }
        public string status { get; set; }
        public System.DateTime time_end { get; set; }
        public System.DateTime time_start { get; set; }
        public string user_last_modified_by { get; set; }
        public short verified { get; set; }
        public int rmres_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Em em { get; set; }
        public virtual Fl fl { get; set; }
        public virtual reserve reserve { get; set; }
        public virtual rm_config rm_config { get; set; }
        public virtual rm_arrange rm_arrange { get; set; }
        public virtual Rm rm { get; set; }
    }
}
