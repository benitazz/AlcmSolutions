using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ls_alert_definition
    {
        public short issue_alert { get; set; }
        public short notification_days { get; set; }
        public short removal_days { get; set; }
        public short send_email { get; set; }
        public string alert_type { get; set; }
        public string role_name { get; set; }
        public string color { get; set; }
        public virtual afm_roles afm_roles { get; set; }
    }
}
