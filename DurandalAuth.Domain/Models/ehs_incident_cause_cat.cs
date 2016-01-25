using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_incident_cause_cat
    {
        public ehs_incident_cause_cat()
        {
            this.ehs_incidents = new List<ehs_incidents>();
        }

        public string description { get; set; }
        public string cause_category_id { get; set; }
        public virtual ICollection<ehs_incidents> ehs_incidents { get; set; }
    }
}
