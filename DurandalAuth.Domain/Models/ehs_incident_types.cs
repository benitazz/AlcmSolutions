using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_incident_types
    {
        public ehs_incident_types()
        {
            this.ehs_incidents = new List<ehs_incidents>();
            this.ehs_incidents_sync = new List<ehs_incidents_sync>();
        }

        public string description { get; set; }
        public short notification { get; set; }
        public string incident_type { get; set; }
        public virtual ICollection<ehs_incidents> ehs_incidents { get; set; }
        public virtual ICollection<ehs_incidents_sync> ehs_incidents_sync { get; set; }
    }
}
