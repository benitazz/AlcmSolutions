using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cb_sample_comp
    {
        public cb_sample_comp()
        {
            this.cb_sample_result = new List<cb_sample_result>();
        }

        public string cas_num { get; set; }
        public string description { get; set; }
        public short is_hazard { get; set; }
        public string name { get; set; }
        public string prob_type { get; set; }
        public string sample_comp_id { get; set; }
        public virtual probtype probtype { get; set; }
        public virtual ICollection<cb_sample_result> cb_sample_result { get; set; }
    }
}
