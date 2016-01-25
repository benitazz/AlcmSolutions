using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_cats
    {
        public afm_cats()
        {
            this.afm_subtasks = new List<afm_subtasks>();
            this.afm_tasks = new List<afm_tasks>();
        }

        public string button { get; set; }
        public string comments { get; set; }
        public short dflt_task_cat { get; set; }
        public short display_order { get; set; }
        public string help_file { get; set; }
        public string help_topic { get; set; }
        public string security_group { get; set; }
        public string task_cat_01 { get; set; }
        public string task_cat_02 { get; set; }
        public string task_cat_03 { get; set; }
        public string task_cat_ch { get; set; }
        public string task_cat_de { get; set; }
        public string task_cat_es { get; set; }
        public string task_cat_fr { get; set; }
        public string task_cat_it { get; set; }
        public string task_cat_jp { get; set; }
        public string task_cat_ko { get; set; }
        public string task_cat_nl { get; set; }
        public string task_cat_no { get; set; }
        public string task_cat_zh { get; set; }
        public string transfer_status { get; set; }
        public string afm_module { get; set; }
        public string act_class { get; set; }
        public string act { get; set; }
        public string task_cat { get; set; }
        public virtual afm_acts afm_acts { get; set; }
        public virtual afm_class afm_class { get; set; }
        public virtual afm_mods afm_mods { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual ICollection<afm_subtasks> afm_subtasks { get; set; }
        public virtual ICollection<afm_tasks> afm_tasks { get; set; }
    }
}
