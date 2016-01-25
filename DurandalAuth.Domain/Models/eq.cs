using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class eq
    {
        public eq()
        {
            this.activity_log = new List<activity_log>();
            this.bas_data_point = new List<bas_data_point>();
            this.bas_measurement_scope = new List<bas_measurement_scope>();
            this.cards = new List<card>();
            this.compliance_locations = new List<compliance_locations>();
            this.ehs_incidents = new List<ehs_incidents>();
            this.eps = new List<ep>();
            this.eq_compinvtrial = new List<eq_compinvtrial>();
            this.eq_dep = new List<eq_dep>();
            this.eq_reserve = new List<eq_reserve>();
            this.eq_sched = new List<eq_sched>();
            this.eq_trial = new List<eq_trial>();
            this.eqports = new List<eqport>();
            this.eqprphs = new List<eqprph>();
            this.helpdesk_sla_request = new List<helpdesk_sla_request>();
            this.mo_eq = new List<mo_eq>();
            this.msds_location = new List<msds_location>();
            this.pms = new List<Pm>();
            this.resources = new List<resource>();
            this.rm_resource_std = new List<rm_resource_std>();
            this.softinvs = new List<softinv>();
            this.vn_ac = new List<vn_ac>();
            this.wrs = new List<wr>();
        }

        public string eq_std { get; set; }
        public string fl_id { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public string grp_uid { get; set; }
        public string hardware_address { get; set; }
        public string image_eq_assy { get; set; }
        public string image_eq_elec { get; set; }
        public string image_eq_lub { get; set; }
        public string image_spec { get; set; }
        public short is_multiplexing { get; set; }
        public Nullable<decimal> lat { get; set; }
        public string layer_name { get; set; }
        public decimal limit_alarm_high { get; set; }
        public decimal limit_alarm_low { get; set; }
        public decimal limit_ctl_high { get; set; }
        public decimal limit_ctl_low { get; set; }
        public string loc_bay { get; set; }
        public string loc_column { get; set; }
        public string loc_maint_manl { get; set; }
        public short locked_out { get; set; }
        public Nullable<decimal> lon { get; set; }
        public decimal meter { get; set; }
        public Nullable<System.DateTime> meter_last_read { get; set; }
        public string meter_units { get; set; }
        public decimal meter_usage_per_day { get; set; }
        public string mfr { get; set; }
        public string modelno { get; set; }
        public string net_address { get; set; }
        public string net_address_ip { get; set; }
        public string net_card_type { get; set; }
        public string net_id { get; set; }
        public string net_node_name { get; set; }
        public string net_sub_mask { get; set; }
        public string num_lease { get; set; }
        public string num_po { get; set; }
        public string num_serial { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string os_type { get; set; }
        public Nullable<int> po_id { get; set; }
        public Nullable<int> po_line_id { get; set; }
        public string policy_id { get; set; }
        public string pr_id { get; set; }
        public string property_type { get; set; }
        public decimal qty_dep_period { get; set; }
        public decimal qty_hrs_run_day { get; set; }
        public short qty_life_expct { get; set; }
        public decimal qty_MTBF { get; set; }
        public decimal qty_MTTR { get; set; }
        public short qty_pms { get; set; }
        public string rack_id { get; set; }
        public string recovery_status { get; set; }
        public string rf_id { get; set; }
        public string rm_id { get; set; }
        public short salvaged { get; set; }
        public string servcont_id { get; set; }
        public string site_id { get; set; }
        public string status { get; set; }
        public string subcomponent_of { get; set; }
        public string survey_comments { get; set; }
        public string survey_id { get; set; }
        public string survey_photo_eq { get; set; }
        public string survey_redline_eq { get; set; }
        public string ta_lease_id { get; set; }
        public short tagged_out { get; set; }
        public string tc_area_level { get; set; }
        public string tc_client_server { get; set; }
        public string tc_level { get; set; }
        public string tc_service { get; set; }
        public string use1 { get; set; }
        public decimal value_salvage { get; set; }
        public string vn_id { get; set; }
        public string warranty_id { get; set; }
        public string asset_id { get; set; }
        public string bl_id { get; set; }
        public string comments { get; set; }
        public string condition { get; set; }
        public decimal cost_dep_value { get; set; }
        public decimal cost_purchase { get; set; }
        public decimal cost_replace { get; set; }
        public short criticality { get; set; }
        public string csi_id { get; set; }
        public string curr_bl_id { get; set; }
        public string curr_fl_id { get; set; }
        public string curr_rm_id { get; set; }
        public string curr_site_id { get; set; }
        public Nullable<System.DateTime> date_in_repair { get; set; }
        public Nullable<System.DateTime> date_in_service { get; set; }
        public Nullable<System.DateTime> date_in_storage { get; set; }
        public Nullable<System.DateTime> date_installed { get; set; }
        public Nullable<System.DateTime> date_last_surveyed { get; set; }
        public Nullable<System.DateTime> date_manufactured { get; set; }
        public Nullable<System.DateTime> date_of_stat_chg { get; set; }
        public Nullable<System.DateTime> date_purchased { get; set; }
        public Nullable<System.DateTime> date_salvaged { get; set; }
        public Nullable<System.DateTime> date_sold { get; set; }
        public string doc_eop { get; set; }
        public string doc_loto { get; set; }
        public string doc_mop { get; set; }
        public string doc_other { get; set; }
        public string doc_sop { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string em_id { get; set; }
        public string eq_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual ICollection<bas_data_point> bas_data_point { get; set; }
        public virtual ICollection<bas_measurement_scope> bas_measurement_scope { get; set; }
        public virtual bl bl { get; set; }
        public virtual ICollection<card> cards { get; set; }
        public virtual ICollection<compliance_locations> compliance_locations { get; set; }
        public virtual csi csi { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual ICollection<ehs_incidents> ehs_incidents { get; set; }
        public virtual Em em { get; set; }
        public virtual ICollection<ep> eps { get; set; }
        public virtual eq_bar_code_list eq_bar_code_list { get; set; }
        public virtual ICollection<eq_compinvtrial> eq_compinvtrial { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Rm rm { get; set; }
        public virtual ICollection<eq_dep> eq_dep { get; set; }
        public virtual eqstd eqstd { get; set; }
        public virtual Fl fl1 { get; set; }
        public virtual net net { get; set; }
        public virtual po po { get; set; }
        public virtual po_line po_line { get; set; }
        public virtual policy policy { get; set; }
        public virtual Property property { get; set; }
        public virtual property_type property_type1 { get; set; }
        public virtual rack rack { get; set; }
        public virtual ICollection<eq_reserve> eq_reserve { get; set; }
        public virtual Rm rm1 { get; set; }
        public virtual ICollection<eq_sched> eq_sched { get; set; }
        public virtual servcont servcont { get; set; }
        public virtual site site { get; set; }
        public virtual survey survey { get; set; }
        public virtual ta_lease ta_lease { get; set; }
        public virtual ICollection<eq_trial> eq_trial { get; set; }
        public virtual vn vn { get; set; }
        public virtual warranty warranty { get; set; }
        public virtual ICollection<eqport> eqports { get; set; }
        public virtual ICollection<eqprph> eqprphs { get; set; }
        public virtual ICollection<helpdesk_sla_request> helpdesk_sla_request { get; set; }
        public virtual ICollection<mo_eq> mo_eq { get; set; }
        public virtual ICollection<msds_location> msds_location { get; set; }
        public virtual ICollection<Pm> pms { get; set; }
        public virtual ICollection<resource> resources { get; set; }
        public virtual ICollection<rm_resource_std> rm_resource_std { get; set; }
        public virtual ICollection<softinv> softinvs { get; set; }
        public virtual ICollection<vn_ac> vn_ac { get; set; }
        public virtual ICollection<wr> wrs { get; set; }
    }
}
