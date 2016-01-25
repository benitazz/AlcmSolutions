using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_incidents_sync
    {
        public string bl_id { get; set; }
        public string contact_id { get; set; }
        public Nullable<System.DateTime> date_death { get; set; }
        public System.DateTime date_incident { get; set; }
        public string description { get; set; }
        public string em_id_affected { get; set; }
        public short emergency_rm_treatment { get; set; }
        public string fl_id { get; set; }
        public Nullable<int> incident_id { get; set; }
        public string incident_type { get; set; }
        public string injury_area_id { get; set; }
        public string injury_category_id { get; set; }
        public short is_hospitalized { get; set; }
        public int mob_incident_id { get; set; }
        public Nullable<short> mob_is_changed { get; set; }
        public string mob_locked_by { get; set; }
        public string non_em_info { get; set; }
        public string non_em_name { get; set; }
        public int parent_incident_id { get; set; }
        public string pr_id { get; set; }
        public string recorded_by { get; set; }
        public string reported_by { get; set; }
        public string rm_id { get; set; }
        public string site_id { get; set; }
        public Nullable<System.DateTime> time_incident { get; set; }
        public int auto_number { get; set; }
        public virtual bl bl { get; set; }
        public virtual Contact contact { get; set; }
        public virtual ehs_incident_injury_areas ehs_incident_injury_areas { get; set; }
        public virtual ehs_incident_injury_cat ehs_incident_injury_cat { get; set; }
        public virtual ehs_incident_types ehs_incident_types { get; set; }
        public virtual Em em { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Property property { get; set; }
        public virtual Em em1 { get; set; }
        public virtual Em em2 { get; set; }
        public virtual Rm rm { get; set; }
        public virtual site site { get; set; }
    }
}
