using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_roles
    {
        public afm_roles()
        {
            this.afm_groupsforroles = new List<afm_groupsforroles>();
            this.afm_roleprocs = new List<afm_roleprocs>();
            this.afm_users = new List<afm_users>();
            this.helpdesk_sla_steps = new List<helpdesk_sla_steps>();
            this.helpdesk_step_log = new List<helpdesk_step_log>();
            this.ls_alert_definition = new List<ls_alert_definition>();
        }

        public string role_title { get; set; }
        public string sql_pwd { get; set; }
        public string sql_uid { get; set; }
        public string transfer_status { get; set; }
        public string vpa_restriction { get; set; }
        public string ww_preferences { get; set; }
        public string license_level { get; set; }
        public string preferences { get; set; }
        public string role_name { get; set; }
        public virtual ICollection<afm_groupsforroles> afm_groupsforroles { get; set; }
        public virtual ICollection<afm_roleprocs> afm_roleprocs { get; set; }
        public virtual ICollection<afm_users> afm_users { get; set; }
        public virtual ICollection<helpdesk_sla_steps> helpdesk_sla_steps { get; set; }
        public virtual ICollection<helpdesk_step_log> helpdesk_step_log { get; set; }
        public virtual ICollection<ls_alert_definition> ls_alert_definition { get; set; }
    }
}
