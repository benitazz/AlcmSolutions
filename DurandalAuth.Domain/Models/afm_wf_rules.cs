using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_wf_rules
    {
        public string description { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string group_name { get; set; }
        public short is_active { get; set; }
        public string rule_type { get; set; }
        public string transfer_status { get; set; }
        public string xml_rule_props { get; set; }
        public string xml_sched_props { get; set; }
        public string activity_id { get; set; }
        public string rule_id { get; set; }
        public virtual afm_activities afm_activities { get; set; }
        public virtual afm_groups afm_groups { get; set; }
    }
}
