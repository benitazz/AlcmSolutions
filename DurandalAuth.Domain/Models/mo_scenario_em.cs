#region

using System;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The mo_scenario_em.
    /// </summary>
    public class MoScenarioEm
    {
        /// <summary>
        /// Gets or sets the date_end.
        /// </summary>
        public DateTime? date_end { get; set; }

        /// <summary>
        /// Gets or sets the date_start.
        /// </summary>
        public DateTime? date_start { get; set; }

        /// <summary>
        /// Gets or sets the to_bl_id.
        /// </summary>
        public string to_bl_id { get; set; }

        /// <summary>
        /// Gets or sets the to_fl_id.
        /// </summary>
        public string to_fl_id { get; set; }

        /// <summary>
        /// Gets or sets the to_rm_id.
        /// </summary>
        public string to_rm_id { get; set; }

        /// <summary>
        /// Gets or sets the project_id.
        /// </summary>
        public string project_id { get; set; }

        /// <summary>
        /// Gets or sets the scenario_id.
        /// </summary>
        public string scenario_id { get; set; }

        /// <summary>
        /// Gets or sets the em_id.
        /// </summary>
        public string em_id { get; set; }

        /// <summary>
        /// Gets or sets the em.
        /// </summary>
        public virtual Em em { get; set; }

        /// <summary>
        /// Gets or sets the mo_scenario.
        /// </summary>
        public virtual mo_scenario mo_scenario { get; set; }

        /// <summary>
        /// Gets or sets the project.
        /// </summary>
        public virtual project project { get; set; }
    }
}