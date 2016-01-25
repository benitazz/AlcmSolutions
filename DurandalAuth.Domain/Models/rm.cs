#region

using System;
using System.Collections.Generic;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The rm.
    /// </summary>
    public class Rm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rm"/> class.
        /// </summary>
        public Rm()
        {
            this.activity_log = new List<activity_log>();
            this.bas_measurement_scope = new List<bas_measurement_scope>();
            this.cas = new List<ca>();
            this.cb_hcm_places = new List<cb_hcm_places>();
            this.combexts = new List<combext>();
            this.compliance_locations = new List<compliance_locations>();
            this.ehs_em_ppe_types = new List<ehs_em_ppe_types>();
            this.ehs_incidents = new List<ehs_incidents>();
            this.ehs_incidents_sync = new List<ehs_incidents_sync>();
            this.ems = new List<Em>();
            this.ems1 = new List<Em>();
            this.ems2 = new List<Em>();
            this.em_compinvtrial = new List<em_compinvtrial>();
            this.em_compinvtrial1 = new List<em_compinvtrial>();
            this.em_sync = new List<em_sync>();
            this.em_trial = new List<em_trial>();
            this.eqs = new List<eq>();
            this.eqs1 = new List<eq>();
            this.eq_compinvtrial = new List<eq_compinvtrial>();
            this.eq_compinvtrial1 = new List<eq_compinvtrial>();
            this.eq_eqstdcnts = new List<eq_eqstdcnts>();
            this.eq_reserve = new List<eq_reserve>();
            this.eq_trial = new List<eq_trial>();
            this.fns = new List<fn>();
            this.fn_compinvsur = new List<fn_compinvsur>();
            this.fn_fnstdcnts = new List<fn_fnstdcnts>();
            this.fn_trial = new List<fn_trial>();
            this.fps = new List<fp>();
            this.fs = new List<f>();
            this.helpdesk_sla_request = new List<helpdesk_sla_request>();
            this.jks = new List<jk>();
            this.mo_eq = new List<mo_eq>();
            this.mo_fncount = new List<mo_fncount>();
            this.mo_ta = new List<mo_ta>();
            this.msds_location = new List<msds_location>();
            this.netdevs = new List<netdev>();
            this.pbs = new List<pb>();
            this.pms = new List<Pm>();
            this.pns = new List<pn>();
            this.ports = new List<port>();
            this.pts = new List<pt>();
            this.racks = new List<rack>();
            this.regcompliances = new List<regcompliance>();
            this.reserve_rm = new List<reserve_rm>();
            this.reserve_rs = new List<reserve_rs>();
            this.rfs = new List<Rf>();
            this.rf_activity = new List<rf_activity>();
            this.rf_reader = new List<rf_reader>();
            this.rf_reader1 = new List<rf_reader>();
            this.rm_amenity = new List<rm_amenity>();
            this.rm_arrange = new List<rm_arrange>();
            this.rm_config = new List<rm_config>();
            this.rm_reserve = new List<rm_reserve>();
            this.rm_resource_std = new List<rm_resource_std>();
            this.rmpcts = new List<rmpct>();
            this.rmpctmob_sync = new List<rmpctmob_sync>();
            this.ta_audit = new List<ta_audit>();
            this.ta_compinvtrial = new List<ta_compinvtrial>();
            this.ta_compinvtrial1 = new List<ta_compinvtrial>();
            this.tas = new List<ta>();
            this.ta_fnstdcnts = new List<ta_fnstdcnts>();
            this.tas1 = new List<ta>();
            this.ta_trial = new List<ta_trial>();
            this.tls = new List<tl>();
            this.visitors = new List<visitor>();
            this.waste_areas = new List<waste_areas>();
            this.waste_generators = new List<waste_generators>();
            this.wrs = new List<wr>();
            this.wies = new List<wy>();
        }

        /// <summary>
        /// Gets or sets the area.
        /// </summary>
        public decimal area { get; set; }

        /// <summary>
        /// Gets or sets the area_alloc.
        /// </summary>
        public decimal area_alloc { get; set; }

        /// <summary>
        /// Gets or sets the area_chargable.
        /// </summary>
        public decimal area_chargable { get; set; }

        /// <summary>
        /// Gets or sets the area_comn.
        /// </summary>
        public decimal area_comn { get; set; }

        /// <summary>
        /// Gets or sets the area_comn_nocup.
        /// </summary>
        public decimal area_comn_nocup { get; set; }

        /// <summary>
        /// Gets or sets the area_comn_ocup.
        /// </summary>
        public decimal area_comn_ocup { get; set; }

        /// <summary>
        /// Gets or sets the area_comn_rm.
        /// </summary>
        public decimal area_comn_rm { get; set; }

        /// <summary>
        /// Gets or sets the area_comn_serv.
        /// </summary>
        public decimal area_comn_serv { get; set; }

        /// <summary>
        /// Gets or sets the area_manual.
        /// </summary>
        public decimal area_manual { get; set; }

        /// <summary>
        /// Gets or sets the area_unalloc.
        /// </summary>
        public decimal area_unalloc { get; set; }

        /// <summary>
        /// Gets or sets the cap_em.
        /// </summary>
        public short cap_em { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        public decimal cost { get; set; }

        /// <summary>
        /// Gets or sets the cost_sqft.
        /// </summary>
        public decimal cost_sqft { get; set; }

        /// <summary>
        /// Gets or sets the count_em.
        /// </summary>
        public decimal count_em { get; set; }

        /// <summary>
        /// Gets or sets the date_last_surveyed.
        /// </summary>
        public DateTime? date_last_surveyed { get; set; }

        /// <summary>
        /// Gets or sets the dp_id.
        /// </summary>
        public string dp_id { get; set; }

        /// <summary>
        /// Gets or sets the dv_id.
        /// </summary>
        public string dv_id { get; set; }

        /// <summary>
        /// Gets or sets the dwgname.
        /// </summary>
        public string dwgname { get; set; }

        /// <summary>
        /// Gets or sets the ehandle.
        /// </summary>
        public string ehandle { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        public string extension { get; set; }

        /// <summary>
        /// Gets or sets the geo_objectid.
        /// </summary>
        public int? geo_objectid { get; set; }

        /// <summary>
        /// Gets or sets the hotelable.
        /// </summary>
        public short hotelable { get; set; }

        /// <summary>
        /// Gets or sets the lat.
        /// </summary>
        public decimal? lat { get; set; }

        /// <summary>
        /// Gets or sets the layer_name.
        /// </summary>
        public string layer_name { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        public decimal length { get; set; }

        /// <summary>
        /// Gets or sets the lon.
        /// </summary>
        public decimal? lon { get; set; }

        /// <summary>
        /// Gets or sets the ls_id.
        /// </summary>
        public string ls_id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the option 1.
        /// </summary>
        public string option1 { get; set; }

        /// <summary>
        /// Gets or sets the option 2.
        /// </summary>
        public string option2 { get; set; }

        /// <summary>
        /// Gets or sets the org_id.
        /// </summary>
        public string org_id { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// Gets or sets the prorate.
        /// </summary>
        public string prorate { get; set; }

        /// <summary>
        /// Gets or sets the recovery_status.
        /// </summary>
        public string recovery_status { get; set; }

        /// <summary>
        /// Gets or sets the reservable.
        /// </summary>
        public short reservable { get; set; }

        /// <summary>
        /// Gets or sets the rm_cat.
        /// </summary>
        public string rm_cat { get; set; }

        /// <summary>
        /// Gets or sets the rm_std.
        /// </summary>
        public string rm_std { get; set; }

        /// <summary>
        /// Gets or sets the rm_type.
        /// </summary>
        public string rm_type { get; set; }

        /// <summary>
        /// Gets or sets the rm_use.
        /// </summary>
        public string rm_use { get; set; }

        /// <summary>
        /// Gets or sets the survey_comments_rm.
        /// </summary>
        public string survey_comments_rm { get; set; }

        /// <summary>
        /// Gets or sets the survey_photo.
        /// </summary>
        public string survey_photo { get; set; }

        /// <summary>
        /// Gets or sets the survey_redline_rm.
        /// </summary>
        public string survey_redline_rm { get; set; }

        /// <summary>
        /// Gets or sets the tc_level.
        /// </summary>
        public string tc_level { get; set; }

        /// <summary>
        /// Gets or sets the transfer_status.
        /// </summary>
        public string transfer_status { get; set; }

        /// <summary>
        /// Gets or sets the bl_id.
        /// </summary>
        public string bl_id { get; set; }

        /// <summary>
        /// Gets or sets the fl_id.
        /// </summary>
        public string fl_id { get; set; }

        /// <summary>
        /// Gets or sets the rm_id.
        /// </summary>
        public string rm_id { get; set; }

        /// <summary>
        /// Gets or sets the activity_log.
        /// </summary>
        public virtual ICollection<activity_log> activity_log { get; set; }

        /// <summary>
        /// Gets or sets the afm_tclevel.
        /// </summary>
        public virtual afm_tclevel afm_tclevel { get; set; }

        /// <summary>
        /// Gets or sets the bas_measurement_scope.
        /// </summary>
        public virtual ICollection<bas_measurement_scope> bas_measurement_scope { get; set; }

        /// <summary>
        /// Gets or sets the bl.
        /// </summary>
        public virtual bl bl { get; set; }

        /// <summary>
        /// Gets or sets the cas.
        /// </summary>
        public virtual ICollection<ca> cas { get; set; }

        /// <summary>
        /// Gets or sets the cb_hcm_places.
        /// </summary>
        public virtual ICollection<cb_hcm_places> cb_hcm_places { get; set; }

        /// <summary>
        /// Gets or sets the combexts.
        /// </summary>
        public virtual ICollection<combext> combexts { get; set; }

        /// <summary>
        /// Gets or sets the compliance_locations.
        /// </summary>
        public virtual ICollection<compliance_locations> compliance_locations { get; set; }

        /// <summary>
        /// Gets or sets the dp.
        /// </summary>
        public virtual dp dp { get; set; }

        /// <summary>
        /// Gets or sets the dv.
        /// </summary>
        public virtual dv dv { get; set; }

        /// <summary>
        /// Gets or sets the ehs_em_ppe_types.
        /// </summary>
        public virtual ICollection<ehs_em_ppe_types> ehs_em_ppe_types { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents.
        /// </summary>
        public virtual ICollection<ehs_incidents> ehs_incidents { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents_sync.
        /// </summary>
        public virtual ICollection<ehs_incidents_sync> ehs_incidents_sync { get; set; }

        /// <summary>
        /// Gets or sets the ems.
        /// </summary>
        public virtual ICollection<Em> ems { get; set; }

        /// <summary>
        /// Gets or sets the ems 1.
        /// </summary>
        public virtual ICollection<Em> ems1 { get; set; }

        /// <summary>
        /// Gets or sets the ems 2.
        /// </summary>
        public virtual ICollection<Em> ems2 { get; set; }

        /// <summary>
        /// Gets or sets the em_compinvtrial.
        /// </summary>
        public virtual ICollection<em_compinvtrial> em_compinvtrial { get; set; }

        /// <summary>
        /// Gets or sets the em_compinvtrial 1.
        /// </summary>
        public virtual ICollection<em_compinvtrial> em_compinvtrial1 { get; set; }

        /// <summary>
        /// Gets or sets the em_sync.
        /// </summary>
        public virtual ICollection<em_sync> em_sync { get; set; }

        /// <summary>
        /// Gets or sets the em_trial.
        /// </summary>
        public virtual ICollection<em_trial> em_trial { get; set; }

        /// <summary>
        /// Gets or sets the eqs.
        /// </summary>
        public virtual ICollection<eq> eqs { get; set; }

        /// <summary>
        /// Gets or sets the eqs 1.
        /// </summary>
        public virtual ICollection<eq> eqs1 { get; set; }

        /// <summary>
        /// Gets or sets the eq_compinvtrial.
        /// </summary>
        public virtual ICollection<eq_compinvtrial> eq_compinvtrial { get; set; }

        /// <summary>
        /// Gets or sets the eq_compinvtrial 1.
        /// </summary>
        public virtual ICollection<eq_compinvtrial> eq_compinvtrial1 { get; set; }

        /// <summary>
        /// Gets or sets the eq_eqstdcnts.
        /// </summary>
        public virtual ICollection<eq_eqstdcnts> eq_eqstdcnts { get; set; }

        /// <summary>
        /// Gets or sets the eq_reserve.
        /// </summary>
        public virtual ICollection<eq_reserve> eq_reserve { get; set; }

        /// <summary>
        /// Gets or sets the eq_trial.
        /// </summary>
        public virtual ICollection<eq_trial> eq_trial { get; set; }

        /// <summary>
        /// Gets or sets the fl.
        /// </summary>
        public virtual Fl fl { get; set; }

        /// <summary>
        /// Gets or sets the fns.
        /// </summary>
        public virtual ICollection<fn> fns { get; set; }

        /// <summary>
        /// Gets or sets the fn_compinvsur.
        /// </summary>
        public virtual ICollection<fn_compinvsur> fn_compinvsur { get; set; }

        /// <summary>
        /// Gets or sets the fn_fnstdcnts.
        /// </summary>
        public virtual ICollection<fn_fnstdcnts> fn_fnstdcnts { get; set; }

        /// <summary>
        /// Gets or sets the fn_trial.
        /// </summary>
        public virtual ICollection<fn_trial> fn_trial { get; set; }

        /// <summary>
        /// Gets or sets the fps.
        /// </summary>
        public virtual ICollection<fp> fps { get; set; }

        /// <summary>
        /// Gets or sets the fs.
        /// </summary>
        public virtual ICollection<f> fs { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_sla_request.
        /// </summary>
        public virtual ICollection<helpdesk_sla_request> helpdesk_sla_request { get; set; }

        /// <summary>
        /// Gets or sets the jks.
        /// </summary>
        public virtual ICollection<jk> jks { get; set; }

        /// <summary>
        /// Gets or sets the l.
        /// </summary>
        public virtual l l { get; set; }

        /// <summary>
        /// Gets or sets the mo_eq.
        /// </summary>
        public virtual ICollection<mo_eq> mo_eq { get; set; }

        /// <summary>
        /// Gets or sets the mo_fncount.
        /// </summary>
        public virtual ICollection<mo_fncount> mo_fncount { get; set; }

        /// <summary>
        /// Gets or sets the mo_ta.
        /// </summary>
        public virtual ICollection<mo_ta> mo_ta { get; set; }

        /// <summary>
        /// Gets or sets the msds_location.
        /// </summary>
        public virtual ICollection<msds_location> msds_location { get; set; }

        /// <summary>
        /// Gets or sets the netdevs.
        /// </summary>
        public virtual ICollection<netdev> netdevs { get; set; }

        /// <summary>
        /// Gets or sets the org.
        /// </summary>
        public virtual org org { get; set; }

        /// <summary>
        /// Gets or sets the pbs.
        /// </summary>
        public virtual ICollection<pb> pbs { get; set; }

        /// <summary>
        /// Gets or sets the pms.
        /// </summary>
        public virtual ICollection<Pm> pms { get; set; }

        /// <summary>
        /// Gets or sets the pns.
        /// </summary>
        public virtual ICollection<pn> pns { get; set; }

        /// <summary>
        /// Gets or sets the ports.
        /// </summary>
        public virtual ICollection<port> ports { get; set; }

        /// <summary>
        /// Gets or sets the pts.
        /// </summary>
        public virtual ICollection<pt> pts { get; set; }

        /// <summary>
        /// Gets or sets the racks.
        /// </summary>
        public virtual ICollection<rack> racks { get; set; }

        /// <summary>
        /// Gets or sets the regcompliances.
        /// </summary>
        public virtual ICollection<regcompliance> regcompliances { get; set; }

        /// <summary>
        /// Gets or sets the reserve_rm.
        /// </summary>
        public virtual ICollection<reserve_rm> reserve_rm { get; set; }

        /// <summary>
        /// Gets or sets the reserve_rs.
        /// </summary>
        public virtual ICollection<reserve_rs> reserve_rs { get; set; }

        /// <summary>
        /// Gets or sets the rfs.
        /// </summary>
        public virtual ICollection<Rf> rfs { get; set; }

        /// <summary>
        /// Gets or sets the rf_activity.
        /// </summary>
        public virtual ICollection<rf_activity> rf_activity { get; set; }

        /// <summary>
        /// Gets or sets the rf_reader.
        /// </summary>
        public virtual ICollection<rf_reader> rf_reader { get; set; }

        /// <summary>
        /// Gets or sets the rf_reader 1.
        /// </summary>
        public virtual ICollection<rf_reader> rf_reader1 { get; set; }

        /// <summary>
        /// Gets or sets the rm_amenity.
        /// </summary>
        public virtual ICollection<rm_amenity> rm_amenity { get; set; }

        /// <summary>
        /// Gets or sets the rm_arrange.
        /// </summary>
        public virtual ICollection<rm_arrange> rm_arrange { get; set; }

        /// <summary>
        /// Gets or sets the rm_config.
        /// </summary>
        public virtual ICollection<rm_config> rm_config { get; set; }

        /// <summary>
        /// Gets or sets the rm_reserve.
        /// </summary>
        public virtual ICollection<rm_reserve> rm_reserve { get; set; }

        /// <summary>
        /// Gets or sets the rm_resource_std.
        /// </summary>
        public virtual ICollection<rm_resource_std> rm_resource_std { get; set; }

        /// <summary>
        /// Gets or sets the rmcat.
        /// </summary>
        public virtual rmcat rmcat { get; set; }

        /// <summary>
        /// Gets or sets the rmstd.
        /// </summary>
        public virtual rmstd rmstd { get; set; }

        /// <summary>
        /// Gets or sets the rmtype.
        /// </summary>
        public virtual rmtype rmtype { get; set; }

        /// <summary>
        /// Gets or sets the rmuse.
        /// </summary>
        public virtual rmuse rmuse { get; set; }

        /// <summary>
        /// Gets or sets the rmpcts.
        /// </summary>
        public virtual ICollection<rmpct> rmpcts { get; set; }

        /// <summary>
        /// Gets or sets the rmpctmob_sync.
        /// </summary>
        public virtual ICollection<rmpctmob_sync> rmpctmob_sync { get; set; }

        /// <summary>
        /// Gets or sets the ta_audit.
        /// </summary>
        public virtual ICollection<ta_audit> ta_audit { get; set; }

        /// <summary>
        /// Gets or sets the ta_compinvtrial.
        /// </summary>
        public virtual ICollection<ta_compinvtrial> ta_compinvtrial { get; set; }

        /// <summary>
        /// Gets or sets the ta_compinvtrial 1.
        /// </summary>
        public virtual ICollection<ta_compinvtrial> ta_compinvtrial1 { get; set; }

        /// <summary>
        /// Gets or sets the tas.
        /// </summary>
        public virtual ICollection<ta> tas { get; set; }

        /// <summary>
        /// Gets or sets the ta_fnstdcnts.
        /// </summary>
        public virtual ICollection<ta_fnstdcnts> ta_fnstdcnts { get; set; }

        /// <summary>
        /// Gets or sets the tas 1.
        /// </summary>
        public virtual ICollection<ta> tas1 { get; set; }

        /// <summary>
        /// Gets or sets the ta_trial.
        /// </summary>
        public virtual ICollection<ta_trial> ta_trial { get; set; }

        /// <summary>
        /// Gets or sets the tls.
        /// </summary>
        public virtual ICollection<tl> tls { get; set; }

        /// <summary>
        /// Gets or sets the visitors.
        /// </summary>
        public virtual ICollection<visitor> visitors { get; set; }

        /// <summary>
        /// Gets or sets the waste_areas.
        /// </summary>
        public virtual ICollection<waste_areas> waste_areas { get; set; }

        /// <summary>
        /// Gets or sets the waste_generators.
        /// </summary>
        public virtual ICollection<waste_generators> waste_generators { get; set; }

        /// <summary>
        /// Gets or sets the wrs.
        /// </summary>
        public virtual ICollection<wr> wrs { get; set; }

        /// <summary>
        /// Gets or sets the wies.
        /// </summary>
        public virtual ICollection<wy> wies { get; set; }
    }
}