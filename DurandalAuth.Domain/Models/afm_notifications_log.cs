using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_notifications_log
    {
        public string email_from { get; set; }
        public string email_host { get; set; }
        public string email_message { get; set; }
        public string email_subject { get; set; }
        public string email_to { get; set; }
        public System.DateTime server_date_sent { get; set; }
        public System.DateTime server_time_sent { get; set; }
        public string status { get; set; }
        public string status_message { get; set; }
        public string activity_id { get; set; }
        public int auto_number { get; set; }
        public virtual afm_activities afm_activities { get; set; }
    }
}
