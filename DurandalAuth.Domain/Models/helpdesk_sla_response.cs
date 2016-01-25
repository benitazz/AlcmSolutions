using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class helpdesk_sla_response
    {
        public helpdesk_sla_response()
        {
            this.helpdesk_sla_steps = new List<helpdesk_sla_steps>();
        }

        public short allow_work_on_holidays { get; set; }
        public short autoaccept { get; set; }
        public short autoapprove { get; set; }
        public short autocreate_wo { get; set; }
        public short autocreate_wr { get; set; }
        public short autodispatch { get; set; }
        public short autoissue { get; set; }
        public short autoschedule { get; set; }
        public string cf_id { get; set; }
        public Nullable<int> default_duration { get; set; }
        public string dispatcher { get; set; }
        public string em_id { get; set; }
        public string interval_to_complete { get; set; }
        public string interval_to_respond { get; set; }
        public string manager { get; set; }
        public short notify_craftsperson { get; set; }
        public short notify_requestor { get; set; }
        public short notify_service_provider { get; set; }
        public string priority_label { get; set; }
        public string priority_label_01 { get; set; }
        public string priority_label_02 { get; set; }
        public string priority_label_03 { get; set; }
        public string priority_label_ch { get; set; }
        public string priority_label_de { get; set; }
        public string priority_label_es { get; set; }
        public string priority_label_fr { get; set; }
        public string priority_label_it { get; set; }
        public string priority_label_jp { get; set; }
        public string priority_label_ko { get; set; }
        public string priority_label_nl { get; set; }
        public string priority_label_no { get; set; }
        public string priority_label_zh { get; set; }
        public string serv_window_days { get; set; }
        public Nullable<System.DateTime> serv_window_end { get; set; }
        public Nullable<System.DateTime> serv_window_start { get; set; }
        public string servcont_id { get; set; }
        public string service_name { get; set; }
        public short service_template { get; set; }
        public string status { get; set; }
        public string supervisor { get; set; }
        public Nullable<short> time_to_complete { get; set; }
        public Nullable<short> time_to_respond { get; set; }
        public string vn_id { get; set; }
        public string work_team_id { get; set; }
        public string workflow_name { get; set; }
        public short workflow_template { get; set; }
        public string activity_id { get; set; }
        public string activity_type { get; set; }
        public int ordering_seq { get; set; }
        public short priority { get; set; }
        public virtual activitytype activitytype { get; set; }
        public virtual cf cf { get; set; }
        public virtual Em em { get; set; }
        public virtual Em em1 { get; set; }
        public virtual Em em2 { get; set; }
        public virtual Em em3 { get; set; }
        public virtual helpdesk_sla_request helpdesk_sla_request { get; set; }
        public virtual servcont servcont { get; set; }
        public virtual vn vn { get; set; }
        public virtual work_team work_team { get; set; }
        public virtual ICollection<helpdesk_sla_steps> helpdesk_sla_steps { get; set; }
    }
}
