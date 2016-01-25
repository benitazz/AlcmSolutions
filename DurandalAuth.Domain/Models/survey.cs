using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class survey
    {
        public survey()
        {
            this.eqs = new List<eq>();
            this.eq_audit = new List<eq_audit>();
            this.eq_compinvsur = new List<eq_compinvsur>();
            this.fn_compinvsur = new List<fn_compinvsur>();
            this.fs = new List<f>();
            this.ta_audit = new List<ta_audit>();
            this.ta_compinvsur = new List<ta_compinvsur>();
            this.tas = new List<ta>();
        }

        public string description { get; set; }
        public string em_id { get; set; }
        public string report { get; set; }
        public string status { get; set; }
        public System.DateTime survey_date { get; set; }
        public string survey_fields { get; set; }
        public string survey_id { get; set; }
        public virtual Em em { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<eq_audit> eq_audit { get; set; }
        public virtual ICollection<eq_compinvsur> eq_compinvsur { get; set; }
        public virtual ICollection<fn_compinvsur> fn_compinvsur { get; set; }
        public virtual ICollection<f> fs { get; set; }
        public virtual ICollection<ta_audit> ta_audit { get; set; }
        public virtual ICollection<ta_compinvsur> ta_compinvsur { get; set; }
        public virtual ICollection<ta> tas { get; set; }
    }
}
