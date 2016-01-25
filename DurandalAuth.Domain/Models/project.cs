#region

using System;
using System.Collections.Generic;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The project.
    /// </summary>
    public class project
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="project"/> class.
        /// </summary>
        public project()
        {
            this.activity_log = new List<activity_log>();
            this.activity_log_trans = new List<activity_log_trans>();
            this.commsubs = new List<commsub>();
            this.invoices = new List<invoice>();
            this.ls_comm = new List<ls_comm>();
            this.moes = new List<mo>();
            this.mo_scenario = new List<mo_scenario>();
            this.mo_scenario_em = new List<MoScenarioEm>();
            this.proj_forecast = new List<proj_forecast>();
            this.proj_forecast_item = new List<proj_forecast_item>();
            this.projfunds = new List<projfund>();
            this.projscns = new List<projscn>();
            this.projteams = new List<ProjectTeam>();
            this.regprograms = new List<regprogram>();
            this.trialprojects = new List<trialproject>();
            this.work_pkg_bids = new List<work_pkg_bids>();
            this.work_pkgs = new List<work_pkgs>();
        }

        /// <summary>
        /// Gets or sets the ac_id.
        /// </summary>
        public string ac_id { get; set; }

        /// <summary>
        /// Gets or sets the actions_locked.
        /// </summary>
        public short actions_locked { get; set; }

        /// <summary>
        /// Gets or sets the age_existing.
        /// </summary>
        public decimal age_existing { get; set; }

        /// <summary>
        /// Gets or sets the apprv_mgr 1.
        /// </summary>
        public string apprv_mgr1 { get; set; }

        /// <summary>
        /// Gets or sets the apprv_mgr 1_status.
        /// </summary>
        public string apprv_mgr1_status { get; set; }

        /// <summary>
        /// Gets or sets the apprv_mgr 2.
        /// </summary>
        public string apprv_mgr2 { get; set; }

        /// <summary>
        /// Gets or sets the apprv_mgr 2_status.
        /// </summary>
        public string apprv_mgr2_status { get; set; }

        /// <summary>
        /// Gets or sets the apprv_mgr 3.
        /// </summary>
        public string apprv_mgr3 { get; set; }

        /// <summary>
        /// Gets or sets the apprv_mgr 3_status.
        /// </summary>
        public string apprv_mgr3_status { get; set; }

        /// <summary>
        /// Gets or sets the area_affected.
        /// </summary>
        public decimal area_affected { get; set; }

        /// <summary>
        /// Gets or sets the benefit.
        /// </summary>
        public string benefit { get; set; }

        /// <summary>
        /// Gets or sets the bl_id.
        /// </summary>
        public string bl_id { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        public string comments { get; set; }

        /// <summary>
        /// Gets or sets the contact_id.
        /// </summary>
        public string contact_id { get; set; }

        /// <summary>
        /// Gets or sets the cost_bestcase.
        /// </summary>
        public decimal cost_bestcase { get; set; }

        /// <summary>
        /// Gets or sets the cost_budget.
        /// </summary>
        public decimal cost_budget { get; set; }

        /// <summary>
        /// Gets or sets the cost_committed.
        /// </summary>
        public decimal cost_committed { get; set; }

        /// <summary>
        /// Gets or sets the cost_est_baseline.
        /// </summary>
        public decimal cost_est_baseline { get; set; }

        /// <summary>
        /// Gets or sets the cost_est_design.
        /// </summary>
        public decimal cost_est_design { get; set; }

        /// <summary>
        /// Gets or sets the cost_likely.
        /// </summary>
        public decimal cost_likely { get; set; }

        /// <summary>
        /// Gets or sets the cost_mgmt_res.
        /// </summary>
        public decimal cost_mgmt_res { get; set; }

        /// <summary>
        /// Gets or sets the cost_neg_chgs.
        /// </summary>
        public decimal cost_neg_chgs { get; set; }

        /// <summary>
        /// Gets or sets the cost_negotiated.
        /// </summary>
        public decimal cost_negotiated { get; set; }

        /// <summary>
        /// Gets or sets the cost_paid.
        /// </summary>
        public decimal cost_paid { get; set; }

        /// <summary>
        /// Gets or sets the cost_target_cur.
        /// </summary>
        public decimal cost_target_cur { get; set; }

        /// <summary>
        /// Gets or sets the cost_target_orig.
        /// </summary>
        public decimal cost_target_orig { get; set; }

        /// <summary>
        /// Gets or sets the cost_worstcase.
        /// </summary>
        public decimal cost_worstcase { get; set; }

        /// <summary>
        /// Gets or sets the date_accepted.
        /// </summary>
        public DateTime? date_accepted { get; set; }

        /// <summary>
        /// Gets or sets the date_app_mgr 1.
        /// </summary>
        public DateTime? date_app_mgr1 { get; set; }

        /// <summary>
        /// Gets or sets the date_app_mgr 2.
        /// </summary>
        public DateTime? date_app_mgr2 { get; set; }

        /// <summary>
        /// Gets or sets the date_app_mgr 3.
        /// </summary>
        public DateTime? date_app_mgr3 { get; set; }

        /// <summary>
        /// Gets or sets the date_approved.
        /// </summary>
        public DateTime? date_approved { get; set; }

        /// <summary>
        /// Gets or sets the date_baseline.
        /// </summary>
        public DateTime? date_baseline { get; set; }

        /// <summary>
        /// Gets or sets the date_bids_award.
        /// </summary>
        public DateTime? date_bids_award { get; set; }

        /// <summary>
        /// Gets or sets the date_closed.
        /// </summary>
        public DateTime? date_closed { get; set; }

        /// <summary>
        /// Gets or sets the date_commence_work.
        /// </summary>
        public DateTime? date_commence_work { get; set; }

        /// <summary>
        /// Gets or sets the date_completed.
        /// </summary>
        public DateTime? date_completed { get; set; }

        /// <summary>
        /// Gets or sets the date_cont_end.
        /// </summary>
        public DateTime? date_cont_end { get; set; }

        /// <summary>
        /// Gets or sets the date_created.
        /// </summary>
        public DateTime date_created { get; set; }

        /// <summary>
        /// Gets or sets the date_design_com.
        /// </summary>
        public DateTime? date_design_com { get; set; }

        /// <summary>
        /// Gets or sets the date_end.
        /// </summary>
        public DateTime? date_end { get; set; }

        /// <summary>
        /// Gets or sets the date_issued.
        /// </summary>
        public DateTime? date_issued { get; set; }

        /// <summary>
        /// Gets or sets the date_requested.
        /// </summary>
        public DateTime? date_requested { get; set; }

        /// <summary>
        /// Gets or sets the date_settlement.
        /// </summary>
        public DateTime? date_settlement { get; set; }

        /// <summary>
        /// Gets or sets the date_start.
        /// </summary>
        public DateTime? date_start { get; set; }

        /// <summary>
        /// Gets or sets the date_target_end.
        /// </summary>
        public DateTime? date_target_end { get; set; }

        /// <summary>
        /// Gets or sets the days_per_week.
        /// </summary>
        public short days_per_week { get; set; }

        /// <summary>
        /// Gets or sets the dept_contact.
        /// </summary>
        public string dept_contact { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the doc.
        /// </summary>
        public string doc { get; set; }

        /// <summary>
        /// Gets or sets the doc_acts_xfer.
        /// </summary>
        public string doc_acts_xfer { get; set; }

        /// <summary>
        /// Gets or sets the doc_charter.
        /// </summary>
        public string doc_charter { get; set; }

        /// <summary>
        /// Gets or sets the doc_image.
        /// </summary>
        public string doc_image { get; set; }

        /// <summary>
        /// Gets or sets the doc_impl_plan.
        /// </summary>
        public string doc_impl_plan { get; set; }

        /// <summary>
        /// Gets or sets the doc_risk_mgmt.
        /// </summary>
        public string doc_risk_mgmt { get; set; }

        /// <summary>
        /// Gets or sets the dp_id.
        /// </summary>
        public string dp_id { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        public short duration { get; set; }

        /// <summary>
        /// Gets or sets the duration_est.
        /// </summary>
        public short duration_est { get; set; }

        /// <summary>
        /// Gets or sets the dv_id.
        /// </summary>
        public string dv_id { get; set; }

        /// <summary>
        /// Gets or sets the emp_affected.
        /// </summary>
        public int emp_affected { get; set; }

        /// <summary>
        /// Gets or sets the funding_probability.
        /// </summary>
        public short funding_probability { get; set; }

        /// <summary>
        /// Gets or sets the hierarchy_ids.
        /// </summary>
        public string hierarchy_ids { get; set; }

        /// <summary>
        /// Gets or sets the hours_actual.
        /// </summary>
        public int hours_actual { get; set; }

        /// <summary>
        /// Gets or sets the hours_est.
        /// </summary>
        public int hours_est { get; set; }

        /// <summary>
        /// Gets or sets the is_template.
        /// </summary>
        public short is_template { get; set; }

        /// <summary>
        /// Gets or sets the life_expectancy.
        /// </summary>
        public decimal life_expectancy { get; set; }

        /// <summary>
        /// Gets or sets the option 1.
        /// </summary>
        public string option1 { get; set; }

        /// <summary>
        /// Gets or sets the option 2.
        /// </summary>
        public string option2 { get; set; }

        /// <summary>
        /// Gets or sets the pct_const_comp.
        /// </summary>
        public short pct_const_comp { get; set; }

        /// <summary>
        /// Gets or sets the pct_design_comp.
        /// </summary>
        public short pct_design_comp { get; set; }

        /// <summary>
        /// Gets or sets the pct_total_comp.
        /// </summary>
        public short pct_total_comp { get; set; }

        /// <summary>
        /// Gets or sets the phone_dept_contact.
        /// </summary>
        public string phone_dept_contact { get; set; }

        /// <summary>
        /// Gets or sets the phone_req.
        /// </summary>
        public string phone_req { get; set; }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        public short priority { get; set; }

        /// <summary>
        /// Gets or sets the prob_type.
        /// </summary>
        public string prob_type { get; set; }

        /// <summary>
        /// Gets or sets the program_id.
        /// </summary>
        public string program_id { get; set; }

        /// <summary>
        /// Gets or sets the proj_mgr.
        /// </summary>
        public string proj_mgr { get; set; }

        /// <summary>
        /// Gets or sets the project_name.
        /// </summary>
        public string project_name { get; set; }

        /// <summary>
        /// Gets or sets the project_num.
        /// </summary>
        public string project_num { get; set; }

        /// <summary>
        /// Gets or sets the project_quest.
        /// </summary>
        public string project_quest { get; set; }

        /// <summary>
        /// Gets or sets the project_type.
        /// </summary>
        public string project_type { get; set; }

        /// <summary>
        /// Gets or sets the requestor.
        /// </summary>
        public string requestor { get; set; }

        /// <summary>
        /// Gets or sets the scope.
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        /// Gets or sets the sequence.
        /// </summary>
        public short sequence { get; set; }

        /// <summary>
        /// Gets or sets the site_id.
        /// </summary>
        public string site_id { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// Gets or sets the summary.
        /// </summary>
        public string summary { get; set; }

        /// <summary>
        /// Gets or sets the project_id.
        /// </summary>
        public string project_id { get; set; }

        /// <summary>
        /// Gets or sets the ac.
        /// </summary>
        public virtual ac ac { get; set; }

        /// <summary>
        /// Gets or sets the activity_log.
        /// </summary>
        public virtual ICollection<activity_log> activity_log { get; set; }

        /// <summary>
        /// Gets or sets the activity_log_trans.
        /// </summary>
        public virtual ICollection<activity_log_trans> activity_log_trans { get; set; }

        /// <summary>
        /// Gets or sets the bl.
        /// </summary>
        public virtual bl bl { get; set; }

        /// <summary>
        /// Gets or sets the commsubs.
        /// </summary>
        public virtual ICollection<commsub> commsubs { get; set; }

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        public virtual Contact contact { get; set; }

        /// <summary>
        /// Gets or sets the dp.
        /// </summary>
        public virtual dp dp { get; set; }

        /// <summary>
        /// Gets or sets the dv.
        /// </summary>
        public virtual dv dv { get; set; }

        /// <summary>
        /// Gets or sets the em.
        /// </summary>
        public virtual Em em { get; set; }

        /// <summary>
        /// Gets or sets the em 1.
        /// </summary>
        public virtual Em em1 { get; set; }

        /// <summary>
        /// Gets or sets the em 2.
        /// </summary>
        public virtual Em em2 { get; set; }

        /// <summary>
        /// Gets or sets the em 3.
        /// </summary>
        public virtual Em em3 { get; set; }

        /// <summary>
        /// Gets or sets the em 4.
        /// </summary>
        public virtual Em em4 { get; set; }

        /// <summary>
        /// Gets or sets the em 5.
        /// </summary>
        public virtual Em em5 { get; set; }

        /// <summary>
        /// Gets or sets the invoices.
        /// </summary>
        public virtual ICollection<invoice> invoices { get; set; }

        /// <summary>
        /// Gets or sets the ls_comm.
        /// </summary>
        public virtual ICollection<ls_comm> ls_comm { get; set; }

        /// <summary>
        /// Gets or sets the moes.
        /// </summary>
        public virtual ICollection<mo> moes { get; set; }

        /// <summary>
        /// Gets or sets the mo_scenario.
        /// </summary>
        public virtual ICollection<mo_scenario> mo_scenario { get; set; }

        /// <summary>
        /// Gets or sets the mo_scenario_em.
        /// </summary>
        public virtual ICollection<MoScenarioEm> mo_scenario_em { get; set; }

        /// <summary>
        /// Gets or sets the probtype.
        /// </summary>
        public virtual probtype probtype { get; set; }

        /// <summary>
        /// Gets or sets the program.
        /// </summary>
        public virtual program program { get; set; }

        /// <summary>
        /// Gets or sets the proj_forecast.
        /// </summary>
        public virtual ICollection<proj_forecast> proj_forecast { get; set; }

        /// <summary>
        /// Gets or sets the proj_forecast_item.
        /// </summary>
        public virtual ICollection<proj_forecast_item> proj_forecast_item { get; set; }

        /// <summary>
        /// Gets or sets the projecttype.
        /// </summary>
        public virtual projecttype projecttype { get; set; }

        /// <summary>
        /// Gets or sets the site.
        /// </summary>
        public virtual site site { get; set; }

        /// <summary>
        /// Gets or sets the projfunds.
        /// </summary>
        public virtual ICollection<projfund> projfunds { get; set; }

        /// <summary>
        /// Gets or sets the projscns.
        /// </summary>
        public virtual ICollection<projscn> projscns { get; set; }

        /// <summary>
        /// Gets or sets the projteams.
        /// </summary>
        public virtual ICollection<ProjectTeam> projteams { get; set; }

        /// <summary>
        /// Gets or sets the regprograms.
        /// </summary>
        public virtual ICollection<regprogram> regprograms { get; set; }

        /// <summary>
        /// Gets or sets the trialprojects.
        /// </summary>
        public virtual ICollection<trialproject> trialprojects { get; set; }

        /// <summary>
        /// Gets or sets the work_pkg_bids.
        /// </summary>
        public virtual ICollection<work_pkg_bids> work_pkg_bids { get; set; }

        /// <summary>
        /// Gets or sets the work_pkgs.
        /// </summary>
        public virtual ICollection<work_pkgs> work_pkgs { get; set; }
    }
}