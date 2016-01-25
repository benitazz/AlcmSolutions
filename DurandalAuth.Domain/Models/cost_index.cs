using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cost_index
    {
        public cost_index()
        {
            this.cost_index_trans = new List<cost_index_trans>();
            this.cost_index_values = new List<cost_index_values>();
            this.ls_index_profile = new List<ls_index_profile>();
        }

        public string cost_index_name { get; set; }
        public string description { get; set; }
        public string cost_index_id { get; set; }
        public virtual ICollection<cost_index_trans> cost_index_trans { get; set; }
        public virtual ICollection<cost_index_values> cost_index_values { get; set; }
        public virtual ICollection<ls_index_profile> ls_index_profile { get; set; }
    }
}
