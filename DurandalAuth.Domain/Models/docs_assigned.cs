using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class docs_assigned
    {
        public string doc_note { get; set; }
        public string doc_review_grp { get; set; }
        public string doc_type { get; set; }
        public Nullable<int> incident_id { get; set; }
        public Nullable<int> location_id { get; set; }
        public string ls_id { get; set; }
        public Nullable<int> medical_monitoring_id { get; set; }
        public string name { get; set; }
        public string ppe_type_id { get; set; }
        public string pr_id { get; set; }
        public string reg_program { get; set; }
        public string reg_requirement { get; set; }
        public string regulation { get; set; }
        public Nullable<int> restriction_id { get; set; }
        public string site_id { get; set; }
        public string training_id { get; set; }
        public Nullable<int> activity_log_id { get; set; }
        public string bl_id { get; set; }
        public string classification { get; set; }
        public Nullable<System.DateTime> date_doc { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string doc_author { get; set; }
        public string doc_cat { get; set; }
        public string doc_folder { get; set; }
        public int doc_id { get; set; }
        public virtual activity_log activity_log { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual bl bl { get; set; }
        public virtual compliance_locations compliance_locations { get; set; }
        public virtual doccat doccat { get; set; }
        public virtual docfolder docfolder { get; set; }
        public virtual doctype doctype { get; set; }
        public virtual ehs_incidents ehs_incidents { get; set; }
        public virtual l l { get; set; }
        public virtual ehs_medical_monitoring ehs_medical_monitoring { get; set; }
        public virtual ehs_ppe_types ehs_ppe_types { get; set; }
        public virtual Property property { get; set; }
        public virtual regprogram regprogram { get; set; }
        public virtual regrequirement regrequirement { get; set; }
        public virtual regulation regulation1 { get; set; }
        public virtual ehs_restrictions ehs_restrictions { get; set; }
        public virtual site site { get; set; }
        public virtual ehs_training ehs_training { get; set; }
    }
}
