using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_subtasks
    {
        public string comments { get; set; }
        public short display_order { get; set; }
        public string fixedformat_file { get; set; }
        public string help_file { get; set; }
        public string help_topic { get; set; }
        public string proc_file { get; set; }
        public string proc_name { get; set; }
        public string security_group { get; set; }
        public string subtask_01 { get; set; }
        public string subtask_02 { get; set; }
        public string subtask_03 { get; set; }
        public string subtask_ch { get; set; }
        public string subtask_de { get; set; }
        public string subtask_es { get; set; }
        public string subtask_fr { get; set; }
        public string subtask_it { get; set; }
        public string subtask_jp { get; set; }
        public string subtask_ko { get; set; }
        public string subtask_nl { get; set; }
        public string subtask_no { get; set; }
        public string subtask_zh { get; set; }
        public Nullable<short> test_has_dialog { get; set; }
        public string transfer_status { get; set; }
        public string view_name { get; set; }
        public string afm_module { get; set; }
        public string act_class { get; set; }
        public string act { get; set; }
        public string task_cat { get; set; }
        public string task { get; set; }
        public string subtask { get; set; }
        public virtual afm_acts afm_acts { get; set; }
        public virtual afm_cats afm_cats { get; set; }
        public virtual afm_class afm_class { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual afm_mods afm_mods { get; set; }
        public virtual afm_tasks afm_tasks { get; set; }
    }
}
