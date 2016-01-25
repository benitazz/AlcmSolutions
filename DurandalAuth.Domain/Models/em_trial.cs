using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class em_trial
    {
        public string bl_id { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public string trial_project_id { get; set; }
        public string em_id { get; set; }
        public string layer_name { get; set; }
        public virtual bl bl { get; set; }
        public virtual Em em { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Rm rm { get; set; }
        public virtual trialproject trialproject { get; set; }
    }
}
