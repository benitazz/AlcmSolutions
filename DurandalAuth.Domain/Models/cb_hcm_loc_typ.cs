using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cb_hcm_loc_typ
    {
        public cb_hcm_loc_typ()
        {
            this.activity_log = new List<activity_log>();
            this.activity_log1 = new List<activity_log>();
        }

        public string description { get; set; }
        public string name { get; set; }
        public string prob_type { get; set; }
        public string hcm_loc_typ_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual probtype probtype { get; set; }
        public virtual ICollection<activity_log> activity_log1 { get; set; }
    }
}
