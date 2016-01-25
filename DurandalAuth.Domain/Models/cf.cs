namespace DurandalAuth.Domain.Models
{
    #region

    using System;
    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// The cf.
    /// </summary>
    public partial class cf
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="cf"/> class.
        /// </summary>
        public cf()
        {
            this.ActivityLog = new List<activity_log>();
            this.HelpdeskSlaResponse = new List<helpdesk_sla_response>();
            this.HelpdeskSlaSteps = new List<helpdesk_sla_steps>();
            this.HelpdeskStepLog = new List<helpdesk_step_log>();
            this.WorkflowSubstitutes = new List<workflow_substitutes>();
            this.WorkflowSubstitutes1 = new List<workflow_substitutes>();
            this.Wrcfs = new List<wrcf>();
            this.WorkTeam1 = new List<work_team>();
        }

        /// <summary>
        /// Gets or sets the date_contract_exp.
        /// </summary>
        public DateTime? DateContractExp { get; set; }

        /// <summary>
        /// Gets or sets the date_ins_auto_exp.
        /// </summary>
        public DateTime? DateInsAutoExp { get; set; }

        /// <summary>
        /// Gets or sets the date_ins_lia_exp.
        /// </summary>
        public DateTime? DateInsLiaExp { get; set; }

        /// <summary>
        /// Gets or sets the date_ins_wc_exp.
        /// </summary>
        public DateTime? DateInsWcExp { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the in_house.
        /// </summary>
        public short InHouse { get; set; }

        /// <summary>
        /// Gets or sets the is_estimator.
        /// </summary>
        public short IsEstimator { get; set; }

        /// <summary>
        /// Gets or sets the is_planner.
        /// </summary>
        public short IsPlanner { get; set; }

        /// <summary>
        /// Gets or sets the is_supervisor.
        /// </summary>
        public short IsSupervisor { get; set; }

        /// <summary>
        /// Gets or sets the issue_work_in_format.
        /// </summary>
        public string IssueWorkInFormat { get; set; }

        /// <summary>
        /// Gets or sets the issue_work_to.
        /// </summary>
        public string IssueWorkTo { get; set; }

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
        /// Gets or sets the position.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the rate_double.
        /// </summary>
        public decimal RateDouble { get; set; }

        /// <summary>
        /// Gets or sets the rate_hourly.
        /// </summary>
        public decimal RateHourly { get; set; }

        /// <summary>
        /// Gets or sets the rate_over.
        /// </summary>
        public decimal RateOver { get; set; }

        /// <summary>
        /// Gets or sets the reports_to.
        /// </summary>
        public string ReportsTo { get; set; }

        /// <summary>
        /// Gets or sets the skills.
        /// </summary>
        public string Skills { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the std_hours_avail.
        /// </summary>
        public decimal StdHoursAvail { get; set; }

        /// <summary>
        /// Gets or sets the tr_id.
        /// </summary>
        public string TrId { get; set; }

        /// <summary>
        /// Gets or sets the work_team_id.
        /// </summary>
        public string WorkTeamId { get; set; }

        /// <summary>
        /// Gets or sets the assign_work.
        /// </summary>
        public short AssignWork { get; set; }

        /// <summary>
        /// Gets or sets the cf_id.
        /// </summary>
        public string CfId { get; set; }

        /// <summary>
        /// Gets or sets the activity_log.
        /// </summary>
        public virtual ICollection<activity_log> ActivityLog { get; set; }

        /// <summary>
        /// Gets or sets the em.
        /// </summary>
        public virtual Em Em { get; set; }

        /// <summary>
        /// Gets or sets the tr.
        /// </summary>
        public virtual tr Tr { get; set; }

        /// <summary>
        /// Gets or sets the work_team.
        /// </summary>
        public virtual work_team WorkTeam { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_sla_response.
        /// </summary>
        public virtual ICollection<helpdesk_sla_response> HelpdeskSlaResponse { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_sla_steps.
        /// </summary>
        public virtual ICollection<helpdesk_sla_steps> HelpdeskSlaSteps { get; set; }

        /// <summary>
        /// Gets or sets the helpdesk_step_log.
        /// </summary>
        public virtual ICollection<helpdesk_step_log> HelpdeskStepLog { get; set; }

        /// <summary>
        /// Gets or sets the workflow_substitutes.
        /// </summary>
        public virtual ICollection<workflow_substitutes> WorkflowSubstitutes { get; set; }

        /// <summary>
        /// Gets or sets the workflow_substitutes 1.
        /// </summary>
        public virtual ICollection<workflow_substitutes> WorkflowSubstitutes1 { get; set; }

        /// <summary>
        /// Gets or sets the wrcfs.
        /// </summary>
        public virtual ICollection<wrcf> Wrcfs { get; set; }

        /// <summary>
        /// Gets or sets the work_team 1.
        /// </summary>
        public virtual ICollection<work_team> WorkTeam1 { get; set; }
    }
}