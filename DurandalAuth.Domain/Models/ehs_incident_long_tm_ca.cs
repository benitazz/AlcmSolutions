using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_incident_long_tm_ca
    {
        public ehs_incident_long_tm_ca()
        {
            this.ehs_incidents = new List<ehs_incidents>();
        }

        public string description { get; set; }
        public string long_term_ca { get; set; }
        public virtual ICollection<ehs_incidents> ehs_incidents { get; set; }
    }
}
