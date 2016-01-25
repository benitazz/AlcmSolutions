using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class work_team
    {
        public work_team()
        {
            this.activity_log = new List<activity_log>();
            this.cfs = new List<cf>();
            this.helpdesk_sla_response = new List<helpdesk_sla_response>();
            this.woes = new List<wo>();
            this.wrs = new List<wr>();
            this.cfs1 = new List<cf>();
        }

        public short cf_assign { get; set; }
        public string description { get; set; }
        public string work_team_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<cf> cfs { get; set; }
        public virtual ICollection<helpdesk_sla_response> helpdesk_sla_response { get; set; }
        public virtual ICollection<wo> woes { get; set; }
        public virtual ICollection<wr> wrs { get; set; }
        public virtual ICollection<cf> cfs1 { get; set; }
    }
}
