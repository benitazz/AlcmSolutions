using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_activities
    {
        public afm_activities()
        {
            this.afm_act_tbls = new List<afm_act_tbls>();
            this.afm_activity_params = new List<afm_activity_params>();
            this.afm_actprods = new List<afm_actprods>();
            this.afm_notifications_log = new List<afm_notifications_log>();
            this.afm_processes = new List<afm_processes>();
            this.afm_psubtasks = new List<afm_psubtasks>();
            this.afm_ptasks = new List<afm_ptasks>();
            this.afm_roleprocs = new List<afm_roleprocs>();
            this.afm_userprocs = new List<afm_userprocs>();
            this.afm_wf_rules = new List<afm_wf_rules>();
            this.afm_wf_steps = new List<afm_wf_steps>();
            this.hazard_container_cat = new List<hazard_container_cat>();
            this.helpdesk_sla_steps = new List<helpdesk_sla_steps>();
            this.helpdesk_step_log = new List<helpdesk_step_log>();
            this.messages = new List<message>();
            this.notify_templates = new List<notify_templates>();
            this.notifycats = new List<notifycat>();
        }

        public string adn_link { get; set; }
        public string adn_mfr { get; set; }
        public string adn_phone { get; set; }
        public string comments { get; set; }
        public Nullable<short> display_order { get; set; }
        public string help_link { get; set; }
        public string help_system { get; set; }
        public string icon_large { get; set; }
        public string icon_small { get; set; }
        public Nullable<int> internal_use1 { get; set; }
        public Nullable<short> is_active { get; set; }
        public Nullable<short> revision { get; set; }
        public string subfolder { get; set; }
        public string summary { get; set; }
        public string summary_01 { get; set; }
        public string summary_02 { get; set; }
        public string summary_03 { get; set; }
        public string summary_ch { get; set; }
        public string summary_de { get; set; }
        public string summary_es { get; set; }
        public string summary_fr { get; set; }
        public string summary_it { get; set; }
        public string summary_jp { get; set; }
        public string summary_ko { get; set; }
        public string summary_nl { get; set; }
        public string summary_no { get; set; }
        public string summary_zh { get; set; }
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
        public string transfer_status { get; set; }
        public short version { get; set; }
        public string workflow_assignee_field { get; set; }
        public string workflow_status_field { get; set; }
        public string workflow_statusmanager { get; set; }
        public string workflow_step_status_field { get; set; }
        public string workflow_stepmanager { get; set; }
        public string workflow_table { get; set; }
        public string activity_id { get; set; }
        public virtual ICollection<afm_act_tbls> afm_act_tbls { get; set; }
        public virtual afm_flds afm_flds { get; set; }
        public virtual afm_flds afm_flds1 { get; set; }
        public virtual afm_flds afm_flds2 { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
        public virtual ICollection<afm_activity_params> afm_activity_params { get; set; }
        public virtual ICollection<afm_actprods> afm_actprods { get; set; }
        public virtual ICollection<afm_notifications_log> afm_notifications_log { get; set; }
        public virtual ICollection<afm_processes> afm_processes { get; set; }
        public virtual ICollection<afm_psubtasks> afm_psubtasks { get; set; }
        public virtual ICollection<afm_ptasks> afm_ptasks { get; set; }
        public virtual ICollection<afm_roleprocs> afm_roleprocs { get; set; }
        public virtual ICollection<afm_userprocs> afm_userprocs { get; set; }
        public virtual ICollection<afm_wf_rules> afm_wf_rules { get; set; }
        public virtual ICollection<afm_wf_steps> afm_wf_steps { get; set; }
        public virtual ICollection<hazard_container_cat> hazard_container_cat { get; set; }
        public virtual ICollection<helpdesk_sla_steps> helpdesk_sla_steps { get; set; }
        public virtual ICollection<helpdesk_step_log> helpdesk_step_log { get; set; }
        public virtual ICollection<message> messages { get; set; }
        public virtual ICollection<notify_templates> notify_templates { get; set; }
        public virtual ICollection<notifycat> notifycats { get; set; }
    }
}
