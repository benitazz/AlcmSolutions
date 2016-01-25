using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_act_tbls
    {
        public string transfer_status { get; set; }
        public string activity_id { get; set; }
        public string table_name { get; set; }
        public virtual afm_activities afm_activities { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
    }
}
