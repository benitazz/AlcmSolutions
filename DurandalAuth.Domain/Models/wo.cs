using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wo
    {
        public wo()
        {
            this.activity_log = new List<activity_log>();
            this.wrs = new List<wr>();
        }

        public string ac_id { get; set; }
        public string bl_id { get; set; }
        public decimal cost_estimated { get; set; }
        public decimal cost_labor { get; set; }
        public decimal cost_other { get; set; }
        public decimal cost_parts { get; set; }
        public decimal cost_tools { get; set; }
        public decimal cost_total { get; set; }
        public Nullable<System.DateTime> date_assigned { get; set; }
        public Nullable<System.DateTime> date_closed { get; set; }
        public Nullable<System.DateTime> date_completed { get; set; }
        public Nullable<System.DateTime> date_created { get; set; }
        public Nullable<System.DateTime> date_issued { get; set; }
        public string description { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string name_authorized { get; set; }
        public string name_of_contact { get; set; }
        public string name_of_planner { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public short priority { get; set; }
        public Nullable<short> qty_open_wr { get; set; }
        public string supervisor { get; set; }
        public Nullable<System.DateTime> time_assigned { get; set; }
        public Nullable<System.DateTime> time_closed { get; set; }
        public Nullable<System.DateTime> time_completed { get; set; }
        public Nullable<System.DateTime> time_created { get; set; }
        public Nullable<System.DateTime> time_issued { get; set; }
        public string tr_id { get; set; }
        public string wo_type { get; set; }
        public string work_team_id { get; set; }
        public int wo_id { get; set; }
        public virtual ac ac { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual bl bl { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Em em { get; set; }
        public virtual Em em1 { get; set; }
        public virtual Em em2 { get; set; }
        public virtual Em em3 { get; set; }
        public virtual tr tr { get; set; }
        public virtual work_team work_team { get; set; }
        public virtual ICollection<wr> wrs { get; set; }
    }
}
