using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ls_comm_log
    {
        public System.DateTime date_stat_chgd { get; set; }
        public string status { get; set; }
        public System.DateTime time_stat_chgd { get; set; }
        public int ls_comm_id { get; set; }
        public string user_name { get; set; }
        public virtual afm_users afm_users { get; set; }
        public virtual ls_comm ls_comm { get; set; }
    }
}
