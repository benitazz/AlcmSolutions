using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class regviolation
    {
        public string authority { get; set; }
        public decimal cost_total { get; set; }
        public Nullable<System.DateTime> date_assessed { get; set; }
        public Nullable<System.DateTime> date_from { get; set; }
        public Nullable<System.DateTime> date_to { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string issued_by { get; set; }
        public Nullable<int> location_id { get; set; }
        public string penalty { get; set; }
        public string reg_program { get; set; }
        public string reg_requirement { get; set; }
        public string regulation { get; set; }
        public short severity { get; set; }
        public string status { get; set; }
        public string summary { get; set; }
        public string violation_id { get; set; }
        public string violation_type { get; set; }
        public int violation_num { get; set; }
        public virtual Company company { get; set; }
        public virtual compliance_locations compliance_locations { get; set; }
        public virtual regprogram regprogram { get; set; }
        public virtual regrequirement regrequirement { get; set; }
        public virtual regulation regulation1 { get; set; }
        public virtual regviolationtyp regviolationtyp { get; set; }
    }
}
