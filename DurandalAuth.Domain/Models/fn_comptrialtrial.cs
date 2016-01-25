using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class fn_comptrialtrial
    {
        public int count_trial1 { get; set; }
        public int count_trial2 { get; set; }
        public string dwgnames1 { get; set; }
        public string dwgnames2 { get; set; }
        public string fn_std { get; set; }
        public string layers1 { get; set; }
        public string layers2 { get; set; }
        public string trial_project_id1 { get; set; }
        public string trial_project_id2 { get; set; }
        public int auto_number { get; set; }
        public virtual fnstd fnstd { get; set; }
        public virtual trialproject trialproject { get; set; }
        public virtual trialproject trialproject1 { get; set; }
    }
}
