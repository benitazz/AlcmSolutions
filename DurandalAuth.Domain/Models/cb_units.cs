using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cb_units
    {
        public cb_units()
        {
            this.activity_log = new List<activity_log>();
            this.cb_sample_result = new List<cb_sample_result>();
        }

        public string description { get; set; }
        public string name { get; set; }
        public string prob_type { get; set; }
        public string cb_units_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<cb_sample_result> cb_sample_result { get; set; }
        public virtual probtype probtype { get; set; }
    }
}
