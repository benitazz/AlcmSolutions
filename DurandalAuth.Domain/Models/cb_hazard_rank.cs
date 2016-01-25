using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cb_hazard_rank
    {
        public cb_hazard_rank()
        {
            this.activity_log = new List<activity_log>();
        }

        public string description { get; set; }
        public string name { get; set; }
        public string prob_type { get; set; }
        public string hcm_haz_rank_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual probtype probtype { get; set; }
    }
}
