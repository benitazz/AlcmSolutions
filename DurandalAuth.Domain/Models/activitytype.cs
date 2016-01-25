using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class activitytype
    {
        public activitytype()
        {
            this.activity_log = new List<activity_log>();
            this.activity_log_sync = new List<activity_log_sync>();
            this.helpdesk_sla_request = new List<helpdesk_sla_request>();
            this.helpdesk_sla_response = new List<helpdesk_sla_response>();
            this.helpdesk_sla_steps = new List<helpdesk_sla_steps>();
            this.questions = new List<question>();
            this.wrs = new List<wr>();
        }

        public short autocreate_wr { get; set; }
        public decimal cost_standard { get; set; }
        public string description { get; set; }
        public string description_01 { get; set; }
        public string description_02 { get; set; }
        public string description_03 { get; set; }
        public string description_ch { get; set; }
        public string description_de { get; set; }
        public string description_es { get; set; }
        public string description_fr { get; set; }
        public string description_it { get; set; }
        public string description_jp { get; set; }
        public string description_ko { get; set; }
        public string description_nl { get; set; }
        public string description_no { get; set; }
        public string description_zh { get; set; }
        public Nullable<short> display_order { get; set; }
        public string group_name { get; set; }
        public string hide_fields { get; set; }
        public string instructions { get; set; }
        public string menu_icon { get; set; }
        public string mobile_action { get; set; }
        public string prob_type { get; set; }
        public string title { get; set; }
        public string title_01 { get; set; }
        public string title_02 { get; set; }
        public string title_03 { get; set; }
        public string title_ch { get; set; }
        public string title_de { get; set; }
        public string title_es { get; set; }
        public string title_fr { get; set; }
        public string title_it { get; set; }
        public string title_jp { get; set; }
        public string title_ko { get; set; }
        public string title_nl { get; set; }
        public string title_no { get; set; }
        public string title_zh { get; set; }
        public string activity_type { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<activity_log_sync> activity_log_sync { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual probtype probtype { get; set; }
        public virtual ICollection<helpdesk_sla_request> helpdesk_sla_request { get; set; }
        public virtual ICollection<helpdesk_sla_response> helpdesk_sla_response { get; set; }
        public virtual ICollection<helpdesk_sla_steps> helpdesk_sla_steps { get; set; }
        public virtual ICollection<question> questions { get; set; }
        public virtual ICollection<wr> wrs { get; set; }
    }
}
