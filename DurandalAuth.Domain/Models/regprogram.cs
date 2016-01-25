using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class regprogram
    {
        public regprogram()
        {
            this.activity_log = new List<activity_log>();
            this.docs_assigned = new List<docs_assigned>();
            this.ehs_incidents = new List<ehs_incidents>();
            this.ehs_incidents1 = new List<ehs_incidents>();
            this.ehs_medical_monitoring = new List<ehs_medical_monitoring>();
            this.ehs_training = new List<ehs_training>();
            this.ls_comm = new List<ls_comm>();
            this.reglocs = new List<regloc>();
            this.regnotifies = new List<regnotify>();
            this.regrequirements = new List<regrequirement>();
            this.regviolations = new List<regviolation>();
        }

        public string comp_level { get; set; }
        public string comp_level_calc { get; set; }
        public short comp_level_number_calc { get; set; }
        public string contact_id { get; set; }
        public string criteria { get; set; }
        public string criteria_type { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public string description { get; set; }
        public string em_id { get; set; }
        public string hold_reason { get; set; }
        public short priority { get; set; }
        public string project_id { get; set; }
        public short reqs_inherit_locs { get; set; }
        public string status { get; set; }
        public string summary { get; set; }
        public string vn_id { get; set; }
        public string regprog_cat { get; set; }
        public string regprog_type { get; set; }
        public string regulation { get; set; }
        public string reg_program { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual Contact contact { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
        public virtual ICollection<ehs_incidents> ehs_incidents { get; set; }
        public virtual ICollection<ehs_incidents> ehs_incidents1 { get; set; }
        public virtual ICollection<ehs_medical_monitoring> ehs_medical_monitoring { get; set; }
        public virtual ICollection<ehs_training> ehs_training { get; set; }
        public virtual Em em { get; set; }
        public virtual ICollection<ls_comm> ls_comm { get; set; }
        public virtual project project { get; set; }
        public virtual regcomplevel regcomplevel { get; set; }
        public virtual regcomplevel regcomplevel1 { get; set; }
        public virtual ICollection<regloc> reglocs { get; set; }
        public virtual ICollection<regnotify> regnotifies { get; set; }
        public virtual regprogcat regprogcat { get; set; }
        public virtual regprogtype regprogtype { get; set; }
        public virtual regulation regulation1 { get; set; }
        public virtual vn vn { get; set; }
        public virtual ICollection<regrequirement> regrequirements { get; set; }
        public virtual ICollection<regviolation> regviolations { get; set; }
    }
}
