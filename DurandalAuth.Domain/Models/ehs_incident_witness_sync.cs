using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_incident_witness_sync
    {
        public string contact_id { get; set; }
        public string em_id { get; set; }
        public string information { get; set; }
        public int mob_incident_id { get; set; }
        public Nullable<short> mob_is_changed { get; set; }
        public string mob_locked_by { get; set; }
        public string non_em_info { get; set; }
        public string non_em_name { get; set; }
        public string witness_type { get; set; }
        public int auto_number { get; set; }
        public virtual Contact contact { get; set; }
        public virtual Em em { get; set; }
    }
}
