using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cb_hcm_class
    {
        public cb_hcm_class()
        {
            this.activity_log = new List<activity_log>();
            this.activity_log1 = new List<activity_log>();
            this.activity_log2 = new List<activity_log>();
        }

        public string class_std { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string prob_type { get; set; }
        public string hcm_class_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<activity_log> activity_log1 { get; set; }
        public virtual ICollection<activity_log> activity_log2 { get; set; }
        public virtual probtype probtype { get; set; }
    }
}
