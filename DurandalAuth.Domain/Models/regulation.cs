using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class regulation
    {
        public regulation()
        {
            this.activity_log = new List<activity_log>();
            this.docs_assigned = new List<docs_assigned>();
            this.ehs_incidents = new List<ehs_incidents>();
            this.ehs_incidents1 = new List<ehs_incidents>();
            this.ehs_medical_monitoring = new List<ehs_medical_monitoring>();
            this.ehs_training = new List<ehs_training>();
            this.ls_comm = new List<ls_comm>();
            this.regcompliances = new List<regcompliance>();
            this.reglocs = new List<regloc>();
            this.regnotifies = new List<regnotify>();
            this.regprograms = new List<regprogram>();
            this.regrequirements = new List<regrequirement>();
            this.regviolations = new List<regviolation>();
        }

        public string authority { get; set; }
        public string citation { get; set; }
        public Nullable<System.DateTime> date_compliance { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public string description { get; set; }
        public string hierarchy_ids { get; set; }
        public string hpattern { get; set; }
        public string hpattern_acad { get; set; }
        public string legal_refs { get; set; }
        public string reg_cat { get; set; }
        public string reg_category { get; set; }
        public string reg_class { get; set; }
        public string reg_name { get; set; }
        public short reg_rank { get; set; }
        public string reg_type { get; set; }
        public string related_reg { get; set; }
        public string web_ref1 { get; set; }
        public string website { get; set; }
        public string regulation1 { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual Company company { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
        public virtual ICollection<ehs_incidents> ehs_incidents { get; set; }
        public virtual ICollection<ehs_incidents> ehs_incidents1 { get; set; }
        public virtual ICollection<ehs_medical_monitoring> ehs_medical_monitoring { get; set; }
        public virtual ICollection<ehs_training> ehs_training { get; set; }
        public virtual ICollection<ls_comm> ls_comm { get; set; }
        public virtual regcat regcat { get; set; }
        public virtual ICollection<regcompliance> regcompliances { get; set; }
        public virtual ICollection<regloc> reglocs { get; set; }
        public virtual ICollection<regnotify> regnotifies { get; set; }
        public virtual ICollection<regprogram> regprograms { get; set; }
        public virtual ICollection<regrequirement> regrequirements { get; set; }
        public virtual regtype regtype { get; set; }
        public virtual ICollection<regviolation> regviolations { get; set; }
    }
}
