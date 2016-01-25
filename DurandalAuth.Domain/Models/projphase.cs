using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class projphase
    {
        public projphase()
        {
            this.activity_log = new List<activity_log>();
            this.work_pkgs = new List<work_pkgs>();
        }

        public string proj_phase_01 { get; set; }
        public string proj_phase_02 { get; set; }
        public string proj_phase_03 { get; set; }
        public string proj_phase_ch { get; set; }
        public string proj_phase_de { get; set; }
        public string proj_phase_es { get; set; }
        public string proj_phase_fr { get; set; }
        public string proj_phase_it { get; set; }
        public string proj_phase_jp { get; set; }
        public string proj_phase_ko { get; set; }
        public string proj_phase_nl { get; set; }
        public string proj_phase_no { get; set; }
        public string proj_phase_zh { get; set; }
        public string proj_phase { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<work_pkgs> work_pkgs { get; set; }
    }
}
