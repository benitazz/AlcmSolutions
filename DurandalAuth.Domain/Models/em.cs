#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The em.
    /// </summary>
    public class Em
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Em"/> class.
        /// </summary>
        public Em()
        {
            this.ActivityLog = new List<activity_log>();
            this.ActivityLog1 = new List<activity_log>();
            this.ActivityLog2 = new List<activity_log>();
            this.ActivityLog3 = new List<activity_log>();
            this.ActivityLogSync = new List<activity_log_sync>();
            this.CbAccreditPerson = new List<cb_accredit_person>();
            this.Cfs = new List<cf>();
            this.Combexts = new List<combext>();
            this.ComplianceLocations = new List<compliance_locations>();
            this.EhsEmPpeTypes = new List<ehs_em_ppe_types>();
            this.EhsIncidentWitness = new List<ehs_incident_witness>();
            this.EhsIncidentWitnessSync = new List<ehs_incident_witness_sync>();
            this.EhsIncidents = new List<ehs_incidents>();
            this.EhsIncidents1 = new List<ehs_incidents>();
            this.EhsIncidents2 = new List<ehs_incidents>();
            this.EhsIncidents3 = new List<ehs_incidents>();
            this.EhsIncidents4 = new List<ehs_incidents>();
            this.EhsIncidentsSync = new List<ehs_incidents_sync>();
            this.EhsIncidentsSync1 = new List<ehs_incidents_sync>();
            this.EhsIncidentsSync2 = new List<ehs_incidents_sync>();
            this.EhsMedicalMonResults = new List<ehs_medical_mon_results>();
            this.EhsRestrictions = new List<ehs_restrictions>();
            this.EhsTrainingResults = new List<ehs_training_results>();
            this.EmCompinvtrial = new List<em_compinvtrial>();
            this.EmTrial = new List<em_trial>();
            this.Eqs = new List<eq>();
            this.EqEqstdcnts = new List<eq_eqstdcnts>();
            this.EqReserve = new List<eq_reserve>();
            this.Fps = new List<fp>();
            this.GbCertDocs = new List<gb_cert_docs>();
            this.GbCertLog = new List<gb_cert_log>();
            this.HelpdeskSlaRequest = new List<helpdesk_sla_request>();
            this.HelpdeskSlaResponse = new List<helpdesk_sla_response>();
            this.HelpdeskSlaResponse1 = new List<helpdesk_sla_response>();
            this.HelpdeskSlaResponse2 = new List<helpdesk_sla_response>();
            this.HelpdeskSlaResponse3 = new List<helpdesk_sla_response>();
            this.HelpdeskSlaSteps = new List<helpdesk_sla_steps>();
            this.HelpdeskStepLog = new List<helpdesk_step_log>();
            this.Jks = new List<jk>();
            this.ls_amendment = new List<ls_amendment>();
            this.ls_comm = new List<ls_comm>();
            this.moes = new List<mo>();
            this.moes1 = new List<mo>();
            this.moes2 = new List<mo>();
            this.moes3 = new List<mo>();
            this.mo_eq = new List<mo_eq>();
            this.moes4 = new List<mo>();
            this.moes5 = new List<mo>();
            this.mo_scenario_em = new List<MoScenarioEm>();
            this.mo_scenario = new List<mo_scenario>();
            this.mo_ta = new List<mo_ta>();
            this.mps = new List<mp>();
            this.ops = new List<op>();
            this.parkings = new List<parking>();
            this.poes = new List<po>();
            this.programs = new List<program>();
            this.projects = new List<project>();
            this.projects1 = new List<project>();
            this.projects2 = new List<project>();
            this.projects3 = new List<project>();
            this.projects4 = new List<project>();
            this.projects5 = new List<project>();
            this.recovery_team = new List<recovery_team>();
            this.reglocs = new List<regloc>();
            this.regprograms = new List<regprogram>();
            this.regrequirements = new List<regrequirement>();
            this.reserve_rm = new List<reserve_rm>();
            this.reserve_rs = new List<reserve_rs>();
            this.reserves = new List<reserve>();
            this.reserves1 = new List<reserve>();
            this.reserves2 = new List<reserve>();
            this.reserves3 = new List<reserve>();
            this.rm_reserve = new List<rm_reserve>();
            this.status_log = new List<status_log>();
            this.surveys = new List<survey>();
            this.surveymob_sync = new List<surveymob_sync>();
            this.ta_audit = new List<ta_audit>();
            this.tas = new List<ta>();
            this.ta_fnstdcnts = new List<ta_fnstdcnts>();
            this.visitors = new List<visitor>();
            this.woes = new List<wo>();
            this.woes1 = new List<wo>();
            this.woes2 = new List<wo>();
            this.woes3 = new List<wo>();
            this.work_categories_em = new List<work_categories_em>();
            this.work_pkg_bids = new List<work_pkg_bids>();
            this.work_pkgs = new List<work_pkgs>();
            this.work_roles_location = new List<work_roles_location>();
            this.workflow_substitutes = new List<workflow_substitutes>();
            this.workflow_substitutes1 = new List<workflow_substitutes>();
            this.wrs = new List<wr>();
            this.wrs1 = new List<wr>();
            this.wrs2 = new List<wr>();
            this.wrs3 = new List<wr>();
            this.wrs4 = new List<wr>();
        }

        /// <summary>
        /// Gets or sets the em_number.
        /// </summary>
        public string EmNumber { get; set; }

        /// <summary>
        /// Gets or sets the em_photo.
        /// </summary>
        public string EmPhoto { get; set; }

        /// <summary>
        /// Gets or sets the em_std.
        /// </summary>
        public string EmStd { get; set; }

        /// <summary>
        /// Gets or sets the em_title.
        /// </summary>
        public string EmTitle { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the emergency_contact.
        /// </summary>
        public string EmergencyContact { get; set; }

        /// <summary>
        /// Gets or sets the emergency_phone.
        /// </summary>
        public string EmergencyPhone { get; set; }

        /// <summary>
        /// Gets or sets the emergency_relation.
        /// </summary>
        public string EmergencyRelation { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Gets or sets the fax.
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Gets or sets the fl_id.
        /// </summary>
        public string fl_id { get; set; }

        /// <summary>
        /// Gets or sets the geo_objectid.
        /// </summary>
        public int? geo_objectid { get; set; }

        /// <summary>
        /// Gets or sets the honorific.
        /// </summary>
        public string Honorific { get; set; }

        /// <summary>
        /// Gets or sets the image_file.
        /// </summary>
        public string ImageFile { get; set; }

        /// <summary>
        /// Gets or sets the lat.
        /// </summary>
        public decimal? Lat { get; set; }

        /// <summary>
        /// Gets or sets the layer_name.
        /// </summary>
        public string LayerName { get; set; }

        /// <summary>
        /// Gets or sets the lon.
        /// </summary>
        public decimal? Lon { get; set; }

        /// <summary>
        /// Gets or sets the mailstop.
        /// </summary>
        public string Mailstop { get; set; }

        /// <summary>
        /// Gets or sets the name_first.
        /// </summary>
        public string NameFirst { get; set; }

        /// <summary>
        /// Gets or sets the name_last.
        /// </summary>
        public string NameLast { get; set; }

        /// <summary>
        /// Gets or sets the net_id.
        /// </summary>
        public string net_id { get; set; }

        /// <summary>
        /// Gets or sets the net_user_name.
        /// </summary>
        public string NetUserName { get; set; }

        /// <summary>
        /// Gets or sets the option 1.
        /// </summary>
        public string Option1 { get; set; }

        /// <summary>
        /// Gets or sets the option 2.
        /// </summary>
        public string Option2 { get; set; }

        /// <summary>
        /// Gets or sets the pager_number.
        /// </summary>
        public string PagerNumber { get; set; }

        /// <summary>
        /// Gets or sets the pct_rm.
        /// </summary>
        public decimal PctRm { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the phone_home.
        /// </summary>
        public string PhoneHome { get; set; }

        /// <summary>
        /// Gets or sets the recovery_status.
        /// </summary>
        public string RecoveryStatus { get; set; }

        /// <summary>
        /// Gets or sets the rf_id.
        /// </summary>
        public string rf_id { get; set; }

        /// <summary>
        /// Gets or sets the rm_id.
        /// </summary>
        public string rm_id { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the tc_level.
        /// </summary>
        public string TcLevel { get; set; }

        /// <summary>
        /// Gets or sets the area_chargable.
        /// </summary>
        public decimal AreaChargable { get; set; }

        /// <summary>
        /// Gets or sets the area_comn.
        /// </summary>
        public decimal AreaComn { get; set; }

        /// <summary>
        /// Gets or sets the area_comn_nocup.
        /// </summary>
        public decimal AreaComnNocup { get; set; }

        /// <summary>
        /// Gets or sets the area_comn_ocup.
        /// </summary>
        public decimal AreaComnOcup { get; set; }

        /// <summary>
        /// Gets or sets the area_comn_rm.
        /// </summary>
        public decimal AreaComnRm { get; set; }

        /// <summary>
        /// Gets or sets the area_comn_serv.
        /// </summary>
        public decimal AreaComnServ { get; set; }

        /// <summary>
        /// Gets or sets the area_rm.
        /// </summary>
        public decimal AreaRm { get; set; }

        /// <summary>
        /// Gets or sets the bl_id.
        /// </summary>
        public string bl_id { get; set; }

        /// <summary>
        /// Gets or sets the calling_card_number.
        /// </summary>
        public string CallingCardNumber { get; set; }

        /// <summary>
        /// Gets or sets the cellular_number.
        /// </summary>
        public string CellularNumber { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets the contingency_bl_id.
        /// </summary>
        public string contingency_bl_id { get; set; }

        /// <summary>
        /// Gets or sets the contingency_email.
        /// </summary>
        public string ContingencyEmail { get; set; }

        /// <summary>
        /// Gets or sets the contingency_fac_at.
        /// </summary>
        public short ContingencyFacAt { get; set; }

        /// <summary>
        /// Gets or sets the contingency_fax.
        /// </summary>
        public string ContingencyFax { get; set; }

        /// <summary>
        /// Gets or sets the contingency_fl_id.
        /// </summary>
        public string contingency_fl_id { get; set; }

        /// <summary>
        /// Gets or sets the contingency_phone.
        /// </summary>
        public string ContingencyPhone { get; set; }

        /// <summary>
        /// Gets or sets the contingency_rm_id.
        /// </summary>
        public string contingency_rm_id { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Gets or sets the curr_bl_id.
        /// </summary>
        public string curr_bl_id { get; set; }

        /// <summary>
        /// Gets or sets the curr_fl_id.
        /// </summary>
        public string curr_fl_id { get; set; }

        /// <summary>
        /// Gets or sets the curr_rm_id.
        /// </summary>
        public string curr_rm_id { get; set; }

        /// <summary>
        /// Gets or sets the curr_site_id.
        /// </summary>
        public string CurrSiteId { get; set; }

        /// <summary>
        /// Gets or sets the date_hired.
        /// </summary>
        public DateTime? DateHired { get; set; }

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
        public string Dwgname { get; set; }

        /// <summary>
        /// Gets or sets the ehandle.
        /// </summary>
        public string Ehandle { get; set; }

        /// <summary>
        /// Gets or sets the em_id.
        /// </summary>
        public string EmId { get; set; }

        /// <summary>
        /// Gets or sets the activity_log.
        /// </summary>
        public virtual ICollection<activity_log> ActivityLog { get; set; }

        /// <summary>
        /// Gets or sets the activity_log 1.
        /// </summary>
        public virtual ICollection<activity_log> ActivityLog1 { get; set; }

        /// <summary>
        /// Gets or sets the activity_log 2.
        /// </summary>
        public virtual ICollection<activity_log> ActivityLog2 { get; set; }

        /// <summary>
        /// Gets or sets the activity_log 3.
        /// </summary>
        public virtual ICollection<activity_log> ActivityLog3 { get; set; }

        /// <summary>
        /// Gets or sets the activity_log_sync.
        /// </summary>
        public virtual ICollection<activity_log_sync> ActivityLogSync { get; set; }

        /// <summary>
        /// Gets or sets the afm_tclevel.
        /// </summary>
        public virtual afm_tclevel AfmTclevel { get; set; }

        /// <summary>
        /// Gets or sets the bl.
        /// </summary>
        public virtual bl Bl { get; set; }

        /// <summary>
        /// Gets or sets the bl 1.
        /// </summary>
        public virtual bl Bl1 { get; set; }

        /// <summary>
        /// Gets or sets the cb_accredit_person.
        /// </summary>
        public virtual ICollection<cb_accredit_person> CbAccreditPerson { get; set; }

        /// <summary>
        /// Gets or sets the cfs.
        /// </summary>
        public virtual ICollection<cf> Cfs { get; set; }

        /// <summary>
        /// Gets or sets the combexts.
        /// </summary>
        public virtual ICollection<combext> Combexts { get; set; }

        /// <summary>
        /// Gets or sets the compliance_locations.
        /// </summary>
        public virtual ICollection<compliance_locations> ComplianceLocations { get; set; }

        /// <summary>
        /// Gets or sets the dp.
        /// </summary>
        public virtual dp Dp { get; set; }

        /// <summary>
        /// Gets or sets the dv.
        /// </summary>
        public virtual dv Dv { get; set; }

        /// <summary>
        /// Gets or sets the ehs_em_ppe_types.
        /// </summary>
        public virtual ICollection<ehs_em_ppe_types> EhsEmPpeTypes { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incident_witness.
        /// </summary>
        public virtual ICollection<ehs_incident_witness> EhsIncidentWitness { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incident_witness_sync.
        /// </summary>
        public virtual ICollection<ehs_incident_witness_sync> EhsIncidentWitnessSync { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents.
        /// </summary>
        public virtual ICollection<ehs_incidents> EhsIncidents { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents 1.
        /// </summary>
        public virtual ICollection<ehs_incidents> EhsIncidents1 { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents 2.
        /// </summary>
        public virtual ICollection<ehs_incidents> EhsIncidents2 { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents 3.
        /// </summary>
        public virtual ICollection<ehs_incidents> EhsIncidents3 { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents 4.
        /// </summary>
        public virtual ICollection<ehs_incidents> EhsIncidents4 { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents_sync.
        /// </summary>
        public virtual ICollection<ehs_incidents_sync> EhsIncidentsSync { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents_sync 1.
        /// </summary>
        public virtual ICollection<ehs_incidents_sync> EhsIncidentsSync1 { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents_sync 2.
        /// </summary>
        public virtual ICollection<ehs_incidents_sync> EhsIncidentsSync2 { get; set; }

        /// <summary>
        /// Gets or sets the ehs_medical_mon_results.
        /// </summary>
        public virtual ICollection<ehs_medical_mon_results> EhsMedicalMonResults { get; set; }

        /// <summary>
        /// Gets or sets the ehs_restrictions.
        /// </summary>
        public virtual ICollection<ehs_restrictions> EhsRestrictions { get; set; }

        /// <summary>
        /// Gets or sets the ehs_training_results.
        /// </summary>
        public virtual ICollection<ehs_training_results> EhsTrainingResults { get; set; }

        /// <summary>
        /// Gets or sets the em_compinvtrial.
        /// </summary>
        public virtual ICollection<em_compinvtrial> EmCompinvtrial { get; set; }

        /// <summary>
        /// Gets or sets the fl.
        /// </summary>
        public virtual Fl Fl { get; set; }

        /// <summary>
        /// Gets or sets the rm.
        /// </summary>
        public virtual Rm Rm { get; set; }

        /// <summary>
        /// Gets or sets the fl 1.
        /// </summary>
        public virtual Fl Fl1 { get; set; }

        /// <summary>
        /// Gets or sets the rm 1.
        /// </summary>
        public virtual Rm Rm1 { get; set; }

        /// <summary>
        /// Gets or sets the emstd.
        /// </summary>
        public virtual emstd Emstd { get; set; }

        /// <summary>
        /// Gets or sets the fl 2.
        /// </summary>
        public virtual Fl Fl2 { get; set; }

        /// <summary>
        /// Gets or sets the net.
        /// </summary>
        public virtual net Net { get; set; }

        /// <summary>
        /// Gets or sets the rm 2.
        /// </summary>
        public virtual Rm Rm2 { get; set; }

        /// <summary>
        /// Gets or sets the em_trial.
        /// </summary>
        public virtual ICollection<em_trial> EmTrial { get; set; }

        /// <summary>
        /// Gets or sets the eqs.
        /// </summary>
        public virtual ICollection<eq> Eqs { get; set; }

        /// <summary>
        /// Gets or sets the eq_eqstdcnts.
        /// </summary>
        public virtual ICollection<eq_eqstdcnts> EqEqstdcnts { get; set; }

        /// <summary>
        /// Gets or sets the eq_reserve.
        /// </summary>
        public virtual ICollection<eq_reserve> EqReserve { get; set; }

        /// <summary>
        /// Gets or sets the fps.
        /// </summary>
        public virtual ICollection<fp> Fps { get; set; }

        /// <summary>
        /// Gets or sets the gb_cert_docs.
        /// </summary>
        public virtual ICollection<gb_cert_docs> GbCertDocs { get; set; }

        /// <summary>
        /// Gets or sets the gb_cert_log.
        /// </summary>
        public virtual ICollection<gb_cert_log> GbCertLog { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_sla_request.
        /// </summary>
        public virtual ICollection<helpdesk_sla_request> HelpdeskSlaRequest { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_sla_response.
        /// </summary>
        public virtual ICollection<helpdesk_sla_response> HelpdeskSlaResponse { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_sla_response 1.
        /// </summary>
        public virtual ICollection<helpdesk_sla_response> HelpdeskSlaResponse1 { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_sla_response 2.
        /// </summary>
        public virtual ICollection<helpdesk_sla_response> HelpdeskSlaResponse2 { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_sla_response 3.
        /// </summary>
        public virtual ICollection<helpdesk_sla_response> HelpdeskSlaResponse3 { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_sla_steps.
        /// </summary>
        public virtual ICollection<helpdesk_sla_steps> HelpdeskSlaSteps { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_step_log.
        /// </summary>
        public virtual ICollection<helpdesk_step_log> HelpdeskStepLog { get; set; }

        /// <summary>
        /// Gets or sets the jks.
        /// </summary>
        public virtual ICollection<jk> Jks { get; set; }

        /// <summary>
        /// Gets or sets the ls_amendment.
        /// </summary>
        public virtual ICollection<ls_amendment> ls_amendment { get; set; }

        /// <summary>
        /// Gets or sets the ls_comm.
        /// </summary>
        public virtual ICollection<ls_comm> ls_comm { get; set; }

        /// <summary>
        /// Gets or sets the moes.
        /// </summary>
        public virtual ICollection<mo> moes { get; set; }

        /// <summary>
        /// Gets or sets the moes 1.
        /// </summary>
        public virtual ICollection<mo> moes1 { get; set; }

        /// <summary>
        /// Gets or sets the moes 2.
        /// </summary>
        public virtual ICollection<mo> moes2 { get; set; }

        /// <summary>
        /// Gets or sets the moes 3.
        /// </summary>
        public virtual ICollection<mo> moes3 { get; set; }

        /// <summary>
        /// Gets or sets the mo_eq.
        /// </summary>
        public virtual ICollection<mo_eq> mo_eq { get; set; }

        /// <summary>
        /// Gets or sets the moes 4.
        /// </summary>
        public virtual ICollection<mo> moes4 { get; set; }

        /// <summary>
        /// Gets or sets the moes 5.
        /// </summary>
        public virtual ICollection<mo> moes5 { get; set; }

        /// <summary>
        /// Gets or sets the mo_scenario_em.
        /// </summary>
        public virtual ICollection<MoScenarioEm> mo_scenario_em { get; set; }

        /// <summary>
        /// Gets or sets the mo_scenario.
        /// </summary>
        public virtual ICollection<mo_scenario> mo_scenario { get; set; }

        /// <summary>
        /// Gets or sets the mo_ta.
        /// </summary>
        public virtual ICollection<mo_ta> mo_ta { get; set; }

        /// <summary>
        /// Gets or sets the mps.
        /// </summary>
        public virtual ICollection<mp> mps { get; set; }

        /// <summary>
        /// Gets or sets the ops.
        /// </summary>
        public virtual ICollection<op> ops { get; set; }

        /// <summary>
        /// Gets or sets the parkings.
        /// </summary>
        public virtual ICollection<parking> parkings { get; set; }

        /// <summary>
        /// Gets or sets the poes.
        /// </summary>
        public virtual ICollection<po> poes { get; set; }

        /// <summary>
        /// Gets or sets the programs.
        /// </summary>
        public virtual ICollection<program> programs { get; set; }

        /// <summary>
        /// Gets or sets the projects.
        /// </summary>
        public virtual ICollection<project> projects { get; set; }

        /// <summary>
        /// Gets or sets the projects 1.
        /// </summary>
        public virtual ICollection<project> projects1 { get; set; }

        /// <summary>
        /// Gets or sets the projects 2.
        /// </summary>
        public virtual ICollection<project> projects2 { get; set; }

        /// <summary>
        /// Gets or sets the projects 3.
        /// </summary>
        public virtual ICollection<project> projects3 { get; set; }

        /// <summary>
        /// Gets or sets the projects 4.
        /// </summary>
        public virtual ICollection<project> projects4 { get; set; }

        /// <summary>
        /// Gets or sets the projects 5.
        /// </summary>
        public virtual ICollection<project> projects5 { get; set; }

        /// <summary>
        /// Gets or sets the recovery_team.
        /// </summary>
        public virtual ICollection<recovery_team> recovery_team { get; set; }

        /// <summary>
        /// Gets or sets the reglocs.
        /// </summary>
        public virtual ICollection<regloc> reglocs { get; set; }

        /// <summary>
        /// Gets or sets the regprograms.
        /// </summary>
        public virtual ICollection<regprogram> regprograms { get; set; }

        /// <summary>
        /// Gets or sets the regrequirements.
        /// </summary>
        public virtual ICollection<regrequirement> regrequirements { get; set; }

        /// <summary>
        /// Gets or sets the reserve_rm.
        /// </summary>
        public virtual ICollection<reserve_rm> reserve_rm { get; set; }

        /// <summary>
        /// Gets or sets the reserve_rs.
        /// </summary>
        public virtual ICollection<reserve_rs> reserve_rs { get; set; }

        /// <summary>
        /// Gets or sets the reserves.
        /// </summary>
        public virtual ICollection<reserve> reserves { get; set; }

        /// <summary>
        /// Gets or sets the reserves 1.
        /// </summary>
        public virtual ICollection<reserve> reserves1 { get; set; }

        /// <summary>
        /// Gets or sets the reserves 2.
        /// </summary>
        public virtual ICollection<reserve> reserves2 { get; set; }

        /// <summary>
        /// Gets or sets the reserves 3.
        /// </summary>
        public virtual ICollection<reserve> reserves3 { get; set; }

        /// <summary>
        /// Gets or sets the rm_reserve.
        /// </summary>
        public virtual ICollection<rm_reserve> rm_reserve { get; set; }

        /// <summary>
        /// Gets or sets the status_log.
        /// </summary>
        public virtual ICollection<status_log> status_log { get; set; }

        /// <summary>
        /// Gets or sets the surveys.
        /// </summary>
        public virtual ICollection<survey> surveys { get; set; }

        /// <summary>
        /// Gets or sets the surveymob_sync.
        /// </summary>
        public virtual ICollection<surveymob_sync> surveymob_sync { get; set; }

        /// <summary>
        /// Gets or sets the ta_audit.
        /// </summary>
        public virtual ICollection<ta_audit> ta_audit { get; set; }

        /// <summary>
        /// Gets or sets the tas.
        /// </summary>
        public virtual ICollection<ta> tas { get; set; }

        /// <summary>
        /// Gets or sets the ta_fnstdcnts.
        /// </summary>
        public virtual ICollection<ta_fnstdcnts> ta_fnstdcnts { get; set; }

        /// <summary>
        /// Gets or sets the visitors.
        /// </summary>
        public virtual ICollection<visitor> visitors { get; set; }

        /// <summary>
        /// Gets or sets the woes.
        /// </summary>
        public virtual ICollection<wo> woes { get; set; }

        /// <summary>
        /// Gets or sets the woes 1.
        /// </summary>
        public virtual ICollection<wo> woes1 { get; set; }

        /// <summary>
        /// Gets or sets the woes 2.
        /// </summary>
        public virtual ICollection<wo> woes2 { get; set; }

        /// <summary>
        /// Gets or sets the woes 3.
        /// </summary>
        public virtual ICollection<wo> woes3 { get; set; }

        /// <summary>
        /// Gets or sets the work_categories_em.
        /// </summary>
        public virtual ICollection<work_categories_em> work_categories_em { get; set; }

        /// <summary>
        /// Gets or sets the work_pkg_bids.
        /// </summary>
        public virtual ICollection<work_pkg_bids> work_pkg_bids { get; set; }

        /// <summary>
        /// Gets or sets the work_pkgs.
        /// </summary>
        public virtual ICollection<work_pkgs> work_pkgs { get; set; }

        /// <summary>
        /// Gets or sets the work_roles_location.
        /// </summary>
        public virtual ICollection<work_roles_location> work_roles_location { get; set; }

        /// <summary>
        /// Gets or sets the workflow_substitutes.
        /// </summary>
        public virtual ICollection<workflow_substitutes> workflow_substitutes { get; set; }

        /// <summary>
        /// Gets or sets the workflow_substitutes 1.
        /// </summary>
        public virtual ICollection<workflow_substitutes> workflow_substitutes1 { get; set; }

        /// <summary>
        /// Gets or sets the wrs.
        /// </summary>
        public virtual ICollection<wr> wrs { get; set; }

        /// <summary>
        /// Gets or sets the wrs 1.
        /// </summary>
        public virtual ICollection<wr> wrs1 { get; set; }

        /// <summary>
        /// Gets or sets the wrs 2.
        /// </summary>
        public virtual ICollection<wr> wrs2 { get; set; }

        /// <summary>
        /// Gets or sets the wrs 3.
        /// </summary>
        public virtual ICollection<wr> wrs3 { get; set; }

        /// <summary>
        /// Gets or sets the wrs 4.
        /// </summary>
        public virtual ICollection<wr> wrs4 { get; set; }
    }
}