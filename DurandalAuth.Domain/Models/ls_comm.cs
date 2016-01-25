using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ls_comm
    {
        public ls_comm()
        {
            this.ls_comm_log = new List<ls_comm_log>();
        }

        public string comm_id { get; set; }
        public string comm_type { get; set; }
        public string contact_id { get; set; }
        public System.DateTime date_of_comm { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string hierarchy_ids { get; set; }
        public string image_doc1 { get; set; }
        public Nullable<int> location_id { get; set; }
        public string ls_id { get; set; }
        public Nullable<int> parent_key { get; set; }
        public string priority { get; set; }
        public string project_id { get; set; }
        public string recorded_by { get; set; }
        public string reg_program { get; set; }
        public string reg_requirement { get; set; }
        public string regulation { get; set; }
        public string summary { get; set; }
        public System.DateTime time_of_comm { get; set; }
        public Nullable<int> activity_log_id { get; set; }
        public int auto_number { get; set; }
        public virtual activity_log activity_log { get; set; }
        public virtual commtype commtype { get; set; }
        public virtual compliance_locations compliance_locations { get; set; }
        public virtual Contact contact { get; set; }
        public virtual Em em { get; set; }
        public virtual l l { get; set; }
        public virtual ICollection<ls_comm_log> ls_comm_log { get; set; }
        public virtual project project { get; set; }
        public virtual regprogram regprogram { get; set; }
        public virtual regrequirement regrequirement { get; set; }
        public virtual regulation regulation1 { get; set; }
    }
}
