using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_tasks
    {
        public afm_tasks()
        {
            this.afm_subtasks = new List<afm_subtasks>();
        }

        public string comments { get; set; }
        public short display_order { get; set; }
        public string fixedformat_file { get; set; }
        public string help_file { get; set; }
        public string help_topic { get; set; }
        public string proc_file { get; set; }
        public string proc_name { get; set; }
        public string security_group { get; set; }
        public string task_ch { get; set; }
        public string task_de { get; set; }
        public string task_es { get; set; }
        public string task_fr { get; set; }
        public string task_it { get; set; }
        public string task_jp { get; set; }
        public string task_ko { get; set; }
        public string task_nl { get; set; }
        public string task_no { get; set; }
        public string task_zh { get; set; }
        public Nullable<short> test_has_dialog { get; set; }
        public string transfer_status { get; set; }
        public string view_name { get; set; }
        public string task_01 { get; set; }
        public string task_02 { get; set; }
        public string task_03 { get; set; }
        public string afm_module { get; set; }
        public string act_class { get; set; }
        public string act { get; set; }
        public string task_cat { get; set; }
        public string task { get; set; }
        public virtual afm_acts afm_acts { get; set; }
        public virtual afm_cats afm_cats { get; set; }
        public virtual afm_class afm_class { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual afm_mods afm_mods { get; set; }
        public virtual ICollection<afm_subtasks> afm_subtasks { get; set; }
    }
}
