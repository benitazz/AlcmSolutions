using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rm_trial
    {
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public decimal area { get; set; }
        public string rm_std { get; set; }
        public string trial_project_id { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public string layer_name { get; set; }
        public virtual rmstd rmstd { get; set; }
        public virtual trialproject trialproject { get; set; }
    }
}
