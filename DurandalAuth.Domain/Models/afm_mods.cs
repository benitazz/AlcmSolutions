using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_mods
    {
        public afm_mods()
        {
            this.afm_acts = new List<afm_acts>();
            this.afm_cats = new List<afm_cats>();
            this.afm_class = new List<afm_class>();
            this.afm_subtasks = new List<afm_subtasks>();
            this.afm_tasks = new List<afm_tasks>();
        }

        public string afm_module_01 { get; set; }
        public string afm_module_02 { get; set; }
        public string afm_module_03 { get; set; }
        public string afm_module_ch { get; set; }
        public string afm_module_de { get; set; }
        public string afm_module_es { get; set; }
        public string afm_module_fr { get; set; }
        public string afm_module_it { get; set; }
        public string afm_module_jp { get; set; }
        public string afm_module_ko { get; set; }
        public string afm_module_nl { get; set; }
        public string afm_module_no { get; set; }
        public string afm_module_zh { get; set; }
        public string button { get; set; }
        public string comments { get; set; }
        public short display_order { get; set; }
        public string help_file { get; set; }
        public string help_topic { get; set; }
        public string security_group { get; set; }
        public string transfer_status { get; set; }
        public short visible { get; set; }
        public string afm_module { get; set; }
        public virtual ICollection<afm_acts> afm_acts { get; set; }
        public virtual ICollection<afm_cats> afm_cats { get; set; }
        public virtual ICollection<afm_class> afm_class { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual ICollection<afm_subtasks> afm_subtasks { get; set; }
        public virtual ICollection<afm_tasks> afm_tasks { get; set; }
    }
}
