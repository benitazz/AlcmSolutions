namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The f.
    /// </summary>
    public partial class f
    {
        /// <summary>
        /// Gets or sets the dp_id.
        /// </summary>
        public string dp_id { get; set; }

        /// <summary>
        /// Gets or sets the dv_id.
        /// </summary>
        public string dv_id { get; set; }

        /// <summary>
        /// Gets or sets the fn_count.
        /// </summary>
        public int fn_count { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// Gets or sets the survey_id.
        /// </summary>
        public string survey_id { get; set; }

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
        /// Gets or sets the fn_std.
        /// </summary>
        public string fn_std { get; set; }

        /// <summary>
        /// Gets or sets the bl.
        /// </summary>
        public virtual bl bl { get; set; }

        /// <summary>
        /// Gets or sets the dp.
        /// </summary>
        public virtual dp dp { get; set; }

        /// <summary>
        /// Gets or sets the dv.
        /// </summary>
        public virtual dv dv { get; set; }

        /// <summary>
        /// Gets or sets the fl.
        /// </summary>
        public virtual Fl fl { get; set; }

        /// <summary>
        /// Gets or sets the fnstd.
        /// </summary>
        public virtual fnstd fnstd { get; set; }

        /// <summary>
        /// Gets or sets the rm.
        /// </summary>
        public virtual Rm rm { get; set; }

        /// <summary>
        /// Gets or sets the survey.
        /// </summary>
        public virtual survey survey { get; set; }
    }
}