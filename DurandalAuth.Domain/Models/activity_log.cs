using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class activity_log
    {
        public activity_log()
        {
            this.actscns = new List<actscn>();
            this.cb_hcm_places = new List<cb_hcm_places>();
            this.cb_samples = new List<cb_samples>();
            this.cost_tran_sched = new List<cost_tran_sched>();
            this.docs_assigned = new List<docs_assigned>();
            this.ls_comm = new List<ls_comm>();
            this.moes = new List<mo>();
            this.notifications = new List<notification>();
            this.rmpcts = new List<rmpct>();
            this.rmpctmob_sync = new List<rmpctmob_sync>();
            this.wrs = new List<wr>();
            this.cb_hcm_loc_typ1 = new List<cb_hcm_loc_typ>();
        }

        public string activity_type { get; set; }
        public string approved_by { get; set; }
        public string assessed_by { get; set; }
        public Nullable<int> assessment_id { get; set; }
        public string assigned_to { get; set; }
        public short autocreate_wr { get; set; }
        public string bl_id { get; set; }
        public string capital_program { get; set; }
        public string cause_type { get; set; }
        public string cb_units_id { get; set; }
        public string cf_id { get; set; }
        public string comments { get; set; }
        public string completed_by { get; set; }
        public short cond_priority { get; set; }
        public short cond_value { get; set; }
        public string contact_id { get; set; }
        public Nullable<int> copied_from { get; set; }
        public decimal cost_act_cap { get; set; }
        public decimal cost_actual { get; set; }
        public string cost_cat_id { get; set; }
        public decimal cost_est_cap { get; set; }
        public decimal cost_est_design_cap { get; set; }
        public decimal cost_est_design_exp { get; set; }
        public decimal cost_estimated { get; set; }
        public decimal cost_to_replace { get; set; }
        public string created_by { get; set; }
        public string csi_id { get; set; }
        public Nullable<System.DateTime> date_approved { get; set; }
        public Nullable<System.DateTime> date_assessed { get; set; }
        public Nullable<System.DateTime> date_closed { get; set; }
        public Nullable<System.DateTime> date_completed { get; set; }
        public Nullable<System.DateTime> date_escalation_completion { get; set; }
        public Nullable<System.DateTime> date_escalation_response { get; set; }
        public Nullable<System.DateTime> date_installed { get; set; }
        public Nullable<System.DateTime> date_issued { get; set; }
        public Nullable<System.DateTime> date_planned_end { get; set; }
        public Nullable<System.DateTime> date_planned_for { get; set; }
        public System.DateTime date_requested { get; set; }
        public Nullable<System.DateTime> date_required { get; set; }
        public Nullable<System.DateTime> date_review { get; set; }
        public Nullable<System.DateTime> date_scheduled { get; set; }
        public Nullable<System.DateTime> date_scheduled_end { get; set; }
        public Nullable<System.DateTime> date_started { get; set; }
        public Nullable<System.DateTime> date_verified { get; set; }
        public string description { get; set; }
        public string dispatcher { get; set; }
        public string doc { get; set; }
        public string doc_file1 { get; set; }
        public string doc_file2 { get; set; }
        public string doc_file3 { get; set; }
        public string doc1 { get; set; }
        public string doc2 { get; set; }
        public string doc3 { get; set; }
        public string doc4 { get; set; }
        public string dp_id { get; set; }
        public int duration { get; set; }
        public short duration_act { get; set; }
        public short duration_est_baseline { get; set; }
        public string dv_id { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string eq_id { get; set; }
        public short escalated_completion { get; set; }
        public short escalated_response { get; set; }
        public string fl_id { get; set; }
        public string fund_id { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public string hcm_abate_by { get; set; }
        public string hcm_class1_id { get; set; }
        public string hcm_class2_id { get; set; }
        public string hcm_class3_id { get; set; }
        public string hcm_cond_id { get; set; }
        public string hcm_estimate_num { get; set; }
        public short hcm_fittings_num { get; set; }
        public string hcm_friable { get; set; }
        public string hcm_harea_id { get; set; }
        public string hcm_haz_rank_id { get; set; }
        public string hcm_haz_rating_id { get; set; }
        public string hcm_haz_status_id { get; set; }
        public string hcm_id { get; set; }
        public string hcm_is_hazard { get; set; }
        public short hcm_labeled { get; set; }
        public string hcm_loc_notes { get; set; }
        public string hcm_loc_typ_id { get; set; }
        public string hcm_pending_act { get; set; }
        public int hcm_pipe_cnt { get; set; }
        public decimal hcm_qty { get; set; }
        public int hours_actual { get; set; }
        public int hours_est_baseline { get; set; }
        public int hours_est_design { get; set; }
        public Nullable<int> incident_id { get; set; }
        public Nullable<decimal> lat { get; set; }
        public string location { get; set; }
        public Nullable<int> location_id { get; set; }
        public Nullable<decimal> lon { get; set; }
        public string ls_id { get; set; }
        public string manager { get; set; }
        public Nullable<int> mo_id { get; set; }
        public string op_id { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string owner_type { get; set; }
        public string parcel_id { get; set; }
        public short pct_complete { get; set; }
        public string phone_requestor { get; set; }
        public string pmp_id { get; set; }
        public Nullable<int> po_id { get; set; }
        public string pr_id { get; set; }
        public string predecessors { get; set; }
        public Nullable<short> priority { get; set; }
        public string prob_type { get; set; }
        public string proj_phase { get; set; }
        public string project_id { get; set; }
        public short qty_life_expct { get; set; }
        public string questionnaire_id { get; set; }
        public short rec_action { get; set; }
        public string recurring_rule { get; set; }
        public string reg_program { get; set; }
        public string reg_requirement { get; set; }
        public Nullable<int> regcomp_id { get; set; }
        public string regulation { get; set; }
        public Nullable<int> related_id { get; set; }
        public string repair_type { get; set; }
        public string requestor { get; set; }
        public string requestor_type { get; set; }
        public string resp_id { get; set; }
        public string rm_id { get; set; }
        public short satisfaction { get; set; }
        public string satisfaction_notes { get; set; }
        public string site_id { get; set; }
        public short start_offset { get; set; }
        public string status { get; set; }
        public string step_status { get; set; }
        public string supervisor { get; set; }
        public short sust_priority { get; set; }
        public Nullable<System.DateTime> time_escalation_completion { get; set; }
        public Nullable<System.DateTime> time_escalation_response { get; set; }
        public System.DateTime time_requested { get; set; }
        public Nullable<System.DateTime> time_required { get; set; }
        public string tr_id { get; set; }
        public string verified_by { get; set; }
        public string vn_id { get; set; }
        public string wbs_id { get; set; }
        public Nullable<int> wo_id { get; set; }
        public string work_pkg_id { get; set; }
        public string work_team_id { get; set; }
        public Nullable<int> wr_id { get; set; }
        public string ac_id { get; set; }
        public string act_quest { get; set; }
        public string action_title { get; set; }
        public int activity_log_id { get; set; }
        public virtual ac ac { get; set; }
        public virtual activitytype activitytype { get; set; }
        public virtual bl bl { get; set; }
        public virtual causetyp causetyp { get; set; }
        public virtual cb_units cb_units { get; set; }
        public virtual cf cf { get; set; }
        public virtual Contact contact { get; set; }
        public virtual cost_cat cost_cat { get; set; }
        public virtual csi csi { get; set; }
        public virtual Em em { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual eq eq { get; set; }
        public virtual Fl fl { get; set; }
        public virtual funding funding { get; set; }
        public virtual cb_accredit_person cb_accredit_person { get; set; }
        public virtual cb_hcm_class cb_hcm_class { get; set; }
        public virtual cb_hcm_class cb_hcm_class1 { get; set; }
        public virtual cb_hcm_class cb_hcm_class2 { get; set; }
        public virtual cb_hcm_cond cb_hcm_cond { get; set; }
        public virtual cb_hazard_rank cb_hazard_rank { get; set; }
        public virtual cb_hazard_rating cb_hazard_rating { get; set; }
        public virtual cb_hazard_status cb_hazard_status { get; set; }
        public virtual cb_hcm cb_hcm { get; set; }
        public virtual cb_hcm_loc_typ cb_hcm_loc_typ { get; set; }
        public virtual probtype probtype { get; set; }
        public virtual ehs_incidents ehs_incidents { get; set; }
        public virtual compliance_locations compliance_locations { get; set; }
        public virtual l l { get; set; }
        public virtual Em em1 { get; set; }
        public virtual op op { get; set; }
        public virtual parcel parcel { get; set; }
        public virtual pmp pmp { get; set; }
        public virtual po po { get; set; }
        public virtual Property property { get; set; }
        public virtual probtype probtype1 { get; set; }
        public virtual projphase projphase { get; set; }
        public virtual project project { get; set; }
        public virtual questionnaire questionnaire { get; set; }
        public virtual regprogram regprogram { get; set; }
        public virtual regrequirement regrequirement { get; set; }
        public virtual regcompliance regcompliance { get; set; }
        public virtual regulation regulation1 { get; set; }
        public virtual repairty repairty { get; set; }
        public virtual Em em2 { get; set; }
        public virtual ls_resp ls_resp { get; set; }
        public virtual Rm rm { get; set; }
        public virtual site site { get; set; }
        public virtual Em em3 { get; set; }
        public virtual tr tr { get; set; }
        public virtual vn vn { get; set; }
        public virtual wo wo { get; set; }
        public virtual work_pkgs work_pkgs { get; set; }
        public virtual work_team work_team { get; set; }
        public virtual ICollection<actscn> actscns { get; set; }
        public virtual ICollection<cb_hcm_places> cb_hcm_places { get; set; }
        public virtual ICollection<cb_samples> cb_samples { get; set; }
        public virtual ICollection<cost_tran_sched> cost_tran_sched { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
        public virtual ICollection<ls_comm> ls_comm { get; set; }
        public virtual ICollection<mo> moes { get; set; }
        public virtual ICollection<notification> notifications { get; set; }
        public virtual ICollection<rmpct> rmpcts { get; set; }
        public virtual ICollection<rmpctmob_sync> rmpctmob_sync { get; set; }
        public virtual ICollection<wr> wrs { get; set; }
        public virtual ICollection<cb_hcm_loc_typ> cb_hcm_loc_typ1 { get; set; }
    }
}
