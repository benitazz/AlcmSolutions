#region

using System.Collections.Generic;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The fl.
    /// </summary>
    public class Fl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fl"/> class.
        /// </summary>
        public Fl()
        {
            this.ActivityLog = new List<activity_log>();
            this.BasMeasurementScope = new List<bas_measurement_scope>();
            this.Cas = new List<ca>();
            this.CbHcmPlaces = new List<cb_hcm_places>();
            this.Combexts = new List<combext>();
            this.ComplianceLocations = new List<compliance_locations>();
            this.Drs = new List<dr>();
            this.EhsEmPpeTypes = new List<ehs_em_ppe_types>();
            this.EhsIncidents = new List<ehs_incidents>();
            this.EhsIncidentsSync = new List<ehs_incidents_sync>();
            this.Ems = new List<Em>();
            this.Ems1 = new List<Em>();
            this.Ems2 = new List<Em>();
            this.EmCompinvtrial = new List<em_compinvtrial>();
            this.EmCompinvtrial1 = new List<em_compinvtrial>();
            this.EmSync = new List<em_sync>();
            this.EmTrial = new List<em_trial>();
            this.Eqs = new List<eq>();
            this.Eqs1 = new List<eq>();
            this.EqCompinvtrial = new List<eq_compinvtrial>();
            this.EqCompinvtrial1 = new List<eq_compinvtrial>();
            this.EqEqstdcnts = new List<eq_eqstdcnts>();
            this.EqReserve = new List<eq_reserve>();
            this.EqTrial = new List<eq_trial>();
            this.FnCompinvsur = new List<fn_compinvsur>();
            this.Fns = new List<fn>();
            this.FnFnstdcnts = new List<fn_fnstdcnts>();
            this.FnTrial = new List<fn_trial>();
            this.Fps = new List<fp>();
            this.Fs = new List<f>();
            this.Gps = new List<gp>();
            this.Grids = new List<grid>();
            this.Gros = new List<gro>();
            this.HelpdeskSlaRequest = new List<helpdesk_sla_request>();
            this.Jks = new List<jk>();
            this.MoChurn = new List<mo_churn>();
            this.MoEq = new List<mo_eq>();
            this.MoFncount = new List<mo_fncount>();
            this.MoTa = new List<mo_ta>();
            this.MsdsLocation = new List<msds_location>();
            this.Netdevs = new List<netdev>();
            this.Pbs = new List<pb>();
            this.Pmgens = new List<pmgen>();
            this.Pms = new List<Pm>();
            this.Pns = new List<pn>();
            this.Ports = new List<port>();
            this.Pts = new List<pt>();
            this.Racks = new List<rack>();
            this.Regcompliances = new List<regcompliance>();
            this.ReserveRm = new List<reserve_rm>();
            this.ReserveRs = new List<reserve_rs>();
            this.RfActivity = new List<rf_activity>();
            this.Rfs = new List<Rf>();
            this.RfReader = new List<rf_reader>();
            this.RmAmenity = new List<rm_amenity>();
            this.RmArrange = new List<rm_arrange>();
            this.RmConfig = new List<rm_config>();
            this.Rms = new List<Rm>();
            this.RmReserve = new List<rm_reserve>();
            this.RmResourceStd = new List<rm_resource_std>();
            this.Rmpcts = new List<rmpct>();
            this.RmpctmobSync = new List<rmpctmob_sync>();
            this.SbItems = new List<sb_items>();
            this.Servs = new List<serv>();
            this.Sus = new List<su>();
            this.SurveyrmSync = new List<surveyrm_sync>();
            this.TaAudit = new List<ta_audit>();
            this.TaCompinvtrial = new List<ta_compinvtrial>();
            this.TaCompinvtrial1 = new List<ta_compinvtrial>();
            this.Tas = new List<ta>();
            this.Tas1 = new List<ta>();
            this.TaFnstdcnts = new List<ta_fnstdcnts>();
            this.TaTrial = new List<ta_trial>();
            this.Tls = new List<tl>();
            this.Verts = new List<vert>();
            this.Visitors = new List<visitor>();
            this.WasteAreas = new List<waste_areas>();
            this.WasteGenerators = new List<waste_generators>();
            this.Wns = new List<wn>();
            this.Wrs = new List<wr>();
            this.Wies = new List<wy>();
            this.Zones = new List<zone>();
        }

        /// <summary>
        /// Gets or sets the area_allocated.
        /// </summary>
        public decimal AreaAllocated { get; set; }

        /// <summary>
        /// Gets or sets the area_em_dp.
        /// </summary>
        public decimal AreaEmDp { get; set; }

        /// <summary>
        /// Gets or sets the area_ext_wall.
        /// </summary>
        public decimal AreaExtWall { get; set; }

        /// <summary>
        /// Gets or sets the area_fl_comn_gp.
        /// </summary>
        public decimal AreaFlComnGp { get; set; }

        /// <summary>
        /// Gets or sets the area_fl_comn_nocup.
        /// </summary>
        public decimal AreaFlComnNocup { get; set; }

        /// <summary>
        /// Gets or sets the area_fl_comn_ocup.
        /// </summary>
        public decimal AreaFlComnOcup { get; set; }

        /// <summary>
        /// Gets or sets the area_fl_comn_rm.
        /// </summary>
        public decimal AreaFlComnRm { get; set; }

        /// <summary>
        /// Gets or sets the area_fl_comn_serv.
        /// </summary>
        public decimal AreaFlComnServ { get; set; }

        /// <summary>
        /// Gets or sets the area_gp.
        /// </summary>
        public decimal AreaGp { get; set; }

        /// <summary>
        /// Gets or sets the area_gp_comn.
        /// </summary>
        public decimal AreaGpComn { get; set; }

        /// <summary>
        /// Gets or sets the area_gp_dp.
        /// </summary>
        public decimal AreaGpDp { get; set; }

        /// <summary>
        /// Gets or sets the area_gross_ext.
        /// </summary>
        public decimal AreaGrossExt { get; set; }

        /// <summary>
        /// Gets or sets the area_gross_int.
        /// </summary>
        public decimal AreaGrossInt { get; set; }

        /// <summary>
        /// Gets or sets the area_manual.
        /// </summary>
        public decimal AreaManual { get; set; }

        /// <summary>
        /// Gets or sets the area_nocup.
        /// </summary>
        public decimal AreaNocup { get; set; }

        /// <summary>
        /// Gets or sets the area_nocup_comn.
        /// </summary>
        public decimal AreaNocupComn { get; set; }

        /// <summary>
        /// Gets or sets the area_nocup_dp.
        /// </summary>
        public decimal AreaNocupDp { get; set; }

        /// <summary>
        /// Gets or sets the area_ocup.
        /// </summary>
        public decimal AreaOcup { get; set; }

        /// <summary>
        /// Gets or sets the area_ocup_comn.
        /// </summary>
        public decimal AreaOcupComn { get; set; }

        /// <summary>
        /// Gets or sets the area_ocup_dp.
        /// </summary>
        public decimal AreaOcupDp { get; set; }

        /// <summary>
        /// Gets or sets the area_remain.
        /// </summary>
        public decimal AreaRemain { get; set; }

        /// <summary>
        /// Gets or sets the area_rentable.
        /// </summary>
        public decimal AreaRentable { get; set; }

        /// <summary>
        /// Gets or sets the area_rm.
        /// </summary>
        public decimal AreaRm { get; set; }

        /// <summary>
        /// Gets or sets the area_rm_comn.
        /// </summary>
        public decimal AreaRmComn { get; set; }

        /// <summary>
        /// Gets or sets the area_rm_dp.
        /// </summary>
        public decimal AreaRmDp { get; set; }

        /// <summary>
        /// Gets or sets the area_serv.
        /// </summary>
        public decimal AreaServ { get; set; }

        /// <summary>
        /// Gets or sets the area_su.
        /// </summary>
        public decimal AreaSu { get; set; }

        /// <summary>
        /// Gets or sets the area_usable.
        /// </summary>
        public decimal AreaUsable { get; set; }

        /// <summary>
        /// Gets or sets the area_vert_pen.
        /// </summary>
        public decimal AreaVertPen { get; set; }

        /// <summary>
        /// Gets or sets the height_nom.
        /// </summary>
        public decimal HeightNom { get; set; }

        /// <summary>
        /// Gets or sets the image_file.
        /// </summary>
        public string ImageFile { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the option 1.
        /// </summary>
        public string Option1 { get; set; }

        /// <summary>
        /// Gets or sets the option 2.
        /// </summary>
        public string Option2 { get; set; }

        /// <summary>
        /// Gets or sets the prorate_remain.
        /// </summary>
        public string ProrateRemain { get; set; }

        /// <summary>
        /// Gets or sets the ratio_ru.
        /// </summary>
        public decimal RatioRu { get; set; }

        /// <summary>
        /// Gets or sets the ratio_ur.
        /// </summary>
        public decimal RatioUr { get; set; }

        /// <summary>
        /// Gets or sets the std_area_per_em.
        /// </summary>
        public decimal StdAreaPerEm { get; set; }

        /// <summary>
        /// Gets or sets the cost_sqft.
        /// </summary>
        public decimal CostSqft { get; set; }

        /// <summary>
        /// Gets or sets the count_em.
        /// </summary>
        public decimal CountEm { get; set; }

        /// <summary>
        /// Gets or sets the detail_dwg.
        /// </summary>
        public string DetailDwg { get; set; }

        /// <summary>
        /// Gets or sets the dwgname.
        /// </summary>
        public string Dwgname { get; set; }

        /// <summary>
        /// Gets or sets the ehandle.
        /// </summary>
        public string Ehandle { get; set; }

        /// <summary>
        /// Gets or sets the elevation_nom.
        /// </summary>
        public decimal ElevationNom { get; set; }

        /// <summary>
        /// Gets or sets the bl_id.
        /// </summary>
        public string bl_id { get; set; }

        /// <summary>
        /// Gets or sets the fl_id.
        /// </summary>
        public string fl_id { get; set; }

        /// <summary>
        /// Gets or sets the activity_log.
        /// </summary>
        public virtual ICollection<activity_log> ActivityLog { get; set; }

        /// <summary>
        /// Gets or sets the bas_measurement_scope.
        /// </summary>
        public virtual ICollection<bas_measurement_scope> BasMeasurementScope { get; set; }

        /// <summary>
        /// Gets or sets the bl.
        /// </summary>
        public virtual bl Bl { get; set; }

        /// <summary>
        /// Gets or sets the cas.
        /// </summary>
        public virtual ICollection<ca> Cas { get; set; }

        /// <summary>
        /// Gets or sets the cb_hcm_places.
        /// </summary>
        public virtual ICollection<cb_hcm_places> CbHcmPlaces { get; set; }

        /// <summary>
        /// Gets or sets the combexts.
        /// </summary>
        public virtual ICollection<combext> Combexts { get; set; }

        /// <summary>
        /// Gets or sets the compliance_locations.
        /// </summary>
        public virtual ICollection<compliance_locations> ComplianceLocations { get; set; }

        /// <summary>
        /// Gets or sets the drs.
        /// </summary>
        public virtual ICollection<dr> Drs { get; set; }

        /// <summary>
        /// Gets or sets the ehs_em_ppe_types.
        /// </summary>
        public virtual ICollection<ehs_em_ppe_types> EhsEmPpeTypes { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents.
        /// </summary>
        public virtual ICollection<ehs_incidents> EhsIncidents { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents_sync.
        /// </summary>
        public virtual ICollection<ehs_incidents_sync> EhsIncidentsSync { get; set; }

        /// <summary>
        /// Gets or sets the ems.
        /// </summary>
        public virtual ICollection<Em> Ems { get; set; }

        /// <summary>
        /// Gets or sets the ems 1.
        /// </summary>
        public virtual ICollection<Em> Ems1 { get; set; }

        /// <summary>
        /// Gets or sets the ems 2.
        /// </summary>
        public virtual ICollection<Em> Ems2 { get; set; }

        /// <summary>
        /// Gets or sets the em_compinvtrial.
        /// </summary>
        public virtual ICollection<em_compinvtrial> EmCompinvtrial { get; set; }

        /// <summary>
        /// Gets or sets the em_compinvtrial 1.
        /// </summary>
        public virtual ICollection<em_compinvtrial> EmCompinvtrial1 { get; set; }

        /// <summary>
        /// Gets or sets the em_sync.
        /// </summary>
        public virtual ICollection<em_sync> EmSync { get; set; }

        /// <summary>
        /// Gets or sets the em_trial.
        /// </summary>
        public virtual ICollection<em_trial> EmTrial { get; set; }

        /// <summary>
        /// Gets or sets the eqs.
        /// </summary>
        public virtual ICollection<eq> Eqs { get; set; }

        /// <summary>
        /// Gets or sets the eqs 1.
        /// </summary>
        public virtual ICollection<eq> Eqs1 { get; set; }

        /// <summary>
        /// Gets or sets the eq_compinvtrial.
        /// </summary>
        public virtual ICollection<eq_compinvtrial> EqCompinvtrial { get; set; }

        /// <summary>
        /// Gets or sets the eq_compinvtrial 1.
        /// </summary>
        public virtual ICollection<eq_compinvtrial> EqCompinvtrial1 { get; set; }

        /// <summary>
        /// Gets or sets the eq_eqstdcnts.
        /// </summary>
        public virtual ICollection<eq_eqstdcnts> EqEqstdcnts { get; set; }

        /// <summary>
        /// Gets or sets the eq_reserve.
        /// </summary>
        public virtual ICollection<eq_reserve> EqReserve { get; set; }

        /// <summary>
        /// Gets or sets the eq_trial.
        /// </summary>
        public virtual ICollection<eq_trial> EqTrial { get; set; }

        /// <summary>
        /// Gets or sets the fn_compinvsur.
        /// </summary>
        public virtual ICollection<fn_compinvsur> FnCompinvsur { get; set; }

        /// <summary>
        /// Gets or sets the fns.
        /// </summary>
        public virtual ICollection<fn> Fns { get; set; }

        /// <summary>
        /// Gets or sets the fn_fnstdcnts.
        /// </summary>
        public virtual ICollection<fn_fnstdcnts> FnFnstdcnts { get; set; }

        /// <summary>
        /// Gets or sets the fn_trial.
        /// </summary>
        public virtual ICollection<fn_trial> FnTrial { get; set; }

        /// <summary>
        /// Gets or sets the fps.
        /// </summary>
        public virtual ICollection<fp> Fps { get; set; }

        /// <summary>
        /// Gets or sets the fs.
        /// </summary>
        public virtual ICollection<f> Fs { get; set; }

        /// <summary>
        /// Gets or sets the gps.
        /// </summary>
        public virtual ICollection<gp> Gps { get; set; }

        /// <summary>
        /// Gets or sets the grids.
        /// </summary>
        public virtual ICollection<grid> Grids { get; set; }

        /// <summary>
        /// Gets or sets the gros.
        /// </summary>
        public virtual ICollection<gro> Gros { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_sla_request.
        /// </summary>
        public virtual ICollection<helpdesk_sla_request> HelpdeskSlaRequest { get; set; }

        /// <summary>
        /// Gets or sets the jks.
        /// </summary>
        public virtual ICollection<jk> Jks { get; set; }

        /// <summary>
        /// Gets or sets the mo_churn.
        /// </summary>
        public virtual ICollection<mo_churn> MoChurn { get; set; }

        /// <summary>
        /// Gets or sets the mo_eq.
        /// </summary>
        public virtual ICollection<mo_eq> MoEq { get; set; }

        /// <summary>
        /// Gets or sets the mo_fncount.
        /// </summary>
        public virtual ICollection<mo_fncount> MoFncount { get; set; }

        /// <summary>
        /// Gets or sets the mo_ta.
        /// </summary>
        public virtual ICollection<mo_ta> MoTa { get; set; }

        /// <summary>
        /// Gets or sets the msds_location.
        /// </summary>
        public virtual ICollection<msds_location> MsdsLocation { get; set; }

        /// <summary>
        /// Gets or sets the netdevs.
        /// </summary>
        public virtual ICollection<netdev> Netdevs { get; set; }

        /// <summary>
        /// Gets or sets the pbs.
        /// </summary>
        public virtual ICollection<pb> Pbs { get; set; }

        /// <summary>
        /// Gets or sets the pmgens.
        /// </summary>
        public virtual ICollection<pmgen> Pmgens { get; set; }

        /// <summary>
        /// Gets or sets the pms.
        /// </summary>
        public virtual ICollection<Pm> Pms { get; set; }

        /// <summary>
        /// Gets or sets the pns.
        /// </summary>
        public virtual ICollection<pn> Pns { get; set; }

        /// <summary>
        /// Gets or sets the ports.
        /// </summary>
        public virtual ICollection<port> Ports { get; set; }

        /// <summary>
        /// Gets or sets the pts.
        /// </summary>
        public virtual ICollection<pt> Pts { get; set; }

        /// <summary>
        /// Gets or sets the racks.
        /// </summary>
        public virtual ICollection<rack> Racks { get; set; }

        /// <summary>
        /// Gets or sets the regcompliances.
        /// </summary>
        public virtual ICollection<regcompliance> Regcompliances { get; set; }

        /// <summary>
        /// Gets or sets the reserve_rm.
        /// </summary>
        public virtual ICollection<reserve_rm> ReserveRm { get; set; }

        /// <summary>
        /// Gets or sets the reserve_rs.
        /// </summary>
        public virtual ICollection<reserve_rs> ReserveRs { get; set; }

        /// <summary>
        /// Gets or sets the rf_activity.
        /// </summary>
        public virtual ICollection<rf_activity> RfActivity { get; set; }

        /// <summary>
        /// Gets or sets the rfs.
        /// </summary>
        public virtual ICollection<Rf> Rfs { get; set; }

        /// <summary>
        /// Gets or sets the rf_reader.
        /// </summary>
        public virtual ICollection<rf_reader> RfReader { get; set; }

        /// <summary>
        /// Gets or sets the rm_amenity.
        /// </summary>
        public virtual ICollection<rm_amenity> RmAmenity { get; set; }

        /// <summary>
        /// Gets or sets the rm_arrange.
        /// </summary>
        public virtual ICollection<rm_arrange> RmArrange { get; set; }

        /// <summary>
        /// Gets or sets the rm_config.
        /// </summary>
        public virtual ICollection<rm_config> RmConfig { get; set; }

        /// <summary>
        /// Gets or sets the rms.
        /// </summary>
        public virtual ICollection<Rm> Rms { get; set; }

        /// <summary>
        /// Gets or sets the rm_reserve.
        /// </summary>
        public virtual ICollection<rm_reserve> RmReserve { get; set; }

        /// <summary>
        /// Gets or sets the rm_resource_std.
        /// </summary>
        public virtual ICollection<rm_resource_std> RmResourceStd { get; set; }

        /// <summary>
        /// Gets or sets the rmpcts.
        /// </summary>
        public virtual ICollection<rmpct> Rmpcts { get; set; }

        /// <summary>
        /// Gets or sets the rmpctmob_sync.
        /// </summary>
        public virtual ICollection<rmpctmob_sync> RmpctmobSync { get; set; }

        /// <summary>
        /// Gets or sets the sb_items.
        /// </summary>
        public virtual ICollection<sb_items> SbItems { get; set; }

        /// <summary>
        /// Gets or sets the servs.
        /// </summary>
        public virtual ICollection<serv> Servs { get; set; }

        /// <summary>
        /// Gets or sets the sus.
        /// </summary>
        public virtual ICollection<su> Sus { get; set; }

        /// <summary>
        /// Gets or sets the surveyrm_sync.
        /// </summary>
        public virtual ICollection<surveyrm_sync> SurveyrmSync { get; set; }

        /// <summary>
        /// Gets or sets the ta_audit.
        /// </summary>
        public virtual ICollection<ta_audit> TaAudit { get; set; }

        /// <summary>
        /// Gets or sets the ta_compinvtrial.
        /// </summary>
        public virtual ICollection<ta_compinvtrial> TaCompinvtrial { get; set; }

        /// <summary>
        /// Gets or sets the ta_compinvtrial 1.
        /// </summary>
        public virtual ICollection<ta_compinvtrial> TaCompinvtrial1 { get; set; }

        /// <summary>
        /// Gets or sets the tas.
        /// </summary>
        public virtual ICollection<ta> Tas { get; set; }

        /// <summary>
        /// Gets or sets the tas 1.
        /// </summary>
        public virtual ICollection<ta> Tas1 { get; set; }

        /// <summary>
        /// Gets or sets the ta_fnstdcnts.
        /// </summary>
        public virtual ICollection<ta_fnstdcnts> TaFnstdcnts { get; set; }

        /// <summary>
        /// Gets or sets the ta_trial.
        /// </summary>
        public virtual ICollection<ta_trial> TaTrial { get; set; }

        /// <summary>
        /// Gets or sets the tls.
        /// </summary>
        public virtual ICollection<tl> Tls { get; set; }

        /// <summary>
        /// Gets or sets the verts.
        /// </summary>
        public virtual ICollection<vert> Verts { get; set; }

        /// <summary>
        /// Gets or sets the visitors.
        /// </summary>
        public virtual ICollection<visitor> Visitors { get; set; }

        /// <summary>
        /// Gets or sets the waste_areas.
        /// </summary>
        public virtual ICollection<waste_areas> WasteAreas { get; set; }

        /// <summary>
        /// Gets or sets the waste_generators.
        /// </summary>
        public virtual ICollection<waste_generators> WasteGenerators { get; set; }

        /// <summary>
        /// Gets or sets the wns.
        /// </summary>
        public virtual ICollection<wn> Wns { get; set; }

        /// <summary>
        /// Gets or sets the wrs.
        /// </summary>
        public virtual ICollection<wr> Wrs { get; set; }

        /// <summary>
        /// Gets or sets the wies.
        /// </summary>
        public virtual ICollection<wy> Wies { get; set; }

        /// <summary>
        /// Gets or sets the zones.
        /// </summary>
        public virtual ICollection<zone> Zones { get; set; }
    }
}