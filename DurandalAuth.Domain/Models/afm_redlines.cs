using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_redlines
    {
        public string comments { get; set; }
        public System.DateTime date_created { get; set; }
        public string dwg_name { get; set; }
        public string highlightds { get; set; }
        public string highlightds_view_name { get; set; }
        public string labelds { get; set; }
        public string labelds_view_name { get; set; }
        public Nullable<decimal> position_lux { get; set; }
        public Nullable<decimal> position_luy { get; set; }
        public Nullable<decimal> position_rlx { get; set; }
        public Nullable<decimal> position_rly { get; set; }
        public string redlines { get; set; }
        public System.DateTime time_created { get; set; }
        public string user_name { get; set; }
        public Nullable<int> activity_log_id { get; set; }
        public int auto_number { get; set; }
        public virtual afm_dwgs afm_dwgs { get; set; }
        public virtual afm_users afm_users { get; set; }
    }
}
