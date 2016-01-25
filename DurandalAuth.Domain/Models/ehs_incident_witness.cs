using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_incident_witness
    {
        public string contact_id { get; set; }
        public Nullable<System.DateTime> date_recorded { get; set; }
        public string doc { get; set; }
        public string em_id { get; set; }
        public int incident_id { get; set; }
        public string information { get; set; }
        public string non_em_info { get; set; }
        public string non_em_name { get; set; }
        public string witness_type { get; set; }
        public int incident_witness_id { get; set; }
        public virtual Contact contact { get; set; }
        public virtual Em em { get; set; }
        public virtual ehs_incidents ehs_incidents { get; set; }
    }
}
