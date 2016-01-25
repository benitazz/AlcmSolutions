using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_acts
    {
        public afm_acts()
        {
            this.afm_cats = new List<afm_cats>();
            this.afm_subtasks = new List<afm_subtasks>();
            this.afm_tasks = new List<afm_tasks>();
        }

        public string act_de { get; set; }
        public string act_es { get; set; }
        public string act_fr { get; set; }
        public string act_it { get; set; }
        public string act_jp { get; set; }
        public string act_ko { get; set; }
        public string act_nl { get; set; }
        public string act_no { get; set; }
        public string act_zh { get; set; }
        public string act_01 { get; set; }
        public string act_02 { get; set; }
        public string act_03 { get; set; }
        public string act_ch { get; set; }
        public string comments { get; set; }
        public short display_order { get; set; }
        public string help_file { get; set; }
        public string help_topic { get; set; }
        public string security_group { get; set; }
        public string transfer_status { get; set; }
        public string afm_module { get; set; }
        public string act_class { get; set; }
        public string act { get; set; }
        public virtual afm_class afm_class { get; set; }
        public virtual afm_mods afm_mods { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual ICollection<afm_cats> afm_cats { get; set; }
        public virtual ICollection<afm_subtasks> afm_subtasks { get; set; }
        public virtual ICollection<afm_tasks> afm_tasks { get; set; }
    }
}
