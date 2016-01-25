using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class helpdesk_sla_request
    {
        public helpdesk_sla_request()
        {
            this.helpdesk_sla_response = new List<helpdesk_sla_response>();
            this.helpdesk_sla_steps = new List<helpdesk_sla_steps>();
        }

        public string bl_id { get; set; }
        public Nullable<short> default_priority { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string em_std { get; set; }
        public string eq_id { get; set; }
        public string eq_std { get; set; }
        public string fl_id { get; set; }
        public int grouping { get; set; }
        public string pmp_id { get; set; }
        public string prob_type { get; set; }
        public string requestor { get; set; }
        public string rm_id { get; set; }
        public string site_id { get; set; }
        public string activity_type { get; set; }
        public int ordering_seq { get; set; }
        public virtual activitytype activitytype { get; set; }
        public virtual bl bl { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Em em { get; set; }
        public virtual emstd emstd { get; set; }
        public virtual eq eq { get; set; }
        public virtual eqstd eqstd { get; set; }
        public virtual Fl fl { get; set; }
        public virtual pmp pmp { get; set; }
        public virtual probtype probtype { get; set; }
        public virtual Rm rm { get; set; }
        public virtual site site { get; set; }
        public virtual ICollection<helpdesk_sla_response> helpdesk_sla_response { get; set; }
        public virtual ICollection<helpdesk_sla_steps> helpdesk_sla_steps { get; set; }
    }
}
