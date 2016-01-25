using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class bl
    {
        public bl()
        {
            this.activity_log = new List<activity_log>();
            this.bas_measurement_scope = new List<bas_measurement_scope>();
            this.bills = new List<bill>();
            this.bl_amenity = new List<bl_amenity>();
            this.blbus = new List<blbu>();
            this.budget_item = new List<budget_item>();
            this.cas = new List<ca>();
            this.cb_hcm_places = new List<cb_hcm_places>();
            this.ccost_sum = new List<ccost_sum>();
            this.combexts = new List<combext>();
            this.compliance_locations = new List<compliance_locations>();
            this.contacts = new List<Contact>();
            this.cost_tran_recur = new List<cost_tran_recur>();
            this.cost_tran_sched = new List<cost_tran_sched>();
            this.docs_assigned = new List<docs_assigned>();
            this.drs = new List<dr>();
            this.ehs_em_ppe_types = new List<ehs_em_ppe_types>();
            this.ehs_incidents = new List<ehs_incidents>();
            this.ehs_incidents_sync = new List<ehs_incidents_sync>();
            this.ems = new List<Em>();
            this.em_compinvtrial = new List<em_compinvtrial>();
            this.em_compinvtrial1 = new List<em_compinvtrial>();
            this.ems1 = new List<Em>();
            this.em_sync = new List<em_sync>();
            this.em_trial = new List<em_trial>();
            this.energy_bl_svc_period = new List<energy_bl_svc_period>();
            this.energy_chart_point = new List<energy_chart_point>();
            this.eqs = new List<eq>();
            this.eq_compinvtrial = new List<eq_compinvtrial>();
            this.eq_compinvtrial1 = new List<eq_compinvtrial>();
            this.eq_eqstdcnts = new List<eq_eqstdcnts>();
            this.eq_reserve = new List<eq_reserve>();
            this.eq_trial = new List<eq_trial>();
            this.fls = new List<Fl>();
            this.fns = new List<fn>();
            this.fn_compinvsur = new List<fn_compinvsur>();
            this.fn_fnstdcnts = new List<fn_fnstdcnts>();
            this.fn_trial = new List<fn_trial>();
            this.fps = new List<fp>();
            this.fs = new List<f>();
            this.gb_cert_docs = new List<gb_cert_docs>();
            this.gb_cert_log = new List<gb_cert_log>();
            this.gb_cert_proj = new List<gb_cert_proj>();
            this.gb_cert_scores = new List<gb_cert_scores>();
            this.gps = new List<gp>();
            this.grids = new List<grid>();
            this.gros = new List<gro>();
            this.helpdesk_sla_request = new List<helpdesk_sla_request>();
            this.invoices = new List<invoice>();
            this.jks = new List<jk>();
            this.ls = new List<l>();
            this.mo_churn = new List<mo_churn>();
            this.mo_eq = new List<mo_eq>();
            this.mo_fncount = new List<mo_fncount>();
            this.mo_ta = new List<mo_ta>();
            this.msds_location = new List<msds_location>();
            this.netdevs = new List<netdev>();
            this.ots = new List<ot>();
            this.parkings = new List<parking>();
            this.pbs = new List<pb>();
            this.pmgens = new List<pmgen>();
            this.pms = new List<Pm>();
            this.pns = new List<pn>();
            this.ports = new List<port>();
            this.projects = new List<project>();
            this.projteams = new List<ProjectTeam>();
            this.pts = new List<pt>();
            this.racks = new List<rack>();
            this.regcompliances = new List<regcompliance>();
            this.reserve_rm = new List<reserve_rm>();
            this.reserve_rs = new List<reserve_rs>();
            this.resources = new List<resource>();
            this.rf_activity = new List<rf_activity>();
            this.rfs = new List<Rf>();
            this.rf_reader = new List<rf_reader>();
            this.rm_amenity = new List<rm_amenity>();
            this.rm_arrange = new List<rm_arrange>();
            this.rms = new List<Rm>();
            this.rm_config = new List<rm_config>();
            this.rm_reserve = new List<rm_reserve>();
            this.rm_resource_std = new List<rm_resource_std>();
            this.rmpcts = new List<rmpct>();
            this.rmpctmob_sync = new List<rmpctmob_sync>();
            this.sb_items = new List<sb_items>();
            this.servs = new List<serv>();
            this.sus = new List<su>();
            this.surveyrm_sync = new List<surveyrm_sync>();
            this.system_bl = new List<system_bl>();
            this.ta_audit = new List<ta_audit>();
            this.tas = new List<ta>();
            this.ta_compinvtrial = new List<ta_compinvtrial>();
            this.ta_compinvtrial1 = new List<ta_compinvtrial>();
            this.ta_fnstdcnts = new List<ta_fnstdcnts>();
            this.ta_trial = new List<ta_trial>();
            this.tls = new List<tl>();
            this.verts = new List<vert>();
            this.visitors = new List<visitor>();
            this.vn_ac = new List<vn_ac>();
            this.waste_areas = new List<waste_areas>();
            this.waste_generators = new List<waste_generators>();
            this.weather_model = new List<weather_model>();
            this.wns = new List<wn>();
            this.woes = new List<wo>();
            this.work_roles_location = new List<work_roles_location>();
            this.wrs = new List<wr>();
            this.wies = new List<wy>();
            this.zones = new List<zone>();
        }

        public string ac_id { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public decimal area_avg_em { get; set; }
        public decimal area_avg_floor { get; set; }
        public decimal area_bl_comn_gp { get; set; }
        public decimal area_bl_comn_nocup { get; set; }
        public decimal area_bl_comn_ocup { get; set; }
        public decimal area_bl_comn_rm { get; set; }
        public decimal area_bl_comn_serv { get; set; }
        public decimal area_em_dp { get; set; }
        public decimal area_ext_wall { get; set; }
        public decimal area_gp { get; set; }
        public decimal area_gp_comn { get; set; }
        public decimal area_gp_dp { get; set; }
        public decimal area_gross_ext { get; set; }
        public decimal area_gross_int { get; set; }
        public decimal area_ls_negotiated { get; set; }
        public decimal area_nocup { get; set; }
        public decimal area_nocup_comn { get; set; }
        public decimal area_nocup_dp { get; set; }
        public decimal area_ocup { get; set; }
        public decimal area_ocup_comn { get; set; }
        public decimal area_ocup_dp { get; set; }
        public decimal area_remain { get; set; }
        public decimal area_rentable { get; set; }
        public decimal area_rm { get; set; }
        public decimal area_rm_comn { get; set; }
        public decimal area_rm_dp { get; set; }
        public decimal area_serv { get; set; }
        public decimal area_su { get; set; }
        public decimal area_usable { get; set; }
        public decimal area_vert_pen { get; set; }
        public short auto_est_balance_points { get; set; }
        public string bldg_photo { get; set; }
        public string campus { get; set; }
        public string campus_id { get; set; }
        public string city_id { get; set; }
        public string comments { get; set; }
        public string construction_type { get; set; }
        public string contact_name { get; set; }
        public string contact_phone { get; set; }
        public decimal cooling_balance_point { get; set; }
        public decimal cooling_balance_point_manual { get; set; }
        public decimal cost_operating_total { get; set; }
        public decimal cost_other_total { get; set; }
        public decimal cost_sqft { get; set; }
        public decimal cost_tax_total { get; set; }
        public decimal cost_utility_total { get; set; }
        public decimal count_em { get; set; }
        public int count_fl { get; set; }
        public int count_max_occup { get; set; }
        public int count_occup { get; set; }
        public string ctry_id { get; set; }
        public Nullable<System.DateTime> date_bl { get; set; }
        public Nullable<System.DateTime> date_book_val { get; set; }
        public Nullable<System.DateTime> date_costs_end { get; set; }
        public Nullable<System.DateTime> date_costs_last_calcd { get; set; }
        public Nullable<System.DateTime> date_costs_start { get; set; }
        public Nullable<System.DateTime> date_market_val { get; set; }
        public Nullable<System.DateTime> date_rehab { get; set; }
        public string detail_dwg { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string energy_baseline_year { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public string grp_uid { get; set; }
        public decimal heating_balance_point { get; set; }
        public decimal heating_balance_point_manual { get; set; }
        public string image_file { get; set; }
        public decimal income_total { get; set; }
        public Nullable<decimal> lat { get; set; }
        public Nullable<decimal> lon { get; set; }
        public string name { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string pr_id { get; set; }
        public decimal ratio_ru { get; set; }
        public decimal ratio_ur { get; set; }
        public string regn_id { get; set; }
        public string site_id { get; set; }
        public string state_id { get; set; }
        public decimal std_area_per_em { get; set; }
        public string use1 { get; set; }
        public string utility_type_cool { get; set; }
        public string utility_type_heat { get; set; }
        public decimal value_book { get; set; }
        public decimal value_market { get; set; }
        public string weather_source_id { get; set; }
        public string weather_station_id { get; set; }
        public string zip { get; set; }
        public string bl_id { get; set; }
        public virtual ac ac { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<bas_measurement_scope> bas_measurement_scope { get; set; }
        public virtual ICollection<bill> bills { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_type bill_type1 { get; set; }
        public virtual ICollection<bl_amenity> bl_amenity { get; set; }
        public virtual City city { get; set; }
        public virtual ctry ctry { get; set; }
        public virtual energy_time_period energy_time_period { get; set; }
        public virtual Property property { get; set; }
        public virtual regn regn { get; set; }
        public virtual site site { get; set; }
        public virtual state state { get; set; }
        public virtual weather_station_source weather_station_source { get; set; }
        public virtual weather_station weather_station { get; set; }
        public virtual ICollection<blbu> blbus { get; set; }
        public virtual ICollection<budget_item> budget_item { get; set; }
        public virtual ICollection<ca> cas { get; set; }
        public virtual ICollection<cb_hcm_places> cb_hcm_places { get; set; }
        public virtual ICollection<ccost_sum> ccost_sum { get; set; }
        public virtual ICollection<combext> combexts { get; set; }
        public virtual ICollection<compliance_locations> compliance_locations { get; set; }
        public virtual ICollection<Contact> contacts { get; set; }
        public virtual ICollection<cost_tran_recur> cost_tran_recur { get; set; }
        public virtual ICollection<cost_tran_sched> cost_tran_sched { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
        public virtual ICollection<dr> drs { get; set; }
        public virtual ICollection<ehs_em_ppe_types> ehs_em_ppe_types { get; set; }
        public virtual ICollection<ehs_incidents> ehs_incidents { get; set; }
        public virtual ICollection<ehs_incidents_sync> ehs_incidents_sync { get; set; }
        public virtual ICollection<Em> ems { get; set; }
        public virtual ICollection<em_compinvtrial> em_compinvtrial { get; set; }
        public virtual ICollection<em_compinvtrial> em_compinvtrial1 { get; set; }
        public virtual ICollection<Em> ems1 { get; set; }
        public virtual ICollection<em_sync> em_sync { get; set; }
        public virtual ICollection<em_trial> em_trial { get; set; }
        public virtual ICollection<energy_bl_svc_period> energy_bl_svc_period { get; set; }
        public virtual ICollection<energy_chart_point> energy_chart_point { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<eq_compinvtrial> eq_compinvtrial { get; set; }
        public virtual ICollection<eq_compinvtrial> eq_compinvtrial1 { get; set; }
        public virtual ICollection<eq_eqstdcnts> eq_eqstdcnts { get; set; }
        public virtual ICollection<eq_reserve> eq_reserve { get; set; }
        public virtual ICollection<eq_trial> eq_trial { get; set; }
        public virtual ICollection<Fl> fls { get; set; }
        public virtual ICollection<fn> fns { get; set; }
        public virtual ICollection<fn_compinvsur> fn_compinvsur { get; set; }
        public virtual ICollection<fn_fnstdcnts> fn_fnstdcnts { get; set; }
        public virtual ICollection<fn_trial> fn_trial { get; set; }
        public virtual ICollection<fp> fps { get; set; }
        public virtual ICollection<f> fs { get; set; }
        public virtual ICollection<gb_cert_docs> gb_cert_docs { get; set; }
        public virtual ICollection<gb_cert_log> gb_cert_log { get; set; }
        public virtual ICollection<gb_cert_proj> gb_cert_proj { get; set; }
        public virtual ICollection<gb_cert_scores> gb_cert_scores { get; set; }
        public virtual ICollection<gp> gps { get; set; }
        public virtual ICollection<grid> grids { get; set; }
        public virtual ICollection<gro> gros { get; set; }
        public virtual ICollection<helpdesk_sla_request> helpdesk_sla_request { get; set; }
        public virtual ICollection<invoice> invoices { get; set; }
        public virtual ICollection<jk> jks { get; set; }
        public virtual ICollection<l> ls { get; set; }
        public virtual ICollection<mo_churn> mo_churn { get; set; }
        public virtual ICollection<mo_eq> mo_eq { get; set; }
        public virtual ICollection<mo_fncount> mo_fncount { get; set; }
        public virtual ICollection<mo_ta> mo_ta { get; set; }
        public virtual ICollection<msds_location> msds_location { get; set; }
        public virtual ICollection<netdev> netdevs { get; set; }
        public virtual ICollection<ot> ots { get; set; }
        public virtual ICollection<parking> parkings { get; set; }
        public virtual ICollection<pb> pbs { get; set; }
        public virtual ICollection<pmgen> pmgens { get; set; }
        public virtual ICollection<Pm> pms { get; set; }
        public virtual ICollection<pn> pns { get; set; }
        public virtual ICollection<port> ports { get; set; }
        public virtual ICollection<project> projects { get; set; }
        public virtual ICollection<ProjectTeam> projteams { get; set; }
        public virtual ICollection<pt> pts { get; set; }
        public virtual ICollection<rack> racks { get; set; }
        public virtual ICollection<regcompliance> regcompliances { get; set; }
        public virtual ICollection<reserve_rm> reserve_rm { get; set; }
        public virtual ICollection<reserve_rs> reserve_rs { get; set; }
        public virtual ICollection<resource> resources { get; set; }
        public virtual ICollection<rf_activity> rf_activity { get; set; }
        public virtual ICollection<Rf> rfs { get; set; }
        public virtual ICollection<rf_reader> rf_reader { get; set; }
        public virtual ICollection<rm_amenity> rm_amenity { get; set; }
        public virtual ICollection<rm_arrange> rm_arrange { get; set; }
        public virtual ICollection<Rm> rms { get; set; }
        public virtual ICollection<rm_config> rm_config { get; set; }
        public virtual ICollection<rm_reserve> rm_reserve { get; set; }
        public virtual ICollection<rm_resource_std> rm_resource_std { get; set; }
        public virtual ICollection<rmpct> rmpcts { get; set; }
        public virtual ICollection<rmpctmob_sync> rmpctmob_sync { get; set; }
        public virtual ICollection<sb_items> sb_items { get; set; }
        public virtual ICollection<serv> servs { get; set; }
        public virtual ICollection<su> sus { get; set; }
        public virtual ICollection<surveyrm_sync> surveyrm_sync { get; set; }
        public virtual ICollection<system_bl> system_bl { get; set; }
        public virtual ICollection<ta_audit> ta_audit { get; set; }
        public virtual ICollection<ta> tas { get; set; }
        public virtual ICollection<ta_compinvtrial> ta_compinvtrial { get; set; }
        public virtual ICollection<ta_compinvtrial> ta_compinvtrial1 { get; set; }
        public virtual ICollection<ta_fnstdcnts> ta_fnstdcnts { get; set; }
        public virtual ICollection<ta_trial> ta_trial { get; set; }
        public virtual ICollection<tl> tls { get; set; }
        public virtual ICollection<vert> verts { get; set; }
        public virtual ICollection<visitor> visitors { get; set; }
        public virtual ICollection<vn_ac> vn_ac { get; set; }
        public virtual ICollection<waste_areas> waste_areas { get; set; }
        public virtual ICollection<waste_generators> waste_generators { get; set; }
        public virtual ICollection<weather_model> weather_model { get; set; }
        public virtual ICollection<wn> wns { get; set; }
        public virtual ICollection<wo> woes { get; set; }
        public virtual ICollection<work_roles_location> work_roles_location { get; set; }
        public virtual ICollection<wr> wrs { get; set; }
        public virtual ICollection<wy> wies { get; set; }
        public virtual ICollection<zone> zones { get; set; }
    }
}
