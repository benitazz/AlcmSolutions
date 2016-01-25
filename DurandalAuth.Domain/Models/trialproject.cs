using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class trialproject
    {
        public trialproject()
        {
            this.em_trial = new List<em_trial>();
            this.eq_trial = new List<eq_trial>();
            this.fn_comptrialtrial = new List<fn_comptrialtrial>();
            this.fn_comptrialtrial1 = new List<fn_comptrialtrial>();
            this.fn_trial = new List<fn_trial>();
            this.rm_trial = new List<rm_trial>();
            this.ta_trial = new List<ta_trial>();
        }

        public string description { get; set; }
        public string project_id { get; set; }
        public string trial_project_id { get; set; }
        public virtual ICollection<em_trial> em_trial { get; set; }
        public virtual ICollection<eq_trial> eq_trial { get; set; }
        public virtual ICollection<fn_comptrialtrial> fn_comptrialtrial { get; set; }
        public virtual ICollection<fn_comptrialtrial> fn_comptrialtrial1 { get; set; }
        public virtual ICollection<fn_trial> fn_trial { get; set; }
        public virtual project project { get; set; }
        public virtual ICollection<rm_trial> rm_trial { get; set; }
        public virtual ICollection<ta_trial> ta_trial { get; set; }
    }
}
