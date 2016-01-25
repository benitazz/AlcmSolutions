#region

using System.Data.Entity;

using DurandalAuth.Domain.Models;
using DurandalAuth.Domain.Models.Mapping;

using Microsoft.AspNet.Identity.EntityFramework;

#endregion

namespace DurandalAuth.Data
{
    /// <summary>
    /// The ihome context.
    /// </summary>
    public class DurandalAuthDbContext : IdentityDbContext<UserProfile>
    {
        /// <summary>
        /// Initializes static members of the <see cref="DurandalAuthDbContext"/> class.
        /// </summary>
        static DurandalAuthDbContext()
        {
            Database.SetInitializer<DurandalAuthDbContext>(null);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DurandalAuthDbContext"/> class.
        /// </summary>
        public DurandalAuthDbContext()
            : base("Name=DurandalAuthDbContext")
        {
           // Database.SetInitializer(new MigrateDatabaseToLatestVersion<DurandalAuthDbContext, Configuration>());
        }

        /// <summary>
        /// Gets or sets the acs.
        /// </summary>
        public DbSet<ac> acs { get; set; }

        /// <summary>
        /// Gets or sets the acbus.
        /// </summary>
        public DbSet<acbu> acbus { get; set; }

        /// <summary>
        /// Gets or sets the active_plantypes.
        /// </summary>
        public DbSet<active_plantypes> active_plantypes { get; set; }

        /// <summary>
        /// Gets or sets the activity_log.
        /// </summary>
        public DbSet<activity_log> activity_log { get; set; }

        /// <summary>
        /// Gets or sets the activity_log_sync.
        /// </summary>
        public DbSet<activity_log_sync> activity_log_sync { get; set; }

        /// <summary>
        /// Gets or sets the activity_log_trans.
        /// </summary>
        public DbSet<activity_log_trans> activity_log_trans { get; set; }

        /// <summary>
        /// Gets or sets the activitytypes.
        /// </summary>
        public DbSet<activitytype> activitytypes { get; set; }

        /// <summary>
        /// Gets or sets the actscns.
        /// </summary>
        public DbSet<actscn> actscns { get; set; }

        /// <summary>
        /// Gets or sets the advisories.
        /// </summary>
        public DbSet<advisory> advisories { get; set; }

        /// <summary>
        /// Gets or sets the afm_act_tbls.
        /// </summary>
        public DbSet<afm_act_tbls> afm_act_tbls { get; set; }

        /// <summary>
        /// Gets or sets the afm_activities.
        /// </summary>
        public DbSet<afm_activities> afm_activities { get; set; }

        /// <summary>
        /// Gets or sets the afm_activity_cats.
        /// </summary>
        public DbSet<afm_activity_cats> afm_activity_cats { get; set; }

        /// <summary>
        /// Gets or sets the afm_activity_params.
        /// </summary>
        public DbSet<afm_activity_params> afm_activity_params { get; set; }

        /// <summary>
        /// Gets or sets the afm_actprods.
        /// </summary>
        public DbSet<afm_actprods> afm_actprods { get; set; }

        /// <summary>
        /// Gets or sets the afm_acts.
        /// </summary>
        public DbSet<afm_acts> afm_acts { get; set; }

        /// <summary>
        /// Gets or sets the afm_atyp.
        /// </summary>
        public DbSet<afm_atyp> afm_atyp { get; set; }

        /// <summary>
        /// Gets or sets the afm_bim_categories.
        /// </summary>
        public DbSet<afm_bim_categories> afm_bim_categories { get; set; }

        /// <summary>
        /// Gets or sets the afm_bim_families.
        /// </summary>
        public DbSet<afm_bim_families> afm_bim_families { get; set; }

        /// <summary>
        /// Gets or sets the afm_bim_params.
        /// </summary>
        public DbSet<afm_bim_params> afm_bim_params { get; set; }

        /// <summary>
        /// Gets or sets the afm_cal_dates.
        /// </summary>
        public DbSet<afm_cal_dates> afm_cal_dates { get; set; }

        /// <summary>
        /// Gets or sets the afm_cats.
        /// </summary>
        public DbSet<afm_cats> afm_cats { get; set; }

        /// <summary>
        /// Gets or sets the afm_class.
        /// </summary>
        public DbSet<afm_class> afm_class { get; set; }

        /// <summary>
        /// Gets or sets the afm_conn_flds.
        /// </summary>
        public DbSet<afm_conn_flds> afm_conn_flds { get; set; }

        /// <summary>
        /// Gets or sets the afm_conn_log.
        /// </summary>
        public DbSet<afm_conn_log> afm_conn_log { get; set; }

        /// <summary>
        /// Gets or sets the afm_conn_rule_cat.
        /// </summary>
        public DbSet<afm_conn_rule_cat> afm_conn_rule_cat { get; set; }

        /// <summary>
        /// Gets or sets the afm_connector.
        /// </summary>
        public DbSet<afm_connector> afm_connector { get; set; }

        /// <summary>
        /// Gets or sets the afm_conversions.
        /// </summary>
        public DbSet<afm_conversions> afm_conversions { get; set; }

        /// <summary>
        /// Gets or sets the afm_currencies.
        /// </summary>
        public DbSet<afm_currencies> afm_currencies { get; set; }

        /// <summary>
        /// Gets or sets the afm_data_event_log.
        /// </summary>
        public DbSet<afm_data_event_log> afm_data_event_log { get; set; }

        /// <summary>
        /// Gets or sets the afm_docs.
        /// </summary>
        public DbSet<afm_docs> afm_docs { get; set; }

        /// <summary>
        /// Gets or sets the afm_docvers.
        /// </summary>
        public DbSet<afm_docvers> afm_docvers { get; set; }

        /// <summary>
        /// Gets or sets the afm_docversarch.
        /// </summary>
        public DbSet<afm_docversarch> afm_docversarch { get; set; }

        /// <summary>
        /// Gets or sets the afm_dwgpub.
        /// </summary>
        public DbSet<afm_dwgpub> afm_dwgpub { get; set; }

        /// <summary>
        /// Gets or sets the afm_dwgs.
        /// </summary>
        public DbSet<afm_dwgs> afm_dwgs { get; set; }

        /// <summary>
        /// Gets or sets the afm_dwgvers.
        /// </summary>
        public DbSet<afm_dwgvers> afm_dwgvers { get; set; }

        /// <summary>
        /// Gets or sets the afm_flds.
        /// </summary>
        public DbSet<afm_flds> afm_flds { get; set; }

        /// <summary>
        /// Gets or sets the afm_flds_lang.
        /// </summary>
        public DbSet<afm_flds_lang> afm_flds_lang { get; set; }

        /// <summary>
        /// Gets or sets the afm_flds_trans.
        /// </summary>
        public DbSet<afm_flds_trans> afm_flds_trans { get; set; }

        /// <summary>
        /// Gets or sets the afm_groups.
        /// </summary>
        public DbSet<afm_groups> afm_groups { get; set; }

        /// <summary>
        /// Gets or sets the afm_groupsforroles.
        /// </summary>
        public DbSet<afm_groupsforroles> afm_groupsforroles { get; set; }

        /// <summary>
        /// Gets or sets the afm_hmetric_trend_values.
        /// </summary>
        public DbSet<afm_hmetric_trend_values> afm_hmetric_trend_values { get; set; }

        /// <summary>
        /// Gets or sets the afm_holiday_dates.
        /// </summary>
        public DbSet<afm_holiday_dates> afm_holiday_dates { get; set; }

        /// <summary>
        /// Gets or sets the afm_hotlist.
        /// </summary>
        public DbSet<afm_hotlist> afm_hotlist { get; set; }

        /// <summary>
        /// Gets or sets the afm_layr.
        /// </summary>
        public DbSet<afm_layr> afm_layr { get; set; }

        /// <summary>
        /// Gets or sets the afm_metric_definitions.
        /// </summary>
        public DbSet<afm_metric_definitions> afm_metric_definitions { get; set; }

        /// <summary>
        /// Gets or sets the afm_metric_gran_defs.
        /// </summary>
        public DbSet<afm_metric_gran_defs> afm_metric_gran_defs { get; set; }

        /// <summary>
        /// Gets or sets the afm_metric_grans.
        /// </summary>
        public DbSet<afm_metric_grans> afm_metric_grans { get; set; }

        /// <summary>
        /// Gets or sets the afm_metric_scard_defs.
        /// </summary>
        public DbSet<afm_metric_scard_defs> afm_metric_scard_defs { get; set; }

        /// <summary>
        /// Gets or sets the afm_metric_scards.
        /// </summary>
        public DbSet<afm_metric_scards> afm_metric_scards { get; set; }

        /// <summary>
        /// Gets or sets the afm_metric_trend_values.
        /// </summary>
        public DbSet<afm_metric_trend_values> afm_metric_trend_values { get; set; }

        /// <summary>
        /// Gets or sets the afm_mobile_apps.
        /// </summary>
        public DbSet<afm_mobile_apps> afm_mobile_apps { get; set; }

        /// <summary>
        /// Gets or sets the afm_mobile_menu.
        /// </summary>
        public DbSet<afm_mobile_menu> afm_mobile_menu { get; set; }

        /// <summary>
        /// Gets or sets the afm_mods.
        /// </summary>
        public DbSet<afm_mods> afm_mods { get; set; }

        /// <summary>
        /// Gets or sets the afm_notifications_log.
        /// </summary>
        public DbSet<afm_notifications_log> afm_notifications_log { get; set; }

        /// <summary>
        /// Gets or sets the afm_processes.
        /// </summary>
        public DbSet<afm_processes> afm_processes { get; set; }

        /// <summary>
        /// Gets or sets the afm_products.
        /// </summary>
        public DbSet<afm_products> afm_products { get; set; }

        /// <summary>
        /// Gets or sets the afm_psubtasks.
        /// </summary>
        public DbSet<afm_psubtasks> afm_psubtasks { get; set; }

        /// <summary>
        /// Gets or sets the afm_ptasks.
        /// </summary>
        public DbSet<afm_ptasks> afm_ptasks { get; set; }

        /// <summary>
        /// Gets or sets the afm_redlines.
        /// </summary>
        public DbSet<afm_redlines> afm_redlines { get; set; }

        /// <summary>
        /// Gets or sets the afm_roleprocs.
        /// </summary>
        public DbSet<afm_roleprocs> afm_roleprocs { get; set; }

        /// <summary>
        /// Gets or sets the afm_roles.
        /// </summary>
        public DbSet<afm_roles> afm_roles { get; set; }

        /// <summary>
        /// Gets or sets the afm_scmpref.
        /// </summary>
        public DbSet<afm_scmpref> afm_scmpref { get; set; }

        /// <summary>
        /// Gets or sets the afm_subtasks.
        /// </summary>
        public DbSet<afm_subtasks> afm_subtasks { get; set; }

        /// <summary>
        /// Gets or sets the afm_tasks.
        /// </summary>
        public DbSet<afm_tasks> afm_tasks { get; set; }

        /// <summary>
        /// Gets or sets the afm_tbl_map.
        /// </summary>
        public DbSet<afm_tbl_map> afm_tbl_map { get; set; }

        /// <summary>
        /// Gets or sets the afm_tbls.
        /// </summary>
        public DbSet<afm_tbls> afm_tbls { get; set; }

        /// <summary>
        /// Gets or sets the afm_tccn.
        /// </summary>
        public DbSet<afm_tccn> afm_tccn { get; set; }

        /// <summary>
        /// Gets or sets the afm_tclevel.
        /// </summary>
        public DbSet<afm_tclevel> afm_tclevel { get; set; }

        /// <summary>
        /// Gets or sets the afm_tctrace.
        /// </summary>
        public DbSet<afm_tctrace> afm_tctrace { get; set; }

        /// <summary>
        /// Gets or sets the afm_timezones.
        /// </summary>
        public DbSet<afm_timezones> afm_timezones { get; set; }

        /// <summary>
        /// Gets or sets the afm_titlesheet.
        /// </summary>
        public DbSet<afm_titlesheet> afm_titlesheet { get; set; }

        /// <summary>
        /// Gets or sets the afm_transfer_set.
        /// </summary>
        public DbSet<afm_transfer_set> afm_transfer_set { get; set; }

        /// <summary>
        /// Gets or sets the afm_userprocs.
        /// </summary>
        public DbSet<afm_userprocs> afm_userprocs { get; set; }

        /// <summary>
        /// Gets or sets the afm_users.
        /// </summary>
        public DbSet<afm_users> afm_users { get; set; }

        /// <summary>
        /// Gets or sets the afm_wf_log.
        /// </summary>
        public DbSet<afm_wf_log> afm_wf_log { get; set; }

        /// <summary>
        /// Gets or sets the afm_wf_rules.
        /// </summary>
        public DbSet<afm_wf_rules> afm_wf_rules { get; set; }

        /// <summary>
        /// Gets or sets the afm_wf_steps.
        /// </summary>
        public DbSet<afm_wf_steps> afm_wf_steps { get; set; }

        /// <summary>
        /// Gets or sets the bar_code_list.
        /// </summary>
        public DbSet<bar_code_list> bar_code_list { get; set; }

        /// <summary>
        /// Gets or sets the bas_data_clean_num.
        /// </summary>
        public DbSet<bas_data_clean_num> bas_data_clean_num { get; set; }

        /// <summary>
        /// Gets or sets the bas_data_point.
        /// </summary>
        public DbSet<bas_data_point> bas_data_point { get; set; }

        /// <summary>
        /// Gets or sets the bas_data_time_norm_num.
        /// </summary>
        public DbSet<bas_data_time_norm_num> bas_data_time_norm_num { get; set; }

        /// <summary>
        /// Gets or sets the bas_measurement_scope.
        /// </summary>
        public DbSet<bas_measurement_scope> bas_measurement_scope { get; set; }

        /// <summary>
        /// Gets or sets the bills.
        /// </summary>
        public DbSet<bill> bills { get; set; }

        /// <summary>
        /// Gets or sets the bill_archive.
        /// </summary>
        public DbSet<bill_archive> bill_archive { get; set; }

        /// <summary>
        /// Gets or sets the bill_connector.
        /// </summary>
        public DbSet<bill_connector> bill_connector { get; set; }

        /// <summary>
        /// Gets or sets the bill_line.
        /// </summary>
        public DbSet<bill_line> bill_line { get; set; }

        /// <summary>
        /// Gets or sets the bill_line_archive.
        /// </summary>
        public DbSet<bill_line_archive> bill_line_archive { get; set; }

        /// <summary>
        /// Gets or sets the bill_type.
        /// </summary>
        public DbSet<bill_type> bill_type { get; set; }

        /// <summary>
        /// Gets or sets the bill_unit.
        /// </summary>
        public DbSet<bill_unit> bill_unit { get; set; }

        /// <summary>
        /// Gets or sets the bls.
        /// </summary>
        public DbSet<bl> bls { get; set; }

        /// <summary>
        /// Gets or sets the bl_amenity.
        /// </summary>
        public DbSet<bl_amenity> bl_amenity { get; set; }

        /// <summary>
        /// Gets or sets the blbus.
        /// </summary>
        public DbSet<blbu> blbus { get; set; }

        /// <summary>
        /// Gets or sets the bus.
        /// </summary>
        public DbSet<bu> bus { get; set; }

        /// <summary>
        /// Gets or sets the budgets.
        /// </summary>
        public DbSet<budget> budgets { get; set; }

        /// <summary>
        /// Gets or sets the budget_item.
        /// </summary>
        public DbSet<budget_item> budget_item { get; set; }

        /// <summary>
        /// Gets or sets the cas.
        /// </summary>
        public DbSet<ca> cas { get; set; }

        /// <summary>
        /// Gets or sets the cards.
        /// </summary>
        public DbSet<card> cards { get; set; }

        /// <summary>
        /// Gets or sets the cardstds.
        /// </summary>
        public DbSet<cardstd> cardstds { get; set; }

        /// <summary>
        /// Gets or sets the castds.
        /// </summary>
        public DbSet<castd> castds { get; set; }

        /// <summary>
        /// Gets or sets the catypes.
        /// </summary>
        public DbSet<catype> catypes { get; set; }

        /// <summary>
        /// Gets or sets the causetyps.
        /// </summary>
        public DbSet<causetyp> causetyps { get; set; }

        /// <summary>
        /// Gets or sets the cb_accredit_person.
        /// </summary>
        public DbSet<cb_accredit_person> cb_accredit_person { get; set; }

        /// <summary>
        /// Gets or sets the cb_accredit_source.
        /// </summary>
        public DbSet<cb_accredit_source> cb_accredit_source { get; set; }

        /// <summary>
        /// Gets or sets the cb_accredit_type.
        /// </summary>
        public DbSet<cb_accredit_type> cb_accredit_type { get; set; }

        /// <summary>
        /// Gets or sets the cb_hazard_rank.
        /// </summary>
        public DbSet<cb_hazard_rank> cb_hazard_rank { get; set; }

        /// <summary>
        /// Gets or sets the cb_hazard_rating.
        /// </summary>
        public DbSet<cb_hazard_rating> cb_hazard_rating { get; set; }

        /// <summary>
        /// Gets or sets the cb_hazard_status.
        /// </summary>
        public DbSet<cb_hazard_status> cb_hazard_status { get; set; }

        /// <summary>
        /// Gets or sets the cb_hcm.
        /// </summary>
        public DbSet<cb_hcm> cb_hcm { get; set; }

        /// <summary>
        /// Gets or sets the cb_hcm_class.
        /// </summary>
        public DbSet<cb_hcm_class> cb_hcm_class { get; set; }

        /// <summary>
        /// Gets or sets the cb_hcm_cond.
        /// </summary>
        public DbSet<cb_hcm_cond> cb_hcm_cond { get; set; }

        /// <summary>
        /// Gets or sets the cb_hcm_loc_typ.
        /// </summary>
        public DbSet<cb_hcm_loc_typ> cb_hcm_loc_typ { get; set; }

        /// <summary>
        /// Gets or sets the cb_hcm_places.
        /// </summary>
        public DbSet<cb_hcm_places> cb_hcm_places { get; set; }

        /// <summary>
        /// Gets or sets the cb_sample_comp.
        /// </summary>
        public DbSet<cb_sample_comp> cb_sample_comp { get; set; }

        /// <summary>
        /// Gets or sets the cb_sample_result.
        /// </summary>
        public DbSet<cb_sample_result> cb_sample_result { get; set; }

        /// <summary>
        /// Gets or sets the cb_samples.
        /// </summary>
        public DbSet<cb_samples> cb_samples { get; set; }

        /// <summary>
        /// Gets or sets the cb_units.
        /// </summary>
        public DbSet<cb_units> cb_units { get; set; }

        /// <summary>
        /// Gets or sets the cbudcmprs.
        /// </summary>
        public DbSet<cbudcmpr> cbudcmprs { get; set; }

        /// <summary>
        /// Gets or sets the ccost_sum.
        /// </summary>
        public DbSet<ccost_sum> ccost_sum { get; set; }

        /// <summary>
        /// Gets or sets the ccostprjns.
        /// </summary>
        public DbSet<ccostprjn> ccostprjns { get; set; }

        /// <summary>
        /// Gets or sets the ccshflws.
        /// </summary>
        public DbSet<ccshflw> ccshflws { get; set; }

        /// <summary>
        /// Gets or sets the cdports.
        /// </summary>
        public DbSet<cdport> cdports { get; set; }

        /// <summary>
        /// Gets or sets the cfs.
        /// </summary>
        public DbSet<cf> cfs { get; set; }

        /// <summary>
        /// Gets or sets the checkins.
        /// </summary>
        public DbSet<checkin> checkins { get; set; }

        /// <summary>
        /// Gets or sets the cities.
        /// </summary>
        public DbSet<City> cities { get; set; }

        /// <summary>
        /// Gets or sets the combexts.
        /// </summary>
        public DbSet<combext> combexts { get; set; }

        /// <summary>
        /// Gets or sets the commsubs.
        /// </summary>
        public DbSet<commsub> commsubs { get; set; }

        /// <summary>
        /// Gets or sets the commtypes.
        /// </summary>
        public DbSet<commtype> commtypes { get; set; }

        /// <summary>
        /// Gets or sets the companies.
        /// </summary>
        public DbSet<Company> companies { get; set; }

        /// <summary>
        /// Gets or sets the compliance_locations.
        /// </summary>
        public DbSet<compliance_locations> compliance_locations { get; set; }

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        public DbSet<Contact> contacts { get; set; }

        /// <summary>
        /// Gets or sets the cost_cat.
        /// </summary>
        public DbSet<cost_cat> cost_cat { get; set; }

        /// <summary>
        /// Gets or sets the cost_class.
        /// </summary>
        public DbSet<cost_class> cost_class { get; set; }

        /// <summary>
        /// Gets or sets the cost_index.
        /// </summary>
        public DbSet<cost_index> cost_index { get; set; }

        /// <summary>
        /// Gets or sets the cost_index_trans.
        /// </summary>
        public DbSet<cost_index_trans> cost_index_trans { get; set; }

        /// <summary>
        /// Gets or sets the cost_index_values.
        /// </summary>
        public DbSet<cost_index_values> cost_index_values { get; set; }

        /// <summary>
        /// Gets or sets the cost_tran.
        /// </summary>
        public DbSet<cost_tran> cost_tran { get; set; }

        /// <summary>
        /// Gets or sets the cost_tran_recur.
        /// </summary>
        public DbSet<cost_tran_recur> cost_tran_recur { get; set; }

        /// <summary>
        /// Gets or sets the cost_tran_sched.
        /// </summary>
        public DbSet<cost_tran_sched> cost_tran_sched { get; set; }

        /// <summary>
        /// Gets or sets the counties.
        /// </summary>
        public DbSet<County> counties { get; set; }

        /// <summary>
        /// Gets or sets the cps.
        /// </summary>
        public DbSet<cp> cps { get; set; }

        /// <summary>
        /// Gets or sets the csis.
        /// </summary>
        public DbSet<csi> csis { get; set; }

        /// <summary>
        /// Gets or sets the ctries.
        /// </summary>
        public DbSet<ctry> ctries { get; set; }

        /// <summary>
        /// Gets or sets the dep_reports.
        /// </summary>
        public DbSet<dep_reports> dep_reports { get; set; }

        /// <summary>
        /// Gets or sets the doc_templates.
        /// </summary>
        public DbSet<doc_templates> doc_templates { get; set; }

        /// <summary>
        /// Gets or sets the doccats.
        /// </summary>
        public DbSet<doccat> doccats { get; set; }

        /// <summary>
        /// Gets or sets the docfolders.
        /// </summary>
        public DbSet<docfolder> docfolders { get; set; }

        /// <summary>
        /// Gets or sets the docs_assigned.
        /// </summary>
        public DbSet<docs_assigned> docs_assigned { get; set; }

        /// <summary>
        /// Gets or sets the docs_assigned_sync.
        /// </summary>
        public DbSet<docs_assigned_sync> docs_assigned_sync { get; set; }

        /// <summary>
        /// Gets or sets the doctypes.
        /// </summary>
        public DbSet<doctype> doctypes { get; set; }

        /// <summary>
        /// Gets or sets the dps.
        /// </summary>
        public DbSet<dp> dps { get; set; }

        /// <summary>
        /// Gets or sets the dpbus.
        /// </summary>
        public DbSet<dpbu> dpbus { get; set; }

        /// <summary>
        /// Gets or sets the drs.
        /// </summary>
        public DbSet<dr> drs { get; set; }

        /// <summary>
        /// Gets or sets the drfnshes.
        /// </summary>
        public DbSet<drfnsh> drfnshes { get; set; }

        /// <summary>
        /// Gets or sets the drfrmatls.
        /// </summary>
        public DbSet<drfrmatl> drfrmatls { get; set; }

        /// <summary>
        /// Gets or sets the drmatls.
        /// </summary>
        public DbSet<drmatl> drmatls { get; set; }

        /// <summary>
        /// Gets or sets the drstds.
        /// </summary>
        public DbSet<drstd> drstds { get; set; }

        /// <summary>
        /// Gets or sets the drtypes.
        /// </summary>
        public DbSet<drtype> drtypes { get; set; }

        /// <summary>
        /// Gets or sets the dvs.
        /// </summary>
        public DbSet<dv> dvs { get; set; }

        /// <summary>
        /// Gets or sets the ehs_chemicals.
        /// </summary>
        public DbSet<ehs_chemicals> ehs_chemicals { get; set; }

        /// <summary>
        /// Gets or sets the ehs_em_ppe_types.
        /// </summary>
        public DbSet<ehs_em_ppe_types> ehs_em_ppe_types { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incident_cause_cat.
        /// </summary>
        public DbSet<ehs_incident_cause_cat> ehs_incident_cause_cat { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incident_injury_areas.
        /// </summary>
        public DbSet<ehs_incident_injury_areas> ehs_incident_injury_areas { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incident_injury_cat.
        /// </summary>
        public DbSet<ehs_incident_injury_cat> ehs_incident_injury_cat { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incident_long_tm_ca.
        /// </summary>
        public DbSet<ehs_incident_long_tm_ca> ehs_incident_long_tm_ca { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incident_short_tm_ca.
        /// </summary>
        public DbSet<ehs_incident_short_tm_ca> ehs_incident_short_tm_ca { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incident_types.
        /// </summary>
        public DbSet<ehs_incident_types> ehs_incident_types { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incident_witness.
        /// </summary>
        public DbSet<ehs_incident_witness> ehs_incident_witness { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incident_witness_sync.
        /// </summary>
        public DbSet<ehs_incident_witness_sync> ehs_incident_witness_sync { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents.
        /// </summary>
        public DbSet<ehs_incidents> ehs_incidents { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents_sync.
        /// </summary>
        public DbSet<ehs_incidents_sync> ehs_incidents_sync { get; set; }

        /// <summary>
        /// Gets or sets the ehs_medical_mon_results.
        /// </summary>
        public DbSet<ehs_medical_mon_results> ehs_medical_mon_results { get; set; }

        /// <summary>
        /// Gets or sets the ehs_medical_monitoring.
        /// </summary>
        public DbSet<ehs_medical_monitoring> ehs_medical_monitoring { get; set; }

        /// <summary>
        /// Gets or sets the ehs_ppe_types.
        /// </summary>
        public DbSet<ehs_ppe_types> ehs_ppe_types { get; set; }

        /// <summary>
        /// Gets or sets the ehs_restriction_cat.
        /// </summary>
        public DbSet<ehs_restriction_cat> ehs_restriction_cat { get; set; }

        /// <summary>
        /// Gets or sets the ehs_restrictions.
        /// </summary>
        public DbSet<ehs_restrictions> ehs_restrictions { get; set; }

        /// <summary>
        /// Gets or sets the ehs_training.
        /// </summary>
        public DbSet<ehs_training> ehs_training { get; set; }

        /// <summary>
        /// Gets or sets the ehs_training_cat.
        /// </summary>
        public DbSet<ehs_training_cat> ehs_training_cat { get; set; }

        /// <summary>
        /// Gets or sets the ehs_training_results.
        /// </summary>
        public DbSet<ehs_training_results> ehs_training_results { get; set; }

        /// <summary>
        /// Gets or sets the ehs_training_types.
        /// </summary>
        public DbSet<ehs_training_types> ehs_training_types { get; set; }

        /// <summary>
        /// Gets or sets the ems.
        /// </summary>
        public DbSet<Em> ems { get; set; }

        /// <summary>
        /// Gets or sets the em_compinvtrial.
        /// </summary>
        public DbSet<em_compinvtrial> em_compinvtrial { get; set; }

        /// <summary>
        /// Gets or sets the em_sync.
        /// </summary>
        public DbSet<em_sync> em_sync { get; set; }

        /// <summary>
        /// Gets or sets the em_trial.
        /// </summary>
        public DbSet<em_trial> em_trial { get; set; }

        /// <summary>
        /// Gets or sets the emstds.
        /// </summary>
        public DbSet<emstd> emstds { get; set; }

        /// <summary>
        /// Gets or sets the emsums.
        /// </summary>
        public DbSet<emsum> emsums { get; set; }

        /// <summary>
        /// Gets or sets the energy_bl_svc_period.
        /// </summary>
        public DbSet<energy_bl_svc_period> energy_bl_svc_period { get; set; }

        /// <summary>
        /// Gets or sets the energy_chart_point.
        /// </summary>
        public DbSet<energy_chart_point> energy_chart_point { get; set; }

        /// <summary>
        /// Gets or sets the energy_time_period.
        /// </summary>
        public DbSet<energy_time_period> energy_time_period { get; set; }

        /// <summary>
        /// Gets or sets the eps.
        /// </summary>
        public DbSet<ep> eps { get; set; }

        /// <summary>
        /// Gets or sets the eqs.
        /// </summary>
        public DbSet<eq> eqs { get; set; }

        /// <summary>
        /// Gets or sets the eq_audit.
        /// </summary>
        public DbSet<eq_audit> eq_audit { get; set; }

        /// <summary>
        /// Gets or sets the eq_bar_code_list.
        /// </summary>
        public DbSet<eq_bar_code_list> eq_bar_code_list { get; set; }

        /// <summary>
        /// Gets or sets the eq_compinvsur.
        /// </summary>
        public DbSet<eq_compinvsur> eq_compinvsur { get; set; }

        /// <summary>
        /// Gets or sets the eq_compinvtrial.
        /// </summary>
        public DbSet<eq_compinvtrial> eq_compinvtrial { get; set; }

        /// <summary>
        /// Gets or sets the eq_dep.
        /// </summary>
        public DbSet<eq_dep> eq_dep { get; set; }

        /// <summary>
        /// Gets or sets the eq_eqstdcnts.
        /// </summary>
        public DbSet<eq_eqstdcnts> eq_eqstdcnts { get; set; }

        /// <summary>
        /// Gets or sets the eq_reserve.
        /// </summary>
        public DbSet<eq_reserve> eq_reserve { get; set; }

        /// <summary>
        /// Gets or sets the eq_sched.
        /// </summary>
        public DbSet<eq_sched> eq_sched { get; set; }

        /// <summary>
        /// Gets or sets the eq_trial.
        /// </summary>
        public DbSet<eq_trial> eq_trial { get; set; }

        /// <summary>
        /// Gets or sets the eqports.
        /// </summary>
        public DbSet<eqport> eqports { get; set; }

        /// <summary>
        /// Gets or sets the eqprphs.
        /// </summary>
        public DbSet<eqprph> eqprphs { get; set; }

        /// <summary>
        /// Gets or sets the eqstds.
        /// </summary>
        public DbSet<eqstd> eqstds { get; set; }

        /// <summary>
        /// Gets or sets the facility_type.
        /// </summary>
        public DbSet<facility_type> facility_type { get; set; }

        /// <summary>
        /// Gets or sets the fls.
        /// </summary>
        public DbSet<Fl> fls { get; set; }

        /// <summary>
        /// Gets or sets the fns.
        /// </summary>
        public DbSet<fn> fns { get; set; }

        /// <summary>
        /// Gets or sets the fn_compinvsur.
        /// </summary>
        public DbSet<fn_compinvsur> fn_compinvsur { get; set; }

        /// <summary>
        /// Gets or sets the fn_compinvtrial.
        /// </summary>
        public DbSet<fn_compinvtrial> fn_compinvtrial { get; set; }

        /// <summary>
        /// Gets or sets the fn_comptrialtrial.
        /// </summary>
        public DbSet<fn_comptrialtrial> fn_comptrialtrial { get; set; }

        /// <summary>
        /// Gets or sets the fn_fnstdcnts.
        /// </summary>
        public DbSet<fn_fnstdcnts> fn_fnstdcnts { get; set; }

        /// <summary>
        /// Gets or sets the fn_trial.
        /// </summary>
        public DbSet<fn_trial> fn_trial { get; set; }

        /// <summary>
        /// Gets or sets the fnstds.
        /// </summary>
        public DbSet<fnstd> fnstds { get; set; }

        /// <summary>
        /// Gets or sets the fps.
        /// </summary>
        public DbSet<fp> fps { get; set; }

        /// <summary>
        /// Gets or sets the fpstds.
        /// </summary>
        public DbSet<fpstd> fpstds { get; set; }

        /// <summary>
        /// Gets or sets the fs.
        /// </summary>
        public DbSet<f> fs { get; set; }

        /// <summary>
        /// Gets or sets the fundings.
        /// </summary>
        public DbSet<funding> fundings { get; set; }

        /// <summary>
        /// Gets or sets the gb_cert_cat.
        /// </summary>
        public DbSet<gb_cert_cat> gb_cert_cat { get; set; }

        /// <summary>
        /// Gets or sets the gb_cert_credits.
        /// </summary>
        public DbSet<gb_cert_credits> gb_cert_credits { get; set; }

        /// <summary>
        /// Gets or sets the gb_cert_docs.
        /// </summary>
        public DbSet<gb_cert_docs> gb_cert_docs { get; set; }

        /// <summary>
        /// Gets or sets the gb_cert_levels.
        /// </summary>
        public DbSet<gb_cert_levels> gb_cert_levels { get; set; }

        /// <summary>
        /// Gets or sets the gb_cert_log.
        /// </summary>
        public DbSet<gb_cert_log> gb_cert_log { get; set; }

        /// <summary>
        /// Gets or sets the gb_cert_proj.
        /// </summary>
        public DbSet<gb_cert_proj> gb_cert_proj { get; set; }

        /// <summary>
        /// Gets or sets the gb_cert_scores.
        /// </summary>
        public DbSet<gb_cert_scores> gb_cert_scores { get; set; }

        /// <summary>
        /// Gets or sets the gb_cert_std.
        /// </summary>
        public DbSet<gb_cert_std> gb_cert_std { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_airc_data.
        /// </summary>
        public DbSet<gb_fp_airc_data> gb_fp_airc_data { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_carbon_data.
        /// </summary>
        public DbSet<gb_fp_carbon_data> gb_fp_carbon_data { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_comm_airc_data.
        /// </summary>
        public DbSet<gb_fp_comm_airc_data> gb_fp_comm_airc_data { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_egrid_subregions.
        /// </summary>
        public DbSet<gb_fp_egrid_subregions> gb_fp_egrid_subregions { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_egrid_zip.
        /// </summary>
        public DbSet<gb_fp_egrid_zip> gb_fp_egrid_zip { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_emiss_data.
        /// </summary>
        public DbSet<gb_fp_emiss_data> gb_fp_emiss_data { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_energystar_fuels.
        /// </summary>
        public DbSet<gb_fp_energystar_fuels> gb_fp_energystar_fuels { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_fuel_dens_data.
        /// </summary>
        public DbSet<gb_fp_fuel_dens_data> gb_fp_fuel_dens_data { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_fuel_types.
        /// </summary>
        public DbSet<gb_fp_fuel_types> gb_fp_fuel_types { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_fuels.
        /// </summary>
        public DbSet<gb_fp_fuels> gb_fp_fuels { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_gwp_data.
        /// </summary>
        public DbSet<gb_fp_gwp_data> gb_fp_gwp_data { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_heat_data.
        /// </summary>
        public DbSet<gb_fp_heat_data> gb_fp_heat_data { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_mobile_data.
        /// </summary>
        public DbSet<gb_fp_mobile_data> gb_fp_mobile_data { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_oxid_data.
        /// </summary>
        public DbSet<gb_fp_oxid_data> gb_fp_oxid_data { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_refrig_data.
        /// </summary>
        public DbSet<gb_fp_refrig_data> gb_fp_refrig_data { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_s_other.
        /// </summary>
        public DbSet<gb_fp_s_other> gb_fp_s_other { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_s 1_co_airc.
        /// </summary>
        public DbSet<gb_fp_s1_co_airc> gb_fp_s1_co_airc { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_s 1_fuel_comb.
        /// </summary>
        public DbSet<gb_fp_s1_fuel_comb> gb_fp_s1_fuel_comb { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_s 1_refrig_ac.
        /// </summary>
        public DbSet<gb_fp_s1_refrig_ac> gb_fp_s1_refrig_ac { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_s 1_s 3_mobile.
        /// </summary>
        public DbSet<gb_fp_s1_s3_mobile> gb_fp_s1_s3_mobile { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_s 2_purch_e.
        /// </summary>
        public DbSet<gb_fp_s2_purch_e> gb_fp_s2_purch_e { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_s 3_em_air.
        /// </summary>
        public DbSet<gb_fp_s3_em_air> gb_fp_s3_em_air { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_s 3_mat.
        /// </summary>
        public DbSet<gb_fp_s3_mat> gb_fp_s3_mat { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_s 3_outs.
        /// </summary>
        public DbSet<gb_fp_s3_outs> gb_fp_s3_outs { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_s 3_serv.
        /// </summary>
        public DbSet<gb_fp_s3_serv> gb_fp_s3_serv { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_s 3_waste_liq.
        /// </summary>
        public DbSet<gb_fp_s3_waste_liq> gb_fp_s3_waste_liq { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_s 3_waste_sol.
        /// </summary>
        public DbSet<gb_fp_s3_waste_sol> gb_fp_s3_waste_sol { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_sectors.
        /// </summary>
        public DbSet<gb_fp_sectors> gb_fp_sectors { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_setup.
        /// </summary>
        public DbSet<gb_fp_setup> gb_fp_setup { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_totals.
        /// </summary>
        public DbSet<gb_fp_totals> gb_fp_totals { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_versions.
        /// </summary>
        public DbSet<gb_fp_versions> gb_fp_versions { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_waste_liq_data.
        /// </summary>
        public DbSet<gb_fp_waste_liq_data> gb_fp_waste_liq_data { get; set; }

        /// <summary>
        /// Gets or sets the gb_fp_waste_sol_data.
        /// </summary>
        public DbSet<gb_fp_waste_sol_data> gb_fp_waste_sol_data { get; set; }

        /// <summary>
        /// Gets or sets the geo_region.
        /// </summary>
        public DbSet<geo_region> geo_region { get; set; }

        /// <summary>
        /// Gets or sets the gps.
        /// </summary>
        public DbSet<gp> gps { get; set; }

        /// <summary>
        /// Gets or sets the gpstds.
        /// </summary>
        public DbSet<gpstd> gpstds { get; set; }

        /// <summary>
        /// Gets or sets the gpsums.
        /// </summary>
        public DbSet<gpsum> gpsums { get; set; }

        /// <summary>
        /// Gets or sets the grids.
        /// </summary>
        public DbSet<grid> grids { get; set; }

        /// <summary>
        /// Gets or sets the gros.
        /// </summary>
        public DbSet<gro> gros { get; set; }

        /// <summary>
        /// Gets or sets the grps.
        /// </summary>
        public DbSet<grp> grps { get; set; }

        /// <summary>
        /// Gets or sets the grp_agency.
        /// </summary>
        public DbSet<grp_agency> grp_agency { get; set; }

        /// <summary>
        /// Gets or sets the grp_trans.
        /// </summary>
        public DbSet<grp_trans> grp_trans { get; set; }

        /// <summary>
        /// Gets or sets the grp_type.
        /// </summary>
        public DbSet<grp_type> grp_type { get; set; }

        /// <summary>
        /// Gets or sets the grp_use.
        /// </summary>
        public DbSet<grp_use> grp_use { get; set; }

        /// <summary>
        /// Gets or sets the hactivity_log.
        /// </summary>
        public DbSet<hactivity_log> hactivity_log { get; set; }

        /// <summary>
        /// Gets or sets the hazard_container_cat.
        /// </summary>
        public DbSet<hazard_container_cat> hazard_container_cat { get; set; }

        /// <summary>
        /// Gets or sets the hazard_container_type.
        /// </summary>
        public DbSet<hazard_container_type> hazard_container_type { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_roles.
        /// </summary>
        public DbSet<helpdesk_roles> helpdesk_roles { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_sla_request.
        /// </summary>
        public DbSet<helpdesk_sla_request> helpdesk_sla_request { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_sla_response.
        /// </summary>
        public DbSet<helpdesk_sla_response> helpdesk_sla_response { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_sla_steps.
        /// </summary>
        public DbSet<helpdesk_sla_steps> helpdesk_sla_steps { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_step_log.
        /// </summary>
        public DbSet<helpdesk_step_log> helpdesk_step_log { get; set; }

        /// <summary>
        /// Gets or sets the hhelpdesk_step_log.
        /// </summary>
        public DbSet<hhelpdesk_step_log> hhelpdesk_step_log { get; set; }

        /// <summary>
        /// Gets or sets the hist_em_count.
        /// </summary>
        public DbSet<hist_em_count> hist_em_count { get; set; }

        /// <summary>
        /// Gets or sets the hprorates.
        /// </summary>
        public DbSet<hprorate> hprorates { get; set; }

        /// <summary>
        /// Gets or sets the hreserves.
        /// </summary>
        public DbSet<hreserve> hreserves { get; set; }

        /// <summary>
        /// Gets or sets the hreserve_rm.
        /// </summary>
        public DbSet<hreserve_rm> hreserve_rm { get; set; }

        /// <summary>
        /// Gets or sets the hreserve_rs.
        /// </summary>
        public DbSet<hreserve_rs> hreserve_rs { get; set; }

        /// <summary>
        /// Gets or sets the hrmpcts.
        /// </summary>
        public DbSet<hrmpct> hrmpcts { get; set; }

        /// <summary>
        /// Gets or sets the hwoes.
        /// </summary>
        public DbSet<hwo> hwoes { get; set; }

        /// <summary>
        /// Gets or sets the hwrs.
        /// </summary>
        public DbSet<hwr> hwrs { get; set; }

        /// <summary>
        /// Gets or sets the hwr_other.
        /// </summary>
        public DbSet<hwr_other> hwr_other { get; set; }

        /// <summary>
        /// Gets or sets the hwrcfs.
        /// </summary>
        public DbSet<hwrcf> hwrcfs { get; set; }

        /// <summary>
        /// Gets or sets the hwrcfanas.
        /// </summary>
        public DbSet<hwrcfana> hwrcfanas { get; set; }

        /// <summary>
        /// Gets or sets the hwrpts.
        /// </summary>
        public DbSet<hwrpt> hwrpts { get; set; }

        /// <summary>
        /// Gets or sets the hwrsums.
        /// </summary>
        public DbSet<hwrsum> hwrsums { get; set; }

        /// <summary>
        /// Gets or sets the hwrtls.
        /// </summary>
        public DbSet<hwrtl> hwrtls { get; set; }

        /// <summary>
        /// Gets or sets the hwrtrs.
        /// </summary>
        public DbSet<hwrtr> hwrtrs { get; set; }

        /// <summary>
        /// Gets or sets the hwrtts.
        /// </summary>
        public DbSet<hwrtt> hwrtts { get; set; }

        /// <summary>
        /// Gets or sets the insurers.
        /// </summary>
        public DbSet<insurer> insurers { get; set; }

        /// <summary>
        /// Gets or sets the invoices.
        /// </summary>
        public DbSet<invoice> invoices { get; set; }

        /// <summary>
        /// Gets or sets the invoice_payment.
        /// </summary>
        public DbSet<invoice_payment> invoice_payment { get; set; }

        /// <summary>
        /// Gets or sets the it.
        /// </summary>
        public DbSet<it> it { get; set; }

        /// <summary>
        /// Gets or sets the jks.
        /// </summary>
        public DbSet<jk> jks { get; set; }

        /// <summary>
        /// Gets or sets the jkcfgs.
        /// </summary>
        public DbSet<jkcfg> jkcfgs { get; set; }

        /// <summary>
        /// Gets or sets the jkexts.
        /// </summary>
        public DbSet<jkext> jkexts { get; set; }

        /// <summary>
        /// Gets or sets the jkstds.
        /// </summary>
        public DbSet<jkstd> jkstds { get; set; }

        /// <summary>
        /// Gets or sets the lang_enum.
        /// </summary>
        public DbSet<lang_enum> lang_enum { get; set; }

        /// <summary>
        /// Gets or sets the lang_files.
        /// </summary>
        public DbSet<lang_files> lang_files { get; set; }

        /// <summary>
        /// Gets or sets the lang_glossary.
        /// </summary>
        public DbSet<lang_glossary> lang_glossary { get; set; }

        /// <summary>
        /// Gets or sets the lang_lang.
        /// </summary>
        public DbSet<lang_lang> lang_lang { get; set; }

        /// <summary>
        /// Gets or sets the lang_strings.
        /// </summary>
        public DbSet<lang_strings> lang_strings { get; set; }

        /// <summary>
        /// Gets or sets the lessors.
        /// </summary>
        public DbSet<lessor> lessors { get; set; }

        /// <summary>
        /// Gets or sets the ls.
        /// </summary>
        public DbSet<l> ls { get; set; }

        /// <summary>
        /// Gets or sets the ls_alert_definition.
        /// </summary>
        public DbSet<ls_alert_definition> ls_alert_definition { get; set; }

        /// <summary>
        /// Gets or sets the ls_amendment.
        /// </summary>
        public DbSet<ls_amendment> ls_amendment { get; set; }

        /// <summary>
        /// Gets or sets the ls_cam_profile.
        /// </summary>
        public DbSet<ls_cam_profile> ls_cam_profile { get; set; }

        /// <summary>
        /// Gets or sets the ls_cam_rec_report.
        /// </summary>
        public DbSet<ls_cam_rec_report> ls_cam_rec_report { get; set; }

        /// <summary>
        /// Gets or sets the ls_chrgbck_agree.
        /// </summary>
        public DbSet<ls_chrgbck_agree> ls_chrgbck_agree { get; set; }

        /// <summary>
        /// Gets or sets the ls_clause_type.
        /// </summary>
        public DbSet<ls_clause_type> ls_clause_type { get; set; }

        /// <summary>
        /// Gets or sets the ls_comm.
        /// </summary>
        public DbSet<ls_comm> ls_comm { get; set; }

        /// <summary>
        /// Gets or sets the ls_comm_log.
        /// </summary>
        public DbSet<ls_comm_log> ls_comm_log { get; set; }

        /// <summary>
        /// Gets or sets the ls_index_profile.
        /// </summary>
        public DbSet<ls_index_profile> ls_index_profile { get; set; }

        /// <summary>
        /// Gets or sets the ls_resp.
        /// </summary>
        public DbSet<ls_resp> ls_resp { get; set; }

        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        public DbSet<message> messages { get; set; }

        /// <summary>
        /// Gets or sets the moes.
        /// </summary>
        public DbSet<mo> moes { get; set; }

        /// <summary>
        /// Gets or sets the mo_churn.
        /// </summary>
        public DbSet<mo_churn> mo_churn { get; set; }

        /// <summary>
        /// Gets or sets the mo_eq.
        /// </summary>
        public DbSet<mo_eq> mo_eq { get; set; }

        /// <summary>
        /// Gets or sets the mo_fncount.
        /// </summary>
        public DbSet<mo_fncount> mo_fncount { get; set; }

        /// <summary>
        /// Gets or sets the mo_scenario.
        /// </summary>
        public DbSet<mo_scenario> mo_scenario { get; set; }

        /// <summary>
        /// Gets or sets the mo_scenario_em.
        /// </summary>
        public DbSet<MoScenarioEm> mo_scenario_em { get; set; }

        /// <summary>
        /// Gets or sets the mo_ta.
        /// </summary>
        public DbSet<mo_ta> mo_ta { get; set; }

        /// <summary>
        /// Gets or sets the mps.
        /// </summary>
        public DbSet<mp> mps { get; set; }

        /// <summary>
        /// Gets or sets the msds_chemical.
        /// </summary>
        public DbSet<msds_chemical> msds_chemical { get; set; }

        /// <summary>
        /// Gets or sets the msds_constituent.
        /// </summary>
        public DbSet<msds_constituent> msds_constituent { get; set; }

        /// <summary>
        /// Gets or sets the msds_data.
        /// </summary>
        public DbSet<msds_data> msds_data { get; set; }

        /// <summary>
        /// Gets or sets the msds_h_chemical.
        /// </summary>
        public DbSet<msds_h_chemical> msds_h_chemical { get; set; }

        /// <summary>
        /// Gets or sets the msds_h_constituent.
        /// </summary>
        public DbSet<msds_h_constituent> msds_h_constituent { get; set; }

        /// <summary>
        /// Gets or sets the msds_h_data.
        /// </summary>
        public DbSet<msds_h_data> msds_h_data { get; set; }

        /// <summary>
        /// Gets or sets the msds_h_haz_classification.
        /// </summary>
        public DbSet<msds_h_haz_classification> msds_h_haz_classification { get; set; }

        /// <summary>
        /// Gets or sets the msds_h_location.
        /// </summary>
        public DbSet<msds_h_location> msds_h_location { get; set; }

        /// <summary>
        /// Gets or sets the msds_haz_classification.
        /// </summary>
        public DbSet<msds_haz_classification> msds_haz_classification { get; set; }

        /// <summary>
        /// Gets or sets the msds_hazard_category.
        /// </summary>
        public DbSet<msds_hazard_category> msds_hazard_category { get; set; }

        /// <summary>
        /// Gets or sets the msds_hazard_class.
        /// </summary>
        public DbSet<msds_hazard_class> msds_hazard_class { get; set; }

        /// <summary>
        /// Gets or sets the msds_hazard_system.
        /// </summary>
        public DbSet<msds_hazard_system> msds_hazard_system { get; set; }

        /// <summary>
        /// Gets or sets the msds_location.
        /// </summary>
        public DbSet<msds_location> msds_location { get; set; }

        /// <summary>
        /// Gets or sets the ndports.
        /// </summary>
        public DbSet<ndport> ndports { get; set; }

        /// <summary>
        /// Gets or sets the nets.
        /// </summary>
        public DbSet<net> nets { get; set; }

        /// <summary>
        /// Gets or sets the netdevs.
        /// </summary>
        public DbSet<netdev> netdevs { get; set; }

        /// <summary>
        /// Gets or sets the netdevstds.
        /// </summary>
        public DbSet<netdevstd> netdevstds { get; set; }

        /// <summary>
        /// Gets or sets the notifications.
        /// </summary>
        public DbSet<notification> notifications { get; set; }

        /// <summary>
        /// Gets or sets the notify_templates.
        /// </summary>
        public DbSet<notify_templates> notify_templates { get; set; }

        /// <summary>
        /// Gets or sets the notifycats.
        /// </summary>
        public DbSet<notifycat> notifycats { get; set; }

        /// <summary>
        /// Gets or sets the ops.
        /// </summary>
        public DbSet<op> ops { get; set; }

        /// <summary>
        /// Gets or sets the orgs.
        /// </summary>
        public DbSet<org> orgs { get; set; }

        /// <summary>
        /// Gets or sets the ots.
        /// </summary>
        public DbSet<ot> ots { get; set; }

        /// <summary>
        /// Gets or sets the other_rs.
        /// </summary>
        public DbSet<other_rs> other_rs { get; set; }

        /// <summary>
        /// Gets or sets the pas.
        /// </summary>
        public DbSet<pa> pas { get; set; }

        /// <summary>
        /// Gets or sets the pa_dep.
        /// </summary>
        public DbSet<pa_dep> pa_dep { get; set; }

        /// <summary>
        /// Gets or sets the parcels.
        /// </summary>
        public DbSet<parcel> parcels { get; set; }

        /// <summary>
        /// Gets or sets the parkings.
        /// </summary>
        public DbSet<parking> parkings { get; set; }

        /// <summary>
        /// Gets or sets the parkingstds.
        /// </summary>
        public DbSet<parkingstd> parkingstds { get; set; }

        /// <summary>
        /// Gets or sets the pbs.
        /// </summary>
        public DbSet<pb> pbs { get; set; }

        /// <summary>
        /// Gets or sets the pbstds.
        /// </summary>
        public DbSet<pbstd> pbstds { get; set; }

        /// <summary>
        /// Gets or sets the pds.
        /// </summary>
        public DbSet<pd> pds { get; set; }

        /// <summary>
        /// Gets or sets the pmforecast_tr.
        /// </summary>
        public DbSet<pmforecast_tr> pmforecast_tr { get; set; }

        /// <summary>
        /// Gets or sets the pmforecast_trm.
        /// </summary>
        public DbSet<pmforecast_trm> pmforecast_trm { get; set; }

        /// <summary>
        /// Gets or sets the pmgens.
        /// </summary>
        public DbSet<pmgen> pmgens { get; set; }

        /// <summary>
        /// Gets or sets the pmgps.
        /// </summary>
        public DbSet<pmgp> pmgps { get; set; }

        /// <summary>
        /// Gets or sets the pmps.
        /// </summary>
        public DbSet<pmp> pmps { get; set; }

        /// <summary>
        /// Gets or sets the pmps 1.
        /// </summary>
        public DbSet<pmp1> pmps1 { get; set; }

        /// <summary>
        /// Gets or sets the pmpspts.
        /// </summary>
        public DbSet<pmpspt> pmpspts { get; set; }

        /// <summary>
        /// Gets or sets the pmpstrs.
        /// </summary>
        public DbSet<pmpstr> pmpstrs { get; set; }

        /// <summary>
        /// Gets or sets the pmpstts.
        /// </summary>
        public DbSet<pmpstt> pmpstts { get; set; }

        /// <summary>
        /// Gets or sets the pmpsums.
        /// </summary>
        public DbSet<pmpsum> pmpsums { get; set; }

        /// <summary>
        /// Gets or sets the pmressums.
        /// </summary>
        public DbSet<pmressum> pmressums { get; set; }

        /// <summary>
        /// Gets or sets the pms.
        /// </summary>
        public DbSet<Pm> pms { get; set; }

        /// <summary>
        /// Gets or sets the pmsds.
        /// </summary>
        public DbSet<pmsd> pmsds { get; set; }

        /// <summary>
        /// Gets or sets the pns.
        /// </summary>
        public DbSet<pn> pns { get; set; }

        /// <summary>
        /// Gets or sets the pnports.
        /// </summary>
        public DbSet<pnport> pnports { get; set; }

        /// <summary>
        /// Gets or sets the pnstds.
        /// </summary>
        public DbSet<pnstd> pnstds { get; set; }

        /// <summary>
        /// Gets or sets the poes.
        /// </summary>
        public DbSet<po> poes { get; set; }

        /// <summary>
        /// Gets or sets the po_line.
        /// </summary>
        public DbSet<po_line> po_line { get; set; }

        /// <summary>
        /// Gets or sets the policies.
        /// </summary>
        public DbSet<policy> policies { get; set; }

        /// <summary>
        /// Gets or sets the ports.
        /// </summary>
        public DbSet<port> ports { get; set; }

        /// <summary>
        /// Gets or sets the portcfgs.
        /// </summary>
        public DbSet<portcfg> portcfgs { get; set; }

        /// <summary>
        /// Gets or sets the portfolio_scenario.
        /// </summary>
        public DbSet<portfolio_scenario> portfolio_scenario { get; set; }

        /// <summary>
        /// Gets or sets the portstds.
        /// </summary>
        public DbSet<portstd> portstds { get; set; }

        /// <summary>
        /// Gets or sets the prs.
        /// </summary>
        public DbSet<pr> prs { get; set; }

        /// <summary>
        /// Gets or sets the probtypes.
        /// </summary>
        public DbSet<probtype> probtypes { get; set; }

        /// <summary>
        /// Gets or sets the prog_budget_items.
        /// </summary>
        public DbSet<prog_budget_items> prog_budget_items { get; set; }

        /// <summary>
        /// Gets or sets the programs.
        /// </summary>
        public DbSet<program> programs { get; set; }

        /// <summary>
        /// Gets or sets the programtypes.
        /// </summary>
        public DbSet<programtype> programtypes { get; set; }

        /// <summary>
        /// Gets or sets the proj_forecast.
        /// </summary>
        public DbSet<proj_forecast> proj_forecast { get; set; }

        /// <summary>
        /// Gets or sets the proj_forecast_item.
        /// </summary>
        public DbSet<proj_forecast_item> proj_forecast_item { get; set; }

        /// <summary>
        /// Gets or sets the projects.
        /// </summary>
        public DbSet<project> projects { get; set; }

        /// <summary>
        /// Gets or sets the projecttypes.
        /// </summary>
        public DbSet<projecttype> projecttypes { get; set; }

        /// <summary>
        /// Gets or sets the projfunds.
        /// </summary>
        public DbSet<projfund> projfunds { get; set; }

        /// <summary>
        /// Gets or sets the projphases.
        /// </summary>
        public DbSet<projphase> projphases { get; set; }

        /// <summary>
        /// Gets or sets the projscns.
        /// </summary>
        public DbSet<projscn> projscns { get; set; }

        /// <summary>
        /// Gets or sets the projteams.
        /// </summary>
        public DbSet<ProjectTeam> projteams { get; set; }

        /// <summary>
        /// Gets or sets the prop_amenity.
        /// </summary>
        public DbSet<prop_amenity> prop_amenity { get; set; }

        /// <summary>
        /// Gets or sets the prop_amenity_type.
        /// </summary>
        public DbSet<prop_amenity_type> prop_amenity_type { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        public DbSet<Property> properties { get; set; }

        /// <summary>
        /// Gets or sets the property_type.
        /// </summary>
        public DbSet<property_type> property_type { get; set; }

        /// <summary>
        /// Gets or sets the pts.
        /// </summary>
        public DbSet<pt> pts { get; set; }

        /// <summary>
        /// Gets or sets the pvs.
        /// </summary>
        public DbSet<pv> pvs { get; set; }

        /// <summary>
        /// Gets or sets the questionnaires.
        /// </summary>
        public DbSet<questionnaire> questionnaires { get; set; }

        /// <summary>
        /// Gets or sets the questionnaire_map.
        /// </summary>
        public DbSet<questionnaire_map> questionnaire_map { get; set; }

        /// <summary>
        /// Gets or sets the questions.
        /// </summary>
        public DbSet<question> questions { get; set; }

        /// <summary>
        /// Gets or sets the racks.
        /// </summary>
        public DbSet<rack> racks { get; set; }

        /// <summary>
        /// Gets or sets the recovery_team.
        /// </summary>
        public DbSet<recovery_team> recovery_team { get; set; }

        /// <summary>
        /// Gets or sets the regcats.
        /// </summary>
        public DbSet<regcat> regcats { get; set; }

        /// <summary>
        /// Gets or sets the regcomplevels.
        /// </summary>
        public DbSet<regcomplevel> regcomplevels { get; set; }

        /// <summary>
        /// Gets or sets the regcompliances.
        /// </summary>
        public DbSet<regcompliance> regcompliances { get; set; }

        /// <summary>
        /// Gets or sets the reglocs.
        /// </summary>
        public DbSet<regloc> reglocs { get; set; }

        /// <summary>
        /// Gets or sets the regns.
        /// </summary>
        public DbSet<regn> regns { get; set; }

        /// <summary>
        /// Gets or sets the regnotifies.
        /// </summary>
        public DbSet<regnotify> regnotifies { get; set; }

        /// <summary>
        /// Gets or sets the regprogcats.
        /// </summary>
        public DbSet<regprogcat> regprogcats { get; set; }

        /// <summary>
        /// Gets or sets the regprograms.
        /// </summary>
        public DbSet<regprogram> regprograms { get; set; }

        /// <summary>
        /// Gets or sets the regprogtypes.
        /// </summary>
        public DbSet<regprogtype> regprogtypes { get; set; }

        /// <summary>
        /// Gets or sets the regreqcats.
        /// </summary>
        public DbSet<regreqcat> regreqcats { get; set; }

        /// <summary>
        /// Gets or sets the regrequirements.
        /// </summary>
        public DbSet<regrequirement> regrequirements { get; set; }

        /// <summary>
        /// Gets or sets the regtypes.
        /// </summary>
        public DbSet<regtype> regtypes { get; set; }

        /// <summary>
        /// Gets or sets the regulations.
        /// </summary>
        public DbSet<regulation> regulations { get; set; }

        /// <summary>
        /// Gets or sets the regviolations.
        /// </summary>
        public DbSet<regviolation> regviolations { get; set; }

        /// <summary>
        /// Gets or sets the regviolationtyps.
        /// </summary>
        public DbSet<regviolationtyp> regviolationtyps { get; set; }

        /// <summary>
        /// Gets or sets the repairties.
        /// </summary>
        public DbSet<repairty> repairties { get; set; }

        /// <summary>
        /// Gets or sets the resavails.
        /// </summary>
        public DbSet<resavail> resavails { get; set; }

        /// <summary>
        /// Gets or sets the reserves.
        /// </summary>
        public DbSet<reserve> reserves { get; set; }

        /// <summary>
        /// Gets or sets the reserve_rm.
        /// </summary>
        public DbSet<reserve_rm> reserve_rm { get; set; }

        /// <summary>
        /// Gets or sets the reserve_rs.
        /// </summary>
        public DbSet<reserve_rs> reserve_rs { get; set; }

        /// <summary>
        /// Gets or sets the resource_std.
        /// </summary>
        public DbSet<resource_std> resource_std { get; set; }

        /// <summary>
        /// Gets or sets the resources.
        /// </summary>
        public DbSet<resource> resources { get; set; }

        /// <summary>
        /// Gets or sets the rfs.
        /// </summary>
        public DbSet<Rf> rfs { get; set; }

        /// <summary>
        /// Gets or sets the rf_activity.
        /// </summary>
        public DbSet<rf_activity> rf_activity { get; set; }

        /// <summary>
        /// Gets or sets the rf_reader.
        /// </summary>
        public DbSet<rf_reader> rf_reader { get; set; }

        /// <summary>
        /// Gets or sets the rffnshes.
        /// </summary>
        public DbSet<rffnsh> rffnshes { get; set; }

        /// <summary>
        /// Gets or sets the rfmatls.
        /// </summary>
        public DbSet<rfmatl> rfmatls { get; set; }

        /// <summary>
        /// Gets or sets the rms.
        /// </summary>
        public DbSet<Rm> rms { get; set; }

        /// <summary>
        /// Gets or sets the rm_amenity.
        /// </summary>
        public DbSet<rm_amenity> rm_amenity { get; set; }

        /// <summary>
        /// Gets or sets the rm_amenity_type.
        /// </summary>
        public DbSet<rm_amenity_type> rm_amenity_type { get; set; }

        /// <summary>
        /// Gets or sets the rm_arrange.
        /// </summary>
        public DbSet<rm_arrange> rm_arrange { get; set; }

        /// <summary>
        /// Gets or sets the rm_arrange_type.
        /// </summary>
        public DbSet<rm_arrange_type> rm_arrange_type { get; set; }

        /// <summary>
        /// Gets or sets the rm_config.
        /// </summary>
        public DbSet<rm_config> rm_config { get; set; }

        /// <summary>
        /// Gets or sets the rm_reserve.
        /// </summary>
        public DbSet<rm_reserve> rm_reserve { get; set; }

        /// <summary>
        /// Gets or sets the rm_resource_std.
        /// </summary>
        public DbSet<rm_resource_std> rm_resource_std { get; set; }

        /// <summary>
        /// Gets or sets the rm_trial.
        /// </summary>
        public DbSet<rm_trial> rm_trial { get; set; }

        /// <summary>
        /// Gets or sets the rmcats.
        /// </summary>
        public DbSet<rmcat> rmcats { get; set; }

        /// <summary>
        /// Gets or sets the rmpcts.
        /// </summary>
        public DbSet<rmpct> rmpcts { get; set; }

        /// <summary>
        /// Gets or sets the rmpctmob_sync.
        /// </summary>
        public DbSet<rmpctmob_sync> rmpctmob_sync { get; set; }

        /// <summary>
        /// Gets or sets the rmstds.
        /// </summary>
        public DbSet<rmstd> rmstds { get; set; }

        /// <summary>
        /// Gets or sets the rmstd_fn.
        /// </summary>
        public DbSet<rmstd_fn> rmstd_fn { get; set; }

        /// <summary>
        /// Gets or sets the rmsums.
        /// </summary>
        public DbSet<rmsum> rmsums { get; set; }

        /// <summary>
        /// Gets or sets the rmtypes.
        /// </summary>
        public DbSet<rmtype> rmtypes { get; set; }

        /// <summary>
        /// Gets or sets the rmuses.
        /// </summary>
        public DbSet<rmuse> rmuses { get; set; }

        /// <summary>
        /// Gets or sets the runoffareas.
        /// </summary>
        public DbSet<runoffarea> runoffareas { get; set; }

        /// <summary>
        /// Gets or sets the runofftypes.
        /// </summary>
        public DbSet<runofftype> runofftypes { get; set; }

        /// <summary>
        /// Gets or sets the sbs.
        /// </summary>
        public DbSet<sb> sbs { get; set; }

        /// <summary>
        /// Gets or sets the sb_items.
        /// </summary>
        public DbSet<sb_items> sb_items { get; set; }

        /// <summary>
        /// Gets or sets the sbaffins.
        /// </summary>
        public DbSet<sbaffin> sbaffins { get; set; }

        /// <summary>
        /// Gets or sets the sbperiods.
        /// </summary>
        public DbSet<sbperiod> sbperiods { get; set; }

        /// <summary>
        /// Gets or sets the scenarios.
        /// </summary>
        public DbSet<scenario> scenarios { get; set; }

        /// <summary>
        /// Gets or sets the servs.
        /// </summary>
        public DbSet<serv> servs { get; set; }

        /// <summary>
        /// Gets or sets the servconts.
        /// </summary>
        public DbSet<servcont> servconts { get; set; }

        /// <summary>
        /// Gets or sets the servstds.
        /// </summary>
        public DbSet<servstd> servstds { get; set; }

        /// <summary>
        /// Gets or sets the servsums.
        /// </summary>
        public DbSet<servsum> servsums { get; set; }

        /// <summary>
        /// Gets or sets the sites.
        /// </summary>
        public DbSet<site> sites { get; set; }

        /// <summary>
        /// Gets or sets the softinvs.
        /// </summary>
        public DbSet<softinv> softinvs { get; set; }

        /// <summary>
        /// Gets or sets the softstds.
        /// </summary>
        public DbSet<softstd> softstds { get; set; }

        /// <summary>
        /// Gets or sets the states.
        /// </summary>
        public DbSet<state> states { get; set; }

        /// <summary>
        /// Gets or sets the status_log.
        /// </summary>
        public DbSet<status_log> status_log { get; set; }

        /// <summary>
        /// Gets or sets the sus.
        /// </summary>
        public DbSet<su> sus { get; set; }

        /// <summary>
        /// Gets or sets the surveys.
        /// </summary>
        public DbSet<survey> surveys { get; set; }

        /// <summary>
        /// Gets or sets the surveymob_sync.
        /// </summary>
        public DbSet<surveymob_sync> surveymob_sync { get; set; }

        /// <summary>
        /// Gets or sets the surveyrm_sync.
        /// </summary>
        public DbSet<surveyrm_sync> surveyrm_sync { get; set; }

        /// <summary>
        /// Gets or sets the system_bl.
        /// </summary>
        public DbSet<system_bl> system_bl { get; set; }

        /// <summary>
        /// Gets or sets the system_dep.
        /// </summary>
        public DbSet<system_dep> system_dep { get; set; }

        /// <summary>
        /// Gets or sets the system_type.
        /// </summary>
        public DbSet<system_type> system_type { get; set; }

        /// <summary>
        /// Gets or sets the tas.
        /// </summary>
        public DbSet<ta> tas { get; set; }

        /// <summary>
        /// Gets or sets the ta_audit.
        /// </summary>
        public DbSet<ta_audit> ta_audit { get; set; }

        /// <summary>
        /// Gets or sets the ta_compinvsur.
        /// </summary>
        public DbSet<ta_compinvsur> ta_compinvsur { get; set; }

        /// <summary>
        /// Gets or sets the ta_compinvtrial.
        /// </summary>
        public DbSet<ta_compinvtrial> ta_compinvtrial { get; set; }

        /// <summary>
        /// Gets or sets the ta_dep.
        /// </summary>
        public DbSet<ta_dep> ta_dep { get; set; }

        /// <summary>
        /// Gets or sets the ta_fnstdcnts.
        /// </summary>
        public DbSet<ta_fnstdcnts> ta_fnstdcnts { get; set; }

        /// <summary>
        /// Gets or sets the ta_lease.
        /// </summary>
        public DbSet<ta_lease> ta_lease { get; set; }

        /// <summary>
        /// Gets or sets the ta_trial.
        /// </summary>
        public DbSet<ta_trial> ta_trial { get; set; }

        /// <summary>
        /// Gets or sets the telexts.
        /// </summary>
        public DbSet<telext> telexts { get; set; }

        /// <summary>
        /// Gets or sets the tls.
        /// </summary>
        public DbSet<tl> tls { get; set; }

        /// <summary>
        /// Gets or sets the trs.
        /// </summary>
        public DbSet<tr> trs { get; set; }

        /// <summary>
        /// Gets or sets the trialprojects.
        /// </summary>
        public DbSet<trialproject> trialprojects { get; set; }

        /// <summary>
        /// Gets or sets the tts.
        /// </summary>
        public DbSet<tt> tts { get; set; }

        /// <summary>
        /// Gets or sets the vat_percent.
        /// </summary>
        public DbSet<vat_percent> vat_percent { get; set; }

        /// <summary>
        /// Gets or sets the verts.
        /// </summary>
        public DbSet<vert> verts { get; set; }

        /// <summary>
        /// Gets or sets the vertstds.
        /// </summary>
        public DbSet<vertstd> vertstds { get; set; }

        /// <summary>
        /// Gets or sets the vertsums.
        /// </summary>
        public DbSet<vertsum> vertsums { get; set; }

        /// <summary>
        /// Gets or sets the visitors.
        /// </summary>
        public DbSet<visitor> visitors { get; set; }

        /// <summary>
        /// Gets or sets the vns.
        /// </summary>
        public DbSet<vn> vns { get; set; }

        /// <summary>
        /// Gets or sets the vn_ac.
        /// </summary>
        public DbSet<vn_ac> vn_ac { get; set; }

        /// <summary>
        /// Gets or sets the warranties.
        /// </summary>
        public DbSet<warranty> warranties { get; set; }

        /// <summary>
        /// Gets or sets the waste_areas.
        /// </summary>
        public DbSet<waste_areas> waste_areas { get; set; }

        /// <summary>
        /// Gets or sets the waste_categories.
        /// </summary>
        public DbSet<waste_categories> waste_categories { get; set; }

        /// <summary>
        /// Gets or sets the waste_dispositions.
        /// </summary>
        public DbSet<waste_dispositions> waste_dispositions { get; set; }

        /// <summary>
        /// Gets or sets the waste_facilities.
        /// </summary>
        public DbSet<waste_facilities> waste_facilities { get; set; }

        /// <summary>
        /// Gets or sets the waste_generators.
        /// </summary>
        public DbSet<waste_generators> waste_generators { get; set; }

        /// <summary>
        /// Gets or sets the waste_manifests.
        /// </summary>
        public DbSet<waste_manifests> waste_manifests { get; set; }

        /// <summary>
        /// Gets or sets the waste_mgmt_methods.
        /// </summary>
        public DbSet<waste_mgmt_methods> waste_mgmt_methods { get; set; }

        /// <summary>
        /// Gets or sets the waste_mgmt_methods_groups.
        /// </summary>
        public DbSet<waste_mgmt_methods_groups> waste_mgmt_methods_groups { get; set; }

        /// <summary>
        /// Gets or sets the waste_out.
        /// </summary>
        public DbSet<waste_out> waste_out { get; set; }

        /// <summary>
        /// Gets or sets the waste_profiles.
        /// </summary>
        public DbSet<waste_profiles> waste_profiles { get; set; }

        /// <summary>
        /// Gets or sets the waste_regulated_codes.
        /// </summary>
        public DbSet<waste_regulated_codes> waste_regulated_codes { get; set; }

        /// <summary>
        /// Gets or sets the weather_model.
        /// </summary>
        public DbSet<weather_model> weather_model { get; set; }

        /// <summary>
        /// Gets or sets the weather_station.
        /// </summary>
        public DbSet<weather_station> weather_station { get; set; }

        /// <summary>
        /// Gets or sets the weather_station_data.
        /// </summary>
        public DbSet<weather_station_data> weather_station_data { get; set; }

        /// <summary>
        /// Gets or sets the weather_station_data_sum.
        /// </summary>
        public DbSet<weather_station_data_sum> weather_station_data_sum { get; set; }

        /// <summary>
        /// Gets or sets the weather_station_source.
        /// </summary>
        public DbSet<weather_station_source> weather_station_source { get; set; }

        /// <summary>
        /// Gets or sets the wns.
        /// </summary>
        public DbSet<wn> wns { get; set; }

        /// <summary>
        /// Gets or sets the wnfrmatls.
        /// </summary>
        public DbSet<wnfrmatl> wnfrmatls { get; set; }

        /// <summary>
        /// Gets or sets the wngltypes.
        /// </summary>
        public DbSet<wngltype> wngltypes { get; set; }

        /// <summary>
        /// Gets or sets the wnstds.
        /// </summary>
        public DbSet<wnstd> wnstds { get; set; }

        /// <summary>
        /// Gets or sets the wntypes.
        /// </summary>
        public DbSet<wntype> wntypes { get; set; }

        /// <summary>
        /// Gets or sets the woes.
        /// </summary>
        public DbSet<wo> woes { get; set; }

        /// <summary>
        /// Gets or sets the work_categories.
        /// </summary>
        public DbSet<work_categories> work_categories { get; set; }

        /// <summary>
        /// Gets or sets the work_categories_em.
        /// </summary>
        public DbSet<work_categories_em> work_categories_em { get; set; }

        /// <summary>
        /// Gets or sets the work_pkg_bids.
        /// </summary>
        public DbSet<work_pkg_bids> work_pkg_bids { get; set; }

        /// <summary>
        /// Gets or sets the work_pkgs.
        /// </summary>
        public DbSet<work_pkgs> work_pkgs { get; set; }

        /// <summary>
        /// Gets or sets the work_roles.
        /// </summary>
        public DbSet<work_roles> work_roles { get; set; }

        /// <summary>
        /// Gets or sets the work_roles_location.
        /// </summary>
        public DbSet<work_roles_location> work_roles_location { get; set; }

        /// <summary>
        /// Gets or sets the work_team.
        /// </summary>
        public DbSet<work_team> work_team { get; set; }

        /// <summary>
        /// Gets or sets the workflow_substitutes.
        /// </summary>
        public DbSet<workflow_substitutes> workflow_substitutes { get; set; }

        /// <summary>
        /// Gets or sets the wrs.
        /// </summary>
        public DbSet<wr> wrs { get; set; }

        /// <summary>
        /// Gets or sets the wr_other.
        /// </summary>
        public DbSet<wr_other> wr_other { get; set; }

        /// <summary>
        /// Gets or sets the wr_other_sync.
        /// </summary>
        public DbSet<wr_other_sync> wr_other_sync { get; set; }

        /// <summary>
        /// Gets or sets the wr_sync.
        /// </summary>
        public DbSet<wr_sync> wr_sync { get; set; }

        /// <summary>
        /// Gets or sets the wrcfs.
        /// </summary>
        public DbSet<wrcf> wrcfs { get; set; }

        /// <summary>
        /// Gets or sets the wrcf_sync.
        /// </summary>
        public DbSet<wrcf_sync> wrcf_sync { get; set; }

        /// <summary>
        /// Gets or sets the wrpts.
        /// </summary>
        public DbSet<wrpt> wrpts { get; set; }

        /// <summary>
        /// Gets or sets the wrpt_sync.
        /// </summary>
        public DbSet<wrpt_sync> wrpt_sync { get; set; }

        /// <summary>
        /// Gets or sets the wrtls.
        /// </summary>
        public DbSet<wrtl> wrtls { get; set; }

        /// <summary>
        /// Gets or sets the wrtl_sync.
        /// </summary>
        public DbSet<wrtl_sync> wrtl_sync { get; set; }

        /// <summary>
        /// Gets or sets the wrtrs.
        /// </summary>
        public DbSet<wrtr> wrtrs { get; set; }

        /// <summary>
        /// Gets or sets the wrtr_sync.
        /// </summary>
        public DbSet<wrtr_sync> wrtr_sync { get; set; }

        /// <summary>
        /// Gets or sets the wrtts.
        /// </summary>
        public DbSet<wrtt> wrtts { get; set; }

        /// <summary>
        /// Gets or sets the wies.
        /// </summary>
        public DbSet<wy> wies { get; set; }

        /// <summary>
        /// Gets or sets the wytypes.
        /// </summary>
        public DbSet<wytype> wytypes { get; set; }

        /// <summary>
        /// Gets or sets the zones.
        /// </summary>
        public DbSet<zone> zones { get; set; }

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the address lookups.
        /// </summary>
        public DbSet<AddressLookup> AddressLookups { get; set; }

        /// <summary>
        /// Gets or sets the articles.
        /// </summary>
        public DbSet<Article> Articles { get; set; }

        /// <summary>
        /// Gets or sets the asp net roles.
        /// </summary>
        public DbSet<AspNetRole> AspNetRoles { get; set; }

        /// <summary>
        /// Gets or sets the asp net user claims.
        /// </summary>
        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

        /// <summary>
        /// Gets or sets the asp net user logins.
        /// </summary>
        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

        /// <summary>
        /// Gets or sets the asp net users.
        /// </summary>
        public DbSet<AspNetUser> AspNetUsers { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets the companies 1.
        /// </summary>
        public DbSet<Company1> Companies1 { get; set; }

        /// <summary>
        /// Gets or sets the contacts 1.
        /// </summary>
        public DbSet<Contact1> Contacts1 { get; set; }

        /// <summary>
        /// Gets or sets the entity type lookups.
        /// </summary>
        public DbSet<EntityTypeLookup> EntityTypeLookups { get; set; }

        /// <summary>
        /// Gets or sets the ethnicity lookups.
        /// </summary>
        public DbSet<EthnicityLookup> EthnicityLookups { get; set; }

        /// <summary>
        /// Gets or sets the gender lookups.
        /// </summary>
        public DbSet<GenderLookup> GenderLookups { get; set; }

        /// <summary>
        /// Gets or sets the individuals.
        /// </summary>
        public DbSet<Individual> Individuals { get; set; }

        /// <summary>
        /// Gets or sets the language lookups.
        /// </summary>
        public DbSet<LanguageLookup> LanguageLookups { get; set; }

        /// <summary>
        /// Gets or sets the profiles.
        /// </summary>
        public DbSet<Profile> Profiles { get; set; }

        /// <summary>
        /// Gets or sets the province lookups.
        /// </summary>
        public DbSet<ProvinceLookup> ProvinceLookups { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        public DbSet<Tag> Tags { get; set; }

        /// <summary>
        /// Gets or sets the title lookups.
        /// </summary>
        public DbSet<TitleLookup> TitleLookups { get; set; }

        /// <summary>
        /// Gets or sets the yes no lookups.
        /// </summary>
        public DbSet<YesNoLookup> YesNoLookups { get; set; }

        /// <summary>
        /// Gets or sets the activity_log_hactivity_log.
        /// </summary>
        public DbSet<activity_log_hactivity_log> activity_log_hactivity_log { get; set; }

        /// <summary>
        /// Gets or sets the activity_log_step_waiting.
        /// </summary>
        public DbSet<activity_log_step_waiting> activity_log_step_waiting { get; set; }

        /// <summary>
        /// Gets or sets the activity_logview.
        /// </summary>
        public DbSet<activity_logview> activity_logview { get; set; }

        /// <summary>
        /// Gets or sets the alrmcs.
        /// </summary>
        public DbSet<alrmc> alrmcs { get; set; }

        /// <summary>
        /// Gets or sets the alrmpctcs.
        /// </summary>
        public DbSet<alrmpctc> alrmpctcs { get; set; }

        /// <summary>
        /// Gets or sets the emarcs.
        /// </summary>
        public DbSet<emarc> emarcs { get; set; }

        /// <summary>
        /// Gets or sets the emcics.
        /// </summary>
        public DbSet<emcic> emcics { get; set; }

        /// <summary>
        /// Gets or sets the gpcs.
        /// </summary>
        public DbSet<gpc> gpcs { get; set; }

        /// <summary>
        /// Gets or sets the hactivity_logmonth.
        /// </summary>
        public DbSet<hactivity_logmonth> hactivity_logmonth { get; set; }

        /// <summary>
        /// Gets or sets the hwr_month.
        /// </summary>
        public DbSet<hwr_month> hwr_month { get; set; }

        /// <summary>
        /// Gets or sets the resrmviews.
        /// </summary>
        public DbSet<resrmview> resrmviews { get; set; }

        /// <summary>
        /// Gets or sets the resrsviews.
        /// </summary>
        public DbSet<resrsview> resrsviews { get; set; }

        /// <summary>
        /// Gets or sets the resviews.
        /// </summary>
        public DbSet<resview> resviews { get; set; }

        /// <summary>
        /// Gets or sets the rmcs.
        /// </summary>
        public DbSet<rmc> rmcs { get; set; }

        /// <summary>
        /// Gets or sets the rmpctcs.
        /// </summary>
        public DbSet<rmpctc> rmpctcs { get; set; }

        /// <summary>
        /// Gets or sets the rrappdets.
        /// </summary>
        public DbSet<rrappdet> rrappdets { get; set; }

        /// <summary>
        /// Gets or sets the rrcostdets.
        /// </summary>
        public DbSet<rrcostdet> rrcostdets { get; set; }

        /// <summary>
        /// Gets or sets the rrdayresoccs.
        /// </summary>
        public DbSet<rrdayresocc> rrdayresoccs { get; set; }

        /// <summary>
        /// Gets or sets the rrdayrmoccs.
        /// </summary>
        public DbSet<rrdayrmocc> rrdayrmoccs { get; set; }

        /// <summary>
        /// Gets or sets the rrdayrmres.
        /// </summary>
        public DbSet<rrdayrmre> rrdayrmres { get; set; }

        /// <summary>
        /// Gets or sets the rrdayrmresplus.
        /// </summary>
        public DbSet<rrdayrmresplu> rrdayrmresplus { get; set; }

        /// <summary>
        /// Gets or sets the rrdayrresplus.
        /// </summary>
        public DbSet<rrdayrresplu> rrdayrresplus { get; set; }

        /// <summary>
        /// Gets or sets the rrmoncostdps.
        /// </summary>
        public DbSet<rrmoncostdp> rrmoncostdps { get; set; }

        /// <summary>
        /// Gets or sets the rrmonnumrres.
        /// </summary>
        public DbSet<rrmonnumrre> rrmonnumrres { get; set; }

        /// <summary>
        /// Gets or sets the rrmonreqs.
        /// </summary>
        public DbSet<rrmonreq> rrmonreqs { get; set; }

        /// <summary>
        /// Gets or sets the rrmonresrejs.
        /// </summary>
        public DbSet<rrmonresrej> rrmonresrejs { get; set; }

        /// <summary>
        /// Gets or sets the rrmonrmcaps.
        /// </summary>
        public DbSet<rrmonrmcap> rrmonrmcaps { get; set; }

        /// <summary>
        /// Gets or sets the rrmonthresquants.
        /// </summary>
        public DbSet<rrmonthresquant> rrmonthresquants { get; set; }

        /// <summary>
        /// Gets or sets the rrmonusearrs.
        /// </summary>
        public DbSet<rrmonusearr> rrmonusearrs { get; set; }

        /// <summary>
        /// Gets or sets the rrressheets.
        /// </summary>
        public DbSet<rrressheet> rrressheets { get; set; }

        /// <summary>
        /// Gets or sets the rrressheetplus.
        /// </summary>
        public DbSet<rrressheetplu> rrressheetplus { get; set; }

        /// <summary>
        /// Gets or sets the rrwrrestrs.
        /// </summary>
        public DbSet<rrwrrestr> rrwrrestrs { get; set; }

        /// <summary>
        /// Gets or sets the wohwoes.
        /// </summary>
        public DbSet<wohwo> wohwoes { get; set; }

        /// <summary>
        /// Gets or sets the wohwostats.
        /// </summary>
        public DbSet<wohwostat> wohwostats { get; set; }

        /// <summary>
        /// Gets or sets the wostats.
        /// </summary>
        public DbSet<wostat> wostats { get; set; }

        /// <summary>
        /// Gets or sets the wr_step_waiting.
        /// </summary>
        public DbSet<wr_step_waiting> wr_step_waiting { get; set; }

        /// <summary>
        /// Gets or sets the wrcfhwrcfs.
        /// </summary>
        public DbSet<wrcfhwrcf> wrcfhwrcfs { get; set; }

        /// <summary>
        /// Gets or sets the wrhwrs.
        /// </summary>
        public DbSet<wrhwr> wrhwrs { get; set; }

        /// <summary>
        /// Gets or sets the wrhwrstats.
        /// </summary>
        public DbSet<wrhwrstat> wrhwrstats { get; set; }

        /// <summary>
        /// Gets or sets the wrpthwrpts.
        /// </summary>
        public DbSet<wrpthwrpt> wrpthwrpts { get; set; }

        /// <summary>
        /// Gets or sets the wrstats.
        /// </summary>
        public DbSet<wrstat> wrstats { get; set; }

        /// <summary>
        /// Gets or sets the wrviews.
        /// </summary>
        public DbSet<wrview> wrviews { get; set; }

        /// <summary>
        /// The on model creating.
        /// </summary>
        /// <param name="modelBuilder">
        /// The model builder.
        /// </param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin>().HasKey(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
            modelBuilder.Configurations.Add(new acMap());
            modelBuilder.Configurations.Add(new acbuMap());
            modelBuilder.Configurations.Add(new active_plantypesMap());
            modelBuilder.Configurations.Add(new activity_logMap());
            modelBuilder.Configurations.Add(new activity_log_syncMap());
            modelBuilder.Configurations.Add(new activity_log_transMap());
            modelBuilder.Configurations.Add(new activitytypeMap());
            modelBuilder.Configurations.Add(new actscnMap());
            modelBuilder.Configurations.Add(new advisoryMap());
            modelBuilder.Configurations.Add(new afm_act_tblsMap());
            modelBuilder.Configurations.Add(new afm_activitiesMap());
            modelBuilder.Configurations.Add(new afm_activity_catsMap());
            modelBuilder.Configurations.Add(new afm_activity_paramsMap());
            modelBuilder.Configurations.Add(new afm_actprodsMap());
            modelBuilder.Configurations.Add(new afm_actsMap());
            modelBuilder.Configurations.Add(new afm_atypMap());
            modelBuilder.Configurations.Add(new afm_bim_categoriesMap());
            modelBuilder.Configurations.Add(new afm_bim_familiesMap());
            modelBuilder.Configurations.Add(new afm_bim_paramsMap());
            modelBuilder.Configurations.Add(new afm_cal_datesMap());
            modelBuilder.Configurations.Add(new afm_catsMap());
            modelBuilder.Configurations.Add(new afm_classMap());
            modelBuilder.Configurations.Add(new afm_conn_fldsMap());
            modelBuilder.Configurations.Add(new afm_conn_logMap());
            modelBuilder.Configurations.Add(new afm_conn_rule_catMap());
            modelBuilder.Configurations.Add(new afm_connectorMap());
            modelBuilder.Configurations.Add(new afm_conversionsMap());
            modelBuilder.Configurations.Add(new afm_currenciesMap());
            modelBuilder.Configurations.Add(new afm_data_event_logMap());
            modelBuilder.Configurations.Add(new afm_docsMap());
            modelBuilder.Configurations.Add(new afm_docversMap());
            modelBuilder.Configurations.Add(new afm_docversarchMap());
            modelBuilder.Configurations.Add(new afm_dwgpubMap());
            modelBuilder.Configurations.Add(new afm_dwgsMap());
            modelBuilder.Configurations.Add(new afm_dwgversMap());
            modelBuilder.Configurations.Add(new afm_fldsMap());
            modelBuilder.Configurations.Add(new afm_flds_langMap());
            modelBuilder.Configurations.Add(new afm_flds_transMap());
            modelBuilder.Configurations.Add(new afm_groupsMap());
            modelBuilder.Configurations.Add(new afm_groupsforrolesMap());
            modelBuilder.Configurations.Add(new afm_hmetric_trend_valuesMap());
            modelBuilder.Configurations.Add(new afm_holiday_datesMap());
            modelBuilder.Configurations.Add(new afm_hotlistMap());
            modelBuilder.Configurations.Add(new afm_layrMap());
            modelBuilder.Configurations.Add(new afm_metric_definitionsMap());
            modelBuilder.Configurations.Add(new afm_metric_gran_defsMap());
            modelBuilder.Configurations.Add(new afm_metric_gransMap());
            modelBuilder.Configurations.Add(new afm_metric_scard_defsMap());
            modelBuilder.Configurations.Add(new afm_metric_scardsMap());
            modelBuilder.Configurations.Add(new afm_metric_trend_valuesMap());
            modelBuilder.Configurations.Add(new afm_mobile_appsMap());
            modelBuilder.Configurations.Add(new afm_mobile_menuMap());
            modelBuilder.Configurations.Add(new afm_modsMap());
            modelBuilder.Configurations.Add(new afm_notifications_logMap());
            modelBuilder.Configurations.Add(new afm_processesMap());
            modelBuilder.Configurations.Add(new afm_productsMap());
            modelBuilder.Configurations.Add(new afm_psubtasksMap());
            modelBuilder.Configurations.Add(new afm_ptasksMap());
            modelBuilder.Configurations.Add(new afm_redlinesMap());
            modelBuilder.Configurations.Add(new afm_roleprocsMap());
            modelBuilder.Configurations.Add(new afm_rolesMap());
            modelBuilder.Configurations.Add(new afm_scmprefMap());
            modelBuilder.Configurations.Add(new afm_subtasksMap());
            modelBuilder.Configurations.Add(new afm_tasksMap());
            modelBuilder.Configurations.Add(new afm_tbl_mapMap());
            modelBuilder.Configurations.Add(new afm_tblsMap());
            modelBuilder.Configurations.Add(new afm_tccnMap());
            modelBuilder.Configurations.Add(new afm_tclevelMap());
            modelBuilder.Configurations.Add(new afm_tctraceMap());
            modelBuilder.Configurations.Add(new afm_timezonesMap());
            modelBuilder.Configurations.Add(new afm_titlesheetMap());
            modelBuilder.Configurations.Add(new afm_transfer_setMap());
            modelBuilder.Configurations.Add(new afm_userprocsMap());
            modelBuilder.Configurations.Add(new afm_usersMap());
            modelBuilder.Configurations.Add(new afm_wf_logMap());
            modelBuilder.Configurations.Add(new afm_wf_rulesMap());
            modelBuilder.Configurations.Add(new afm_wf_stepsMap());
            modelBuilder.Configurations.Add(new bar_code_listMap());
            modelBuilder.Configurations.Add(new bas_data_clean_numMap());
            modelBuilder.Configurations.Add(new bas_data_pointMap());
            modelBuilder.Configurations.Add(new bas_data_time_norm_numMap());
            modelBuilder.Configurations.Add(new bas_measurement_scopeMap());
            modelBuilder.Configurations.Add(new billMap());
            modelBuilder.Configurations.Add(new bill_archiveMap());
            modelBuilder.Configurations.Add(new bill_connectorMap());
            modelBuilder.Configurations.Add(new bill_lineMap());
            modelBuilder.Configurations.Add(new bill_line_archiveMap());
            modelBuilder.Configurations.Add(new bill_typeMap());
            modelBuilder.Configurations.Add(new bill_unitMap());
            modelBuilder.Configurations.Add(new blMap());
            modelBuilder.Configurations.Add(new bl_amenityMap());
            modelBuilder.Configurations.Add(new blbuMap());
            modelBuilder.Configurations.Add(new buMap());
            modelBuilder.Configurations.Add(new budgetMap());
            modelBuilder.Configurations.Add(new budget_itemMap());
            modelBuilder.Configurations.Add(new caMap());
            modelBuilder.Configurations.Add(new cardMap());
            modelBuilder.Configurations.Add(new cardstdMap());
            modelBuilder.Configurations.Add(new castdMap());
            modelBuilder.Configurations.Add(new catypeMap());
            modelBuilder.Configurations.Add(new causetypMap());
            modelBuilder.Configurations.Add(new cb_accredit_personMap());
            modelBuilder.Configurations.Add(new cb_accredit_sourceMap());
            modelBuilder.Configurations.Add(new cb_accredit_typeMap());
            modelBuilder.Configurations.Add(new cb_hazard_rankMap());
            modelBuilder.Configurations.Add(new cb_hazard_ratingMap());
            modelBuilder.Configurations.Add(new cb_hazard_statusMap());
            modelBuilder.Configurations.Add(new cb_hcmMap());
            modelBuilder.Configurations.Add(new cb_hcm_classMap());
            modelBuilder.Configurations.Add(new cb_hcm_condMap());
            modelBuilder.Configurations.Add(new cb_hcm_loc_typMap());
            modelBuilder.Configurations.Add(new cb_hcm_placesMap());
            modelBuilder.Configurations.Add(new cb_sample_compMap());
            modelBuilder.Configurations.Add(new cb_sample_resultMap());
            modelBuilder.Configurations.Add(new cb_samplesMap());
            modelBuilder.Configurations.Add(new cb_unitsMap());
            modelBuilder.Configurations.Add(new cbudcmprMap());
            modelBuilder.Configurations.Add(new ccost_sumMap());
            modelBuilder.Configurations.Add(new ccostprjnMap());
            modelBuilder.Configurations.Add(new ccshflwMap());
            modelBuilder.Configurations.Add(new cdportMap());
            modelBuilder.Configurations.Add(new cfMap());
            modelBuilder.Configurations.Add(new checkinMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new combextMap());
            modelBuilder.Configurations.Add(new commsubMap());
            modelBuilder.Configurations.Add(new commtypeMap());
            modelBuilder.Configurations.Add(new companyMap());
            modelBuilder.Configurations.Add(new compliance_locationsMap());
            modelBuilder.Configurations.Add(new contactMap());
            modelBuilder.Configurations.Add(new cost_catMap());
            modelBuilder.Configurations.Add(new cost_classMap());
            modelBuilder.Configurations.Add(new cost_indexMap());
            modelBuilder.Configurations.Add(new cost_index_transMap());
            modelBuilder.Configurations.Add(new cost_index_valuesMap());
            modelBuilder.Configurations.Add(new cost_tranMap());
            modelBuilder.Configurations.Add(new cost_tran_recurMap());
            modelBuilder.Configurations.Add(new cost_tran_schedMap());
            modelBuilder.Configurations.Add(new countyMap());
            modelBuilder.Configurations.Add(new cpMap());
            modelBuilder.Configurations.Add(new csiMap());
            modelBuilder.Configurations.Add(new ctryMap());
            modelBuilder.Configurations.Add(new dep_reportsMap());
            modelBuilder.Configurations.Add(new doc_templatesMap());
            modelBuilder.Configurations.Add(new doccatMap());
            modelBuilder.Configurations.Add(new docfolderMap());
            modelBuilder.Configurations.Add(new docs_assignedMap());
            modelBuilder.Configurations.Add(new docs_assigned_syncMap());
            modelBuilder.Configurations.Add(new doctypeMap());
            modelBuilder.Configurations.Add(new dpMap());
            modelBuilder.Configurations.Add(new dpbuMap());
            modelBuilder.Configurations.Add(new drMap());
            modelBuilder.Configurations.Add(new drfnshMap());
            modelBuilder.Configurations.Add(new drfrmatlMap());
            modelBuilder.Configurations.Add(new drmatlMap());
            modelBuilder.Configurations.Add(new drstdMap());
            modelBuilder.Configurations.Add(new drtypeMap());
            modelBuilder.Configurations.Add(new dvMap());
            modelBuilder.Configurations.Add(new ehs_chemicalsMap());
            modelBuilder.Configurations.Add(new ehs_em_ppe_typesMap());
            modelBuilder.Configurations.Add(new ehs_incident_cause_catMap());
            modelBuilder.Configurations.Add(new ehs_incident_injury_areasMap());
            modelBuilder.Configurations.Add(new ehs_incident_injury_catMap());
            modelBuilder.Configurations.Add(new ehs_incident_long_tm_caMap());
            modelBuilder.Configurations.Add(new ehs_incident_short_tm_caMap());
            modelBuilder.Configurations.Add(new ehs_incident_typesMap());
            modelBuilder.Configurations.Add(new ehs_incident_witnessMap());
            modelBuilder.Configurations.Add(new ehs_incident_witness_syncMap());
            modelBuilder.Configurations.Add(new ehs_incidentsMap());
            modelBuilder.Configurations.Add(new ehs_incidents_syncMap());
            modelBuilder.Configurations.Add(new ehs_medical_mon_resultsMap());
            modelBuilder.Configurations.Add(new ehs_medical_monitoringMap());
            modelBuilder.Configurations.Add(new ehs_ppe_typesMap());
            modelBuilder.Configurations.Add(new ehs_restriction_catMap());
            modelBuilder.Configurations.Add(new ehs_restrictionsMap());
            modelBuilder.Configurations.Add(new ehs_trainingMap());
            modelBuilder.Configurations.Add(new ehs_training_catMap());
            modelBuilder.Configurations.Add(new ehs_training_resultsMap());
            modelBuilder.Configurations.Add(new ehs_training_typesMap());
            modelBuilder.Configurations.Add(new emMap());
            modelBuilder.Configurations.Add(new em_compinvtrialMap());
            modelBuilder.Configurations.Add(new em_syncMap());
            modelBuilder.Configurations.Add(new em_trialMap());
            modelBuilder.Configurations.Add(new emstdMap());
            modelBuilder.Configurations.Add(new emsumMap());
            modelBuilder.Configurations.Add(new energy_bl_svc_periodMap());
            modelBuilder.Configurations.Add(new energy_chart_pointMap());
            modelBuilder.Configurations.Add(new energy_time_periodMap());
            modelBuilder.Configurations.Add(new epMap());
            modelBuilder.Configurations.Add(new eqMap());
            modelBuilder.Configurations.Add(new eq_auditMap());
            modelBuilder.Configurations.Add(new eq_bar_code_listMap());
            modelBuilder.Configurations.Add(new eq_compinvsurMap());
            modelBuilder.Configurations.Add(new eq_compinvtrialMap());
            modelBuilder.Configurations.Add(new eq_depMap());
            modelBuilder.Configurations.Add(new eq_eqstdcntsMap());
            modelBuilder.Configurations.Add(new eq_reserveMap());
            modelBuilder.Configurations.Add(new eq_schedMap());
            modelBuilder.Configurations.Add(new eq_trialMap());
            modelBuilder.Configurations.Add(new eqportMap());
            modelBuilder.Configurations.Add(new eqprphMap());
            modelBuilder.Configurations.Add(new eqstdMap());
            modelBuilder.Configurations.Add(new facility_typeMap());
            modelBuilder.Configurations.Add(new flMap());
            modelBuilder.Configurations.Add(new fnMap());
            modelBuilder.Configurations.Add(new fn_compinvsurMap());
            modelBuilder.Configurations.Add(new fn_compinvtrialMap());
            modelBuilder.Configurations.Add(new fn_comptrialtrialMap());
            modelBuilder.Configurations.Add(new fn_fnstdcntsMap());
            modelBuilder.Configurations.Add(new fn_trialMap());
            modelBuilder.Configurations.Add(new fnstdMap());
            modelBuilder.Configurations.Add(new fpMap());
            modelBuilder.Configurations.Add(new fpstdMap());
            modelBuilder.Configurations.Add(new fMap());
            modelBuilder.Configurations.Add(new fundingMap());
            modelBuilder.Configurations.Add(new gb_cert_catMap());
            modelBuilder.Configurations.Add(new gb_cert_creditsMap());
            modelBuilder.Configurations.Add(new gb_cert_docsMap());
            modelBuilder.Configurations.Add(new gb_cert_levelsMap());
            modelBuilder.Configurations.Add(new gb_cert_logMap());
            modelBuilder.Configurations.Add(new gb_cert_projMap());
            modelBuilder.Configurations.Add(new gb_cert_scoresMap());
            modelBuilder.Configurations.Add(new gb_cert_stdMap());
            modelBuilder.Configurations.Add(new gb_fp_airc_dataMap());
            modelBuilder.Configurations.Add(new gb_fp_carbon_dataMap());
            modelBuilder.Configurations.Add(new gb_fp_comm_airc_dataMap());
            modelBuilder.Configurations.Add(new gb_fp_egrid_subregionsMap());
            modelBuilder.Configurations.Add(new gb_fp_egrid_zipMap());
            modelBuilder.Configurations.Add(new gb_fp_emiss_dataMap());
            modelBuilder.Configurations.Add(new gb_fp_energystar_fuelsMap());
            modelBuilder.Configurations.Add(new gb_fp_fuel_dens_dataMap());
            modelBuilder.Configurations.Add(new gb_fp_fuel_typesMap());
            modelBuilder.Configurations.Add(new gb_fp_fuelsMap());
            modelBuilder.Configurations.Add(new gb_fp_gwp_dataMap());
            modelBuilder.Configurations.Add(new gb_fp_heat_dataMap());
            modelBuilder.Configurations.Add(new gb_fp_mobile_dataMap());
            modelBuilder.Configurations.Add(new gb_fp_oxid_dataMap());
            modelBuilder.Configurations.Add(new gb_fp_refrig_dataMap());
            modelBuilder.Configurations.Add(new gb_fp_s_otherMap());
            modelBuilder.Configurations.Add(new gb_fp_s1_co_aircMap());
            modelBuilder.Configurations.Add(new gb_fp_s1_fuel_combMap());
            modelBuilder.Configurations.Add(new gb_fp_s1_refrig_acMap());
            modelBuilder.Configurations.Add(new gb_fp_s1_s3_mobileMap());
            modelBuilder.Configurations.Add(new gb_fp_s2_purch_eMap());
            modelBuilder.Configurations.Add(new gb_fp_s3_em_airMap());
            modelBuilder.Configurations.Add(new gb_fp_s3_matMap());
            modelBuilder.Configurations.Add(new gb_fp_s3_outsMap());
            modelBuilder.Configurations.Add(new gb_fp_s3_servMap());
            modelBuilder.Configurations.Add(new gb_fp_s3_waste_liqMap());
            modelBuilder.Configurations.Add(new gb_fp_s3_waste_solMap());
            modelBuilder.Configurations.Add(new gb_fp_sectorsMap());
            modelBuilder.Configurations.Add(new gb_fp_setupMap());
            modelBuilder.Configurations.Add(new gb_fp_totalsMap());
            modelBuilder.Configurations.Add(new gb_fp_versionsMap());
            modelBuilder.Configurations.Add(new gb_fp_waste_liq_dataMap());
            modelBuilder.Configurations.Add(new gb_fp_waste_sol_dataMap());
            modelBuilder.Configurations.Add(new geo_regionMap());
            modelBuilder.Configurations.Add(new gpMap());
            modelBuilder.Configurations.Add(new gpstdMap());
            modelBuilder.Configurations.Add(new gpsumMap());
            modelBuilder.Configurations.Add(new gridMap());
            modelBuilder.Configurations.Add(new groMap());
            modelBuilder.Configurations.Add(new grpMap());
            modelBuilder.Configurations.Add(new grp_agencyMap());
            modelBuilder.Configurations.Add(new grp_transMap());
            modelBuilder.Configurations.Add(new grp_typeMap());
            modelBuilder.Configurations.Add(new grp_useMap());
            modelBuilder.Configurations.Add(new hactivity_logMap());
            modelBuilder.Configurations.Add(new hazard_container_catMap());
            modelBuilder.Configurations.Add(new hazard_container_typeMap());
            modelBuilder.Configurations.Add(new helpdesk_rolesMap());
            modelBuilder.Configurations.Add(new helpdesk_sla_requestMap());
            modelBuilder.Configurations.Add(new helpdesk_sla_responseMap());
            modelBuilder.Configurations.Add(new helpdesk_sla_stepsMap());
            modelBuilder.Configurations.Add(new helpdesk_step_logMap());
            modelBuilder.Configurations.Add(new hhelpdesk_step_logMap());
            modelBuilder.Configurations.Add(new hist_em_countMap());
            modelBuilder.Configurations.Add(new hprorateMap());
            modelBuilder.Configurations.Add(new hreserveMap());
            modelBuilder.Configurations.Add(new hreserve_rmMap());
            modelBuilder.Configurations.Add(new hreserve_rsMap());
            modelBuilder.Configurations.Add(new hrmpctMap());
            modelBuilder.Configurations.Add(new hwoMap());
            modelBuilder.Configurations.Add(new hwrMap());
            modelBuilder.Configurations.Add(new hwr_otherMap());
            modelBuilder.Configurations.Add(new hwrcfMap());
            modelBuilder.Configurations.Add(new hwrcfanaMap());
            modelBuilder.Configurations.Add(new hwrptMap());
            modelBuilder.Configurations.Add(new hwrsumMap());
            modelBuilder.Configurations.Add(new hwrtlMap());
            modelBuilder.Configurations.Add(new hwrtrMap());
            modelBuilder.Configurations.Add(new hwrttMap());
            modelBuilder.Configurations.Add(new insurerMap());
            modelBuilder.Configurations.Add(new invoiceMap());
            modelBuilder.Configurations.Add(new invoice_paymentMap());
            modelBuilder.Configurations.Add(new itMap());
            modelBuilder.Configurations.Add(new jkMap());
            modelBuilder.Configurations.Add(new jkcfgMap());
            modelBuilder.Configurations.Add(new jkextMap());
            modelBuilder.Configurations.Add(new jkstdMap());
            modelBuilder.Configurations.Add(new lang_enumMap());
            modelBuilder.Configurations.Add(new lang_filesMap());
            modelBuilder.Configurations.Add(new lang_glossaryMap());
            modelBuilder.Configurations.Add(new lang_langMap());
            modelBuilder.Configurations.Add(new lang_stringsMap());
            modelBuilder.Configurations.Add(new lessorMap());
            modelBuilder.Configurations.Add(new lMap());
            modelBuilder.Configurations.Add(new ls_alert_definitionMap());
            modelBuilder.Configurations.Add(new ls_amendmentMap());
            modelBuilder.Configurations.Add(new ls_cam_profileMap());
            modelBuilder.Configurations.Add(new ls_cam_rec_reportMap());
            modelBuilder.Configurations.Add(new ls_chrgbck_agreeMap());
            modelBuilder.Configurations.Add(new ls_clause_typeMap());
            modelBuilder.Configurations.Add(new ls_commMap());
            modelBuilder.Configurations.Add(new ls_comm_logMap());
            modelBuilder.Configurations.Add(new ls_index_profileMap());
            modelBuilder.Configurations.Add(new ls_respMap());
            modelBuilder.Configurations.Add(new messageMap());
            modelBuilder.Configurations.Add(new moMap());
            modelBuilder.Configurations.Add(new mo_churnMap());
            modelBuilder.Configurations.Add(new mo_eqMap());
            modelBuilder.Configurations.Add(new mo_fncountMap());
            modelBuilder.Configurations.Add(new mo_scenarioMap());
            modelBuilder.Configurations.Add(new MoScenarioEmMap());
            modelBuilder.Configurations.Add(new mo_taMap());
            modelBuilder.Configurations.Add(new mpMap());
            modelBuilder.Configurations.Add(new msds_chemicalMap());
            modelBuilder.Configurations.Add(new msds_constituentMap());
            modelBuilder.Configurations.Add(new msds_dataMap());
            modelBuilder.Configurations.Add(new msds_h_chemicalMap());
            modelBuilder.Configurations.Add(new msds_h_constituentMap());
            modelBuilder.Configurations.Add(new msds_h_dataMap());
            modelBuilder.Configurations.Add(new msds_h_haz_classificationMap());
            modelBuilder.Configurations.Add(new msds_h_locationMap());
            modelBuilder.Configurations.Add(new msds_haz_classificationMap());
            modelBuilder.Configurations.Add(new msds_hazard_categoryMap());
            modelBuilder.Configurations.Add(new msds_hazard_classMap());
            modelBuilder.Configurations.Add(new msds_hazard_systemMap());
            modelBuilder.Configurations.Add(new msds_locationMap());
            modelBuilder.Configurations.Add(new ndportMap());
            modelBuilder.Configurations.Add(new netMap());
            modelBuilder.Configurations.Add(new netdevMap());
            modelBuilder.Configurations.Add(new netdevstdMap());
            modelBuilder.Configurations.Add(new notificationMap());
            modelBuilder.Configurations.Add(new notify_templatesMap());
            modelBuilder.Configurations.Add(new notifycatMap());
            modelBuilder.Configurations.Add(new opMap());
            modelBuilder.Configurations.Add(new orgMap());
            modelBuilder.Configurations.Add(new otMap());
            modelBuilder.Configurations.Add(new other_rsMap());
            modelBuilder.Configurations.Add(new paMap());
            modelBuilder.Configurations.Add(new pa_depMap());
            modelBuilder.Configurations.Add(new parcelMap());
            modelBuilder.Configurations.Add(new parkingMap());
            modelBuilder.Configurations.Add(new parkingstdMap());
            modelBuilder.Configurations.Add(new pbMap());
            modelBuilder.Configurations.Add(new pbstdMap());
            modelBuilder.Configurations.Add(new pdMap());
            modelBuilder.Configurations.Add(new pmforecast_trMap());
            modelBuilder.Configurations.Add(new pmforecast_trmMap());
            modelBuilder.Configurations.Add(new pmgenMap());
            modelBuilder.Configurations.Add(new PmgpMap());
            modelBuilder.Configurations.Add(new pmpMap());
            modelBuilder.Configurations.Add(new pmp1Map());
            modelBuilder.Configurations.Add(new pmpsptMap());
            modelBuilder.Configurations.Add(new pmpstrMap());
            modelBuilder.Configurations.Add(new pmpsttMap());
            modelBuilder.Configurations.Add(new pmpsumMap());
            modelBuilder.Configurations.Add(new pmressumMap());
            modelBuilder.Configurations.Add(new PmMap());
            modelBuilder.Configurations.Add(new pmsdMap());
            modelBuilder.Configurations.Add(new pnMap());
            modelBuilder.Configurations.Add(new pnportMap());
            modelBuilder.Configurations.Add(new pnstdMap());
            modelBuilder.Configurations.Add(new poMap());
            modelBuilder.Configurations.Add(new po_lineMap());
            modelBuilder.Configurations.Add(new policyMap());
            modelBuilder.Configurations.Add(new portMap());
            modelBuilder.Configurations.Add(new portcfgMap());
            modelBuilder.Configurations.Add(new portfolio_scenarioMap());
            modelBuilder.Configurations.Add(new portstdMap());
            modelBuilder.Configurations.Add(new prMap());
            modelBuilder.Configurations.Add(new probtypeMap());
            modelBuilder.Configurations.Add(new prog_budget_itemsMap());
            modelBuilder.Configurations.Add(new programMap());
            modelBuilder.Configurations.Add(new programtypeMap());
            modelBuilder.Configurations.Add(new proj_forecastMap());
            modelBuilder.Configurations.Add(new proj_forecast_itemMap());
            modelBuilder.Configurations.Add(new projectMap());
            modelBuilder.Configurations.Add(new projecttypeMap());
            modelBuilder.Configurations.Add(new projfundMap());
            modelBuilder.Configurations.Add(new projphaseMap());
            modelBuilder.Configurations.Add(new projscnMap());
            modelBuilder.Configurations.Add(new projteamMap());
            modelBuilder.Configurations.Add(new prop_amenityMap());
            modelBuilder.Configurations.Add(new prop_amenity_typeMap());
            modelBuilder.Configurations.Add(new propertyMap());
            modelBuilder.Configurations.Add(new property_typeMap());
            modelBuilder.Configurations.Add(new ptMap());
            modelBuilder.Configurations.Add(new pvMap());
            modelBuilder.Configurations.Add(new questionnaireMap());
            modelBuilder.Configurations.Add(new questionnaire_mapMap());
            modelBuilder.Configurations.Add(new questionMap());
            modelBuilder.Configurations.Add(new rackMap());
            modelBuilder.Configurations.Add(new recovery_teamMap());
            modelBuilder.Configurations.Add(new regcatMap());
            modelBuilder.Configurations.Add(new regcomplevelMap());
            modelBuilder.Configurations.Add(new regcomplianceMap());
            modelBuilder.Configurations.Add(new reglocMap());
            modelBuilder.Configurations.Add(new regnMap());
            modelBuilder.Configurations.Add(new regnotifyMap());
            modelBuilder.Configurations.Add(new regprogcatMap());
            modelBuilder.Configurations.Add(new regprogramMap());
            modelBuilder.Configurations.Add(new regprogtypeMap());
            modelBuilder.Configurations.Add(new regreqcatMap());
            modelBuilder.Configurations.Add(new regrequirementMap());
            modelBuilder.Configurations.Add(new regtypeMap());
            modelBuilder.Configurations.Add(new regulationMap());
            modelBuilder.Configurations.Add(new regviolationMap());
            modelBuilder.Configurations.Add(new regviolationtypMap());
            modelBuilder.Configurations.Add(new repairtyMap());
            modelBuilder.Configurations.Add(new resavailMap());
            modelBuilder.Configurations.Add(new reserveMap());
            modelBuilder.Configurations.Add(new reserve_rmMap());
            modelBuilder.Configurations.Add(new reserve_rsMap());
            modelBuilder.Configurations.Add(new resource_stdMap());
            modelBuilder.Configurations.Add(new resourceMap());
            modelBuilder.Configurations.Add(new rfMap());
            modelBuilder.Configurations.Add(new rf_activityMap());
            modelBuilder.Configurations.Add(new rf_readerMap());
            modelBuilder.Configurations.Add(new rffnshMap());
            modelBuilder.Configurations.Add(new rfmatlMap());
            modelBuilder.Configurations.Add(new rmMap());
            modelBuilder.Configurations.Add(new rm_amenityMap());
            modelBuilder.Configurations.Add(new rm_amenity_typeMap());
            modelBuilder.Configurations.Add(new rm_arrangeMap());
            modelBuilder.Configurations.Add(new rm_arrange_typeMap());
            modelBuilder.Configurations.Add(new rm_configMap());
            modelBuilder.Configurations.Add(new rm_reserveMap());
            modelBuilder.Configurations.Add(new rm_resource_stdMap());
            modelBuilder.Configurations.Add(new rm_trialMap());
            modelBuilder.Configurations.Add(new rmcatMap());
            modelBuilder.Configurations.Add(new rmpctMap());
            modelBuilder.Configurations.Add(new rmpctmob_syncMap());
            modelBuilder.Configurations.Add(new rmstdMap());
            modelBuilder.Configurations.Add(new rmstd_fnMap());
            modelBuilder.Configurations.Add(new rmsumMap());
            modelBuilder.Configurations.Add(new rmtypeMap());
            modelBuilder.Configurations.Add(new rmuseMap());
            modelBuilder.Configurations.Add(new runoffareaMap());
            modelBuilder.Configurations.Add(new runofftypeMap());
            modelBuilder.Configurations.Add(new sbMap());
            modelBuilder.Configurations.Add(new sb_itemsMap());
            modelBuilder.Configurations.Add(new sbaffinMap());
            modelBuilder.Configurations.Add(new sbperiodMap());
            modelBuilder.Configurations.Add(new scenarioMap());
            modelBuilder.Configurations.Add(new servMap());
            modelBuilder.Configurations.Add(new servcontMap());
            modelBuilder.Configurations.Add(new servstdMap());
            modelBuilder.Configurations.Add(new servsumMap());
            modelBuilder.Configurations.Add(new siteMap());
            modelBuilder.Configurations.Add(new softinvMap());
            modelBuilder.Configurations.Add(new softstdMap());
            modelBuilder.Configurations.Add(new stateMap());
            modelBuilder.Configurations.Add(new status_logMap());
            modelBuilder.Configurations.Add(new suMap());
            modelBuilder.Configurations.Add(new surveyMap());
            modelBuilder.Configurations.Add(new surveymob_syncMap());
            modelBuilder.Configurations.Add(new surveyrm_syncMap());
            modelBuilder.Configurations.Add(new system_blMap());
            modelBuilder.Configurations.Add(new system_depMap());
            modelBuilder.Configurations.Add(new system_typeMap());
            modelBuilder.Configurations.Add(new taMap());
            modelBuilder.Configurations.Add(new ta_auditMap());
            modelBuilder.Configurations.Add(new ta_compinvsurMap());
            modelBuilder.Configurations.Add(new ta_compinvtrialMap());
            modelBuilder.Configurations.Add(new ta_depMap());
            modelBuilder.Configurations.Add(new ta_fnstdcntsMap());
            modelBuilder.Configurations.Add(new ta_leaseMap());
            modelBuilder.Configurations.Add(new ta_trialMap());
            modelBuilder.Configurations.Add(new telextMap());
            modelBuilder.Configurations.Add(new tlMap());
            modelBuilder.Configurations.Add(new trMap());
            modelBuilder.Configurations.Add(new trialprojectMap());
            modelBuilder.Configurations.Add(new ttMap());
            modelBuilder.Configurations.Add(new vat_percentMap());
            modelBuilder.Configurations.Add(new vertMap());
            modelBuilder.Configurations.Add(new vertstdMap());
            modelBuilder.Configurations.Add(new vertsumMap());
            modelBuilder.Configurations.Add(new visitorMap());
            modelBuilder.Configurations.Add(new vnMap());
            modelBuilder.Configurations.Add(new vn_acMap());
            modelBuilder.Configurations.Add(new warrantyMap());
            modelBuilder.Configurations.Add(new waste_areasMap());
            modelBuilder.Configurations.Add(new waste_categoriesMap());
            modelBuilder.Configurations.Add(new waste_dispositionsMap());
            modelBuilder.Configurations.Add(new waste_facilitiesMap());
            modelBuilder.Configurations.Add(new waste_generatorsMap());
            modelBuilder.Configurations.Add(new waste_manifestsMap());
            modelBuilder.Configurations.Add(new waste_mgmt_methodsMap());
            modelBuilder.Configurations.Add(new waste_mgmt_methods_groupsMap());
            modelBuilder.Configurations.Add(new waste_outMap());
            modelBuilder.Configurations.Add(new waste_profilesMap());
            modelBuilder.Configurations.Add(new waste_regulated_codesMap());
            modelBuilder.Configurations.Add(new weather_modelMap());
            modelBuilder.Configurations.Add(new weather_stationMap());
            modelBuilder.Configurations.Add(new weather_station_dataMap());
            modelBuilder.Configurations.Add(new weather_station_data_sumMap());
            modelBuilder.Configurations.Add(new weather_station_sourceMap());
            modelBuilder.Configurations.Add(new wnMap());
            modelBuilder.Configurations.Add(new wnfrmatlMap());
            modelBuilder.Configurations.Add(new wngltypeMap());
            modelBuilder.Configurations.Add(new wnstdMap());
            modelBuilder.Configurations.Add(new wntypeMap());
            modelBuilder.Configurations.Add(new woMap());
            modelBuilder.Configurations.Add(new work_categoriesMap());
            modelBuilder.Configurations.Add(new work_categories_emMap());
            modelBuilder.Configurations.Add(new work_pkg_bidsMap());
            modelBuilder.Configurations.Add(new work_pkgsMap());
            modelBuilder.Configurations.Add(new work_rolesMap());
            modelBuilder.Configurations.Add(new work_roles_locationMap());
            modelBuilder.Configurations.Add(new work_teamMap());
            modelBuilder.Configurations.Add(new workflow_substitutesMap());
            modelBuilder.Configurations.Add(new wrMap());
            modelBuilder.Configurations.Add(new wr_otherMap());
            modelBuilder.Configurations.Add(new wr_other_syncMap());
            modelBuilder.Configurations.Add(new wr_syncMap());
            modelBuilder.Configurations.Add(new wrcfMap());
            modelBuilder.Configurations.Add(new wrcf_syncMap());
            modelBuilder.Configurations.Add(new wrptMap());
            modelBuilder.Configurations.Add(new wrpt_syncMap());
            modelBuilder.Configurations.Add(new wrtlMap());
            modelBuilder.Configurations.Add(new wrtl_syncMap());
            modelBuilder.Configurations.Add(new wrtrMap());
            modelBuilder.Configurations.Add(new wrtr_syncMap());
            modelBuilder.Configurations.Add(new wrttMap());
            modelBuilder.Configurations.Add(new wyMap());
            modelBuilder.Configurations.Add(new wytypeMap());
            modelBuilder.Configurations.Add(new zoneMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new AddressLookupMap());
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new AspNetRoleMap());
            modelBuilder.Configurations.Add(new AspNetUserClaimMap());
            modelBuilder.Configurations.Add(new AspNetUserLoginMap());
            modelBuilder.Configurations.Add(new AspNetUserMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new Company1Map());
            modelBuilder.Configurations.Add(new Contact1Map());
            modelBuilder.Configurations.Add(new EntityTypeLookupMap());
            modelBuilder.Configurations.Add(new EthnicityLookupMap());
            modelBuilder.Configurations.Add(new GenderLookupMap());
            modelBuilder.Configurations.Add(new IndividualMap());
            modelBuilder.Configurations.Add(new LanguageLookupMap());
            modelBuilder.Configurations.Add(new ProfileMap());
            modelBuilder.Configurations.Add(new ProvinceLookupMap());
            modelBuilder.Configurations.Add(new TagMap());
            modelBuilder.Configurations.Add(new TitleLookupMap());
            modelBuilder.Configurations.Add(new YesNoLookupMap());
            modelBuilder.Configurations.Add(new activity_log_hactivity_logMap());
            modelBuilder.Configurations.Add(new activity_log_step_waitingMap());
            modelBuilder.Configurations.Add(new activity_logviewMap());
            modelBuilder.Configurations.Add(new alrmcMap());
            modelBuilder.Configurations.Add(new alrmpctcMap());
            modelBuilder.Configurations.Add(new emarcMap());
            modelBuilder.Configurations.Add(new emcicMap());
            modelBuilder.Configurations.Add(new gpcMap());
            modelBuilder.Configurations.Add(new hactivity_logmonthMap());
            modelBuilder.Configurations.Add(new hwr_monthMap());
            modelBuilder.Configurations.Add(new resrmviewMap());
            modelBuilder.Configurations.Add(new resrsviewMap());
            modelBuilder.Configurations.Add(new resviewMap());
            modelBuilder.Configurations.Add(new rmcMap());
            modelBuilder.Configurations.Add(new rmpctcMap());
            modelBuilder.Configurations.Add(new rrappdetMap());
            modelBuilder.Configurations.Add(new rrcostdetMap());
            modelBuilder.Configurations.Add(new rrdayresoccMap());
            modelBuilder.Configurations.Add(new rrdayrmoccMap());
            modelBuilder.Configurations.Add(new rrdayrmreMap());
            modelBuilder.Configurations.Add(new rrdayrmrespluMap());
            modelBuilder.Configurations.Add(new rrdayrrespluMap());
            modelBuilder.Configurations.Add(new rrmoncostdpMap());
            modelBuilder.Configurations.Add(new rrmonnumrreMap());
            modelBuilder.Configurations.Add(new rrmonreqMap());
            modelBuilder.Configurations.Add(new rrmonresrejMap());
            modelBuilder.Configurations.Add(new rrmonrmcapMap());
            modelBuilder.Configurations.Add(new rrmonthresquantMap());
            modelBuilder.Configurations.Add(new rrmonusearrMap());
            modelBuilder.Configurations.Add(new rrressheetMap());
            modelBuilder.Configurations.Add(new rrressheetpluMap());
            modelBuilder.Configurations.Add(new rrwrrestrMap());
            modelBuilder.Configurations.Add(new wohwoMap());
            modelBuilder.Configurations.Add(new wohwostatMap());
            modelBuilder.Configurations.Add(new wostatMap());
            modelBuilder.Configurations.Add(new wr_step_waitingMap());
            modelBuilder.Configurations.Add(new wrcfhwrcfMap());
            modelBuilder.Configurations.Add(new wrhwrMap());
            modelBuilder.Configurations.Add(new wrhwrstatMap());
            modelBuilder.Configurations.Add(new wrpthwrptMap());
            modelBuilder.Configurations.Add(new wrstatMap());
            modelBuilder.Configurations.Add(new wrviewMap());
        }
    }
}