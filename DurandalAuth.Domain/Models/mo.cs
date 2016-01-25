using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class mo
    {
        public mo()
        {
            this.em_compinvtrial = new List<em_compinvtrial>();
            this.eq_compinvtrial = new List<eq_compinvtrial>();
            this.mo_eq = new List<mo_eq>();
            this.mo_fncount = new List<mo_fncount>();
            this.mo_ta = new List<mo_ta>();
            this.rmpcts = new List<rmpct>();
            this.ta_compinvtrial = new List<ta_compinvtrial>();
        }

        public string ac_id { get; set; }
        public Nullable<int> activity_log_id { get; set; }
        public string apprv_mgr1 { get; set; }
        public string apprv_mgr1_status { get; set; }
        public string apprv_mgr2 { get; set; }
        public string apprv_mgr2_status { get; set; }
        public string apprv_mgr3 { get; set; }
        public string apprv_mgr3_status { get; set; }
        public string comments { get; set; }
        public decimal cost_actual { get; set; }
        public decimal cost_est { get; set; }
        public decimal cost_moving_eq { get; set; }
        public decimal cost_moving_fn { get; set; }
        public decimal cost_moving_other { get; set; }
        public decimal cost_moving_ta { get; set; }
        public decimal cost_moving_total { get; set; }
        public Nullable<System.DateTime> date_app_mgr1 { get; set; }
        public Nullable<System.DateTime> date_app_mgr2 { get; set; }
        public Nullable<System.DateTime> date_app_mgr3 { get; set; }
        public Nullable<System.DateTime> date_approved { get; set; }
        public Nullable<System.DateTime> date_closed { get; set; }
        public Nullable<System.DateTime> date_completed { get; set; }
        public System.DateTime date_created { get; set; }
        public Nullable<System.DateTime> date_end_req { get; set; }
        public Nullable<System.DateTime> date_issued { get; set; }
        public System.DateTime date_requested { get; set; }
        public Nullable<System.DateTime> date_start_req { get; set; }
        public Nullable<System.DateTime> date_to_perform { get; set; }
        public string dept_contact { get; set; }
        public string description { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string em_id { get; set; }
        public string em_new_fp_id { get; set; }
        public string em_new_jacks { get; set; }
        public string from_bl_id { get; set; }
        public string from_comp_type { get; set; }
        public string from_dp_id { get; set; }
        public string from_dv_id { get; set; }
        public string from_fax { get; set; }
        public string from_fl_id { get; set; }
        public string from_jk_id_data { get; set; }
        public string from_jk_id_voice { get; set; }
        public string from_mailstop { get; set; }
        public string from_phone { get; set; }
        public string from_phone_type { get; set; }
        public string from_rm_id { get; set; }
        public decimal hours_actual { get; set; }
        public decimal hours_est { get; set; }
        public string mo_class { get; set; }
        public string mo_coord { get; set; }
        public string mo_quest { get; set; }
        public string mo_type { get; set; }
        public short move_cancelled { get; set; }
        public string mp_id { get; set; }
        public int num_boxes { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string phone { get; set; }
        public string phone_dept_contact { get; set; }
        public Nullable<short> priority { get; set; }
        public string project_id { get; set; }
        public string requestor { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> time_completed { get; set; }
        public Nullable<System.DateTime> time_issued { get; set; }
        public System.DateTime time_requested { get; set; }
        public Nullable<System.DateTime> time_to_perform { get; set; }
        public string to_bl_id { get; set; }
        public string to_comp_type { get; set; }
        public string to_dp_id { get; set; }
        public string to_dv_id { get; set; }
        public string to_fax { get; set; }
        public string to_fl_id { get; set; }
        public short to_hotel { get; set; }
        public string to_jk_id_data { get; set; }
        public string to_jk_id_voice { get; set; }
        public string to_location { get; set; }
        public string to_mailstop { get; set; }
        public string to_phone { get; set; }
        public string to_phone_type { get; set; }
        public string to_rm_id { get; set; }
        public int mo_id { get; set; }
        public virtual ac ac { get; set; }
        public virtual activity_log activity_log { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Em em { get; set; }
        public virtual Em em1 { get; set; }
        public virtual Em em2 { get; set; }
        public virtual Em em3 { get; set; }
        public virtual Em em4 { get; set; }
        public virtual Em em5 { get; set; }
        public virtual ICollection<em_compinvtrial> em_compinvtrial { get; set; }
        public virtual ICollection<eq_compinvtrial> eq_compinvtrial { get; set; }
        public virtual fp fp { get; set; }
        public virtual ICollection<mo_eq> mo_eq { get; set; }
        public virtual ICollection<mo_fncount> mo_fncount { get; set; }
        public virtual mp mp { get; set; }
        public virtual project project { get; set; }
        public virtual ICollection<mo_ta> mo_ta { get; set; }
        public virtual ICollection<rmpct> rmpcts { get; set; }
        public virtual ICollection<ta_compinvtrial> ta_compinvtrial { get; set; }
    }
}
