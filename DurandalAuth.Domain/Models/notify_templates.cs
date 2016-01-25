using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class notify_templates
    {
        public notify_templates()
        {
            this.notifications = new List<notification>();
            this.regnotifies = new List<regnotify>();
        }

        public string activity_id { get; set; }
        public short alert_duration_days { get; set; }
        public string alert_duration_type { get; set; }
        public string description { get; set; }
        public string internal_code { get; set; }
        public string notify_cat { get; set; }
        public string notify_message_id { get; set; }
        public string notify_message_refby { get; set; }
        public string notify_recipients { get; set; }
        public string notify_recipients_grp { get; set; }
        public short notify_recurrence { get; set; }
        public string notify_subject { get; set; }
        public string notify_subject_id { get; set; }
        public string notify_subject_refby { get; set; }
        public string notify_type { get; set; }
        public short total_recurrence { get; set; }
        public string trigger_condition_from { get; set; }
        public string trigger_condition_to { get; set; }
        public string trigger_date_field { get; set; }
        public short trigger_lead { get; set; }
        public string trigger_lead_seq { get; set; }
        public string trigger_time_field { get; set; }
        public string view_url { get; set; }
        public string template_id { get; set; }
        public virtual afm_activities afm_activities { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual message message { get; set; }
        public virtual message message1 { get; set; }
        public virtual ICollection<notification> notifications { get; set; }
        public virtual notifycat notifycat { get; set; }
        public virtual ICollection<regnotify> regnotifies { get; set; }
    }
}
