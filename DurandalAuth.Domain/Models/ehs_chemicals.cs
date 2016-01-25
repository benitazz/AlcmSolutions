using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_chemicals
    {
        public ehs_chemicals()
        {
            this.ehs_incidents = new List<ehs_incidents>();
            this.ehs_training = new List<ehs_training>();
        }

        public string description { get; set; }
        public Nullable<int> msds_id { get; set; }
        public string chemical_name { get; set; }
        public virtual msds_data msds_data { get; set; }
        public virtual ICollection<ehs_incidents> ehs_incidents { get; set; }
        public virtual ICollection<ehs_training> ehs_training { get; set; }
    }
}
