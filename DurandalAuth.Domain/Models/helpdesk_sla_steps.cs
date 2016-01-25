using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class helpdesk_sla_steps
    {
        public string cf_id { get; set; }
        public string condition { get; set; }
        public string em_id { get; set; }
        public short multiple_required { get; set; }
        public short notify_responsible { get; set; }
        public string role { get; set; }
        public string role_name { get; set; }
        public string step { get; set; }
        public string step_status { get; set; }
        public string step_type { get; set; }
        public string vn_id { get; set; }
        public string activity_id { get; set; }
        public string activity_type { get; set; }
        public int ordering_seq { get; set; }
        public short priority { get; set; }
        public string status { get; set; }
        public int step_order { get; set; }
        public virtual activitytype activitytype { get; set; }
        public virtual afm_activities afm_activities { get; set; }
        public virtual afm_roles afm_roles { get; set; }
        public virtual afm_wf_steps afm_wf_steps { get; set; }
        public virtual cf cf { get; set; }
        public virtual Em em { get; set; }
        public virtual helpdesk_sla_request helpdesk_sla_request { get; set; }
        public virtual helpdesk_sla_response helpdesk_sla_response { get; set; }
        public virtual vn vn { get; set; }
    }
}
