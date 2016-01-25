using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_wf_steps
    {
        public afm_wf_steps()
        {
            this.helpdesk_sla_steps = new List<helpdesk_sla_steps>();
            this.helpdesk_step_log = new List<helpdesk_step_log>();
        }

        public string step_01 { get; set; }
        public string step_02 { get; set; }
        public string step_03 { get; set; }
        public string step_ch { get; set; }
        public string step_de { get; set; }
        public string step_es { get; set; }
        public string step_fr { get; set; }
        public string step_it { get; set; }
        public string step_jp { get; set; }
        public string step_ko { get; set; }
        public string step_nl { get; set; }
        public string step_no { get; set; }
        public string step_status_rejected { get; set; }
        public string step_status_result { get; set; }
        public string step_type { get; set; }
        public string step_zh { get; set; }
        public string subject_message_id { get; set; }
        public string transfer_status { get; set; }
        public string attachments { get; set; }
        public string body_message_id { get; set; }
        public short display_order { get; set; }
        public string form_fields { get; set; }
        public string status_after { get; set; }
        public string activity_id { get; set; }
        public string status { get; set; }
        public string step { get; set; }
        public virtual afm_activities afm_activities { get; set; }
        public virtual ICollection<helpdesk_sla_steps> helpdesk_sla_steps { get; set; }
        public virtual ICollection<helpdesk_step_log> helpdesk_step_log { get; set; }
    }
}
