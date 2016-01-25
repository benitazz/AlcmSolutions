using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_incidents
    {
        public ehs_incidents()
        {
            this.activity_log = new List<activity_log>();
            this.docs_assigned = new List<docs_assigned>();
            this.ehs_em_ppe_types = new List<ehs_em_ppe_types>();
            this.ehs_incident_witness = new List<ehs_incident_witness>();
            this.ehs_medical_mon_results = new List<ehs_medical_mon_results>();
            this.ehs_restrictions = new List<ehs_restrictions>();
            this.ehs_training_results = new List<ehs_training_results>();
        }

        public string activity_before { get; set; }
        public string bl_id { get; set; }
        public string cause_category_id { get; set; }
        public string cause_description { get; set; }
        public string cause_doc { get; set; }
        public string chemical_name { get; set; }
        public string contact_id { get; set; }
        public Nullable<System.DateTime> date_death { get; set; }
        public System.DateTime date_incident { get; set; }
        public string description { get; set; }
        public string em_id_affected { get; set; }
        public short emergency_rm_treatment { get; set; }
        public string eq_id { get; set; }
        public string fl_id { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public string incident_type { get; set; }
        public string injury_area_id { get; set; }
        public string injury_category_id { get; set; }
        public short is_hospitalized { get; set; }
        public Nullable<decimal> lat { get; set; }
        public Nullable<decimal> lon { get; set; }
        public string long_term_ca { get; set; }
        public string long_term_ca_desc { get; set; }
        public decimal lost_work_days { get; set; }
        public string lt_reg_program { get; set; }
        public string lt_reg_requirement { get; set; }
        public string lt_regulation { get; set; }
        public string medical_facility { get; set; }
        public string medical_facility_address { get; set; }
        public string non_em_info { get; set; }
        public string non_em_name { get; set; }
        public int parent_incident_id { get; set; }
        public string physician_name { get; set; }
        public string pr_id { get; set; }
        public string recorded_by { get; set; }
        public string reported_by { get; set; }
        public string responsible_mgr { get; set; }
        public string rm_id { get; set; }
        public string safety_officer { get; set; }
        public string short_term_ca { get; set; }
        public string short_term_ca_desc { get; set; }
        public string site_id { get; set; }
        public string st_reg_program { get; set; }
        public string st_reg_requirement { get; set; }
        public string st_regulation { get; set; }
        public Nullable<System.DateTime> time_incident { get; set; }
        public int incident_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual bl bl { get; set; }
        public virtual Contact contact { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
        public virtual ehs_chemicals ehs_chemicals { get; set; }
        public virtual ICollection<ehs_em_ppe_types> ehs_em_ppe_types { get; set; }
        public virtual ehs_incident_cause_cat ehs_incident_cause_cat { get; set; }
        public virtual ehs_incident_injury_areas ehs_incident_injury_areas { get; set; }
        public virtual ehs_incident_injury_cat ehs_incident_injury_cat { get; set; }
        public virtual ehs_incident_long_tm_ca ehs_incident_long_tm_ca { get; set; }
        public virtual ehs_incident_short_tm_ca ehs_incident_short_tm_ca { get; set; }
        public virtual ehs_incident_types ehs_incident_types { get; set; }
        public virtual ICollection<ehs_incident_witness> ehs_incident_witness { get; set; }
        public virtual Em em { get; set; }
        public virtual eq eq { get; set; }
        public virtual Fl fl { get; set; }
        public virtual regprogram regprogram { get; set; }
        public virtual regrequirement regrequirement { get; set; }
        public virtual regulation regulation { get; set; }
        public virtual Property property { get; set; }
        public virtual Em em1 { get; set; }
        public virtual Em em2 { get; set; }
        public virtual Em em3 { get; set; }
        public virtual Rm rm { get; set; }
        public virtual Em em4 { get; set; }
        public virtual site site { get; set; }
        public virtual regprogram regprogram1 { get; set; }
        public virtual regrequirement regrequirement1 { get; set; }
        public virtual regulation regulation1 { get; set; }
        public virtual ICollection<ehs_medical_mon_results> ehs_medical_mon_results { get; set; }
        public virtual ICollection<ehs_restrictions> ehs_restrictions { get; set; }
        public virtual ICollection<ehs_training_results> ehs_training_results { get; set; }
    }
}
