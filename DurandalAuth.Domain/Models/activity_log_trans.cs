using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class activity_log_trans
    {
        public string assigned_to { get; set; }
        public string comments { get; set; }
        public Nullable<System.DateTime> date_scheduled { get; set; }
        public short duration { get; set; }
        public short pct_complete { get; set; }
        public string predecessors { get; set; }
        public string project_id { get; set; }
        public string project_work_pkg_id { get; set; }
        public string status { get; set; }
        public Nullable<int> uid_ms_proj { get; set; }
        public string wbs_id { get; set; }
        public string work_pkg_id { get; set; }
        public string action_title { get; set; }
        public Nullable<int> activity_log_id { get; set; }
        public int activity_log_trans_id { get; set; }
        public virtual project project { get; set; }
        public virtual work_pkgs work_pkgs { get; set; }
    }
}
