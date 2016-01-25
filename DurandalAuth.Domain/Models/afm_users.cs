using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_users
    {
        public afm_users()
        {
            this.afm_docs = new List<afm_docs>();
            this.afm_docvers = new List<afm_docvers>();
            this.afm_psubtasks = new List<afm_psubtasks>();
            this.afm_ptasks = new List<afm_ptasks>();
            this.afm_redlines = new List<afm_redlines>();
            this.afm_userprocs = new List<afm_userprocs>();
            this.ccost_sum = new List<ccost_sum>();
            this.grps = new List<grp>();
            this.grp_trans = new List<grp_trans>();
            this.grp_trans1 = new List<grp_trans>();
            this.helpdesk_step_log = new List<helpdesk_step_log>();
            this.ls_comm_log = new List<ls_comm_log>();
            this.resources = new List<resource>();
            this.rm_arrange = new List<rm_arrange>();
        }

        public string bim_license { get; set; }
        public string bl_id_list { get; set; }
        public string clr_scheme { get; set; }
        public System.DateTime date_pwd_changed { get; set; }
        public string display_units { get; set; }
        public string email { get; set; }
        public string group_1 { get; set; }
        public string group_10 { get; set; }
        public string group_2 { get; set; }
        public string group_3 { get; set; }
        public string group_4 { get; set; }
        public string group_5 { get; set; }
        public string group_6 { get; set; }
        public string group_7 { get; set; }
        public string group_8 { get; set; }
        public string group_9 { get; set; }
        public string home_page { get; set; }
        public int is_named_user { get; set; }
        public string locale { get; set; }
        public short mob_device_enabled { get; set; }
        public string mob_device_id { get; set; }
        public short num_retries { get; set; }
        public string preferences { get; set; }
        public string role_name { get; set; }
        public string site_id_list { get; set; }
        public string sql_pwd { get; set; }
        public string sql_uid { get; set; }
        public string transfer_status { get; set; }
        public Nullable<short> user_level { get; set; }
        public string user_pwd { get; set; }
        public string vpa_option1 { get; set; }
        public string vpa_option2 { get; set; }
        public string vpa_option3 { get; set; }
        public string vpa_option4 { get; set; }
        public string user_name { get; set; }
        public virtual ICollection<afm_docs> afm_docs { get; set; }
        public virtual ICollection<afm_docvers> afm_docvers { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual afm_groups afm_groups1 { get; set; }
        public virtual afm_groups afm_groups2 { get; set; }
        public virtual afm_groups afm_groups3 { get; set; }
        public virtual afm_groups afm_groups4 { get; set; }
        public virtual afm_groups afm_groups5 { get; set; }
        public virtual afm_groups afm_groups6 { get; set; }
        public virtual afm_groups afm_groups7 { get; set; }
        public virtual afm_groups afm_groups8 { get; set; }
        public virtual afm_groups afm_groups9 { get; set; }
        public virtual ICollection<afm_psubtasks> afm_psubtasks { get; set; }
        public virtual ICollection<afm_ptasks> afm_ptasks { get; set; }
        public virtual ICollection<afm_redlines> afm_redlines { get; set; }
        public virtual afm_roles afm_roles { get; set; }
        public virtual ICollection<afm_userprocs> afm_userprocs { get; set; }
        public virtual ICollection<ccost_sum> ccost_sum { get; set; }
        public virtual ICollection<grp> grps { get; set; }
        public virtual ICollection<grp_trans> grp_trans { get; set; }
        public virtual ICollection<grp_trans> grp_trans1 { get; set; }
        public virtual ICollection<helpdesk_step_log> helpdesk_step_log { get; set; }
        public virtual ICollection<ls_comm_log> ls_comm_log { get; set; }
        public virtual ICollection<resource> resources { get; set; }
        public virtual ICollection<rm_arrange> rm_arrange { get; set; }
    }
}
