using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_ptasks
    {
        public afm_ptasks()
        {
            this.afm_psubtasks = new List<afm_psubtasks>();
        }

        public string comments { get; set; }
        public Nullable<short> display_order { get; set; }
        public string help_link { get; set; }
        public string hot_user_name { get; set; }
        public string icon_large { get; set; }
        public string icon_small { get; set; }
        public short iframe_height { get; set; }
        public short iframe_width { get; set; }
        public Nullable<int> internal_use1 { get; set; }
        public Nullable<short> is_hotlist { get; set; }
        public string security_group { get; set; }
        public string task_01 { get; set; }
        public string task_02 { get; set; }
        public string task_03 { get; set; }
        public string task_action { get; set; }
        public string task_ch { get; set; }
        public string task_de { get; set; }
        public string task_es { get; set; }
        public string task_file { get; set; }
        public string task_fr { get; set; }
        public string task_it { get; set; }
        public string task_jp { get; set; }
        public string task_ko { get; set; }
        public string task_nl { get; set; }
        public string task_no { get; set; }
        public string task_type { get; set; }
        public string task_zh { get; set; }
        public string transfer_status { get; set; }
        public string view_type_override { get; set; }
        public string activity_id { get; set; }
        public string process_id { get; set; }
        public string task_id { get; set; }
        public virtual afm_activities afm_activities { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual afm_processes afm_processes { get; set; }
        public virtual ICollection<afm_psubtasks> afm_psubtasks { get; set; }
        public virtual afm_users afm_users { get; set; }
    }
}
