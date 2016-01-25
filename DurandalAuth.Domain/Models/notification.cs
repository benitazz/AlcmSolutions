using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class notification
    {
        public Nullable<int> activity_log_id { get; set; }
        public Nullable<System.DateTime> date_notify { get; set; }
        public Nullable<System.DateTime> date_sent { get; set; }
        public short is_active { get; set; }
        public short notify_count { get; set; }
        public string notify_type { get; set; }
        public string status_previous { get; set; }
        public string template_id { get; set; }
        public Nullable<System.DateTime> time_notify { get; set; }
        public Nullable<System.DateTime> time_sent { get; set; }
        public string view_pkeys { get; set; }
        public string view_url { get; set; }
        public int notify_id { get; set; }
        public virtual activity_log activity_log { get; set; }
        public virtual notify_templates notify_templates { get; set; }
    }
}
