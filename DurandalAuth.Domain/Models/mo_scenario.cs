#region

using System;
using System.Collections.Generic;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The mo_scenario.
    /// </summary>
    public class mo_scenario
    {
       /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        public string comments { get; set; }

        /// <summary>
        /// Gets or sets the date_created.
        /// </summary>
        public DateTime date_created { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the planner.
        /// </summary>
        public string planner { get; set; }

        /// <summary>
        /// Gets or sets the project_id.
        /// </summary>
        public string project_id { get; set; }

        /// <summary>
        /// Gets or sets the scenario_id.
        /// </summary>
        public string scenario_id { get; set; }

        /// <summary>
        /// Gets or sets the em.
        /// </summary>
        public virtual Em em { get; set; }

        /// <summary>
        /// Gets or sets the mo_scenario_em.
        /// </summary>
        public virtual ICollection<MoScenarioEm> mo_scenario_em { get; set; }

        /// <summary>
        /// Gets or sets the project.
        /// </summary>
        public virtual project project { get; set; }
    }
}