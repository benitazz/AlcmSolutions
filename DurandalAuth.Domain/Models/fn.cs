namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The fn.
    /// </summary>
    public partial class fn
    {
        /// <summary>
        /// Gets or sets the bl_id.
        /// </summary>
        public string bl_id { get; set; }

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
        /// Gets or sets the fl_id.
        /// </summary>
        public string fl_id { get; set; }

        /// <summary>
        /// Gets or sets the fn_std.
        /// </summary>
        public string FnStd { get; set; }

        /// <summary>
        /// Gets or sets the layer_name.
        /// </summary>
        public string LayerName { get; set; }

        /// <summary>
        /// Gets or sets the rm_id.
        /// </summary>
        public string rm_id { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the fn_id.
        /// </summary>
        public int FnId { get; set; }

        /// <summary>
        /// Gets or sets the bl.
        /// </summary>
        public virtual bl Bl { get; set; }

        /// <summary>
        /// Gets or sets the dp.
        /// </summary>
        public virtual dp Dp { get; set; }

        /// <summary>
        /// Gets or sets the dv.
        /// </summary>
        public virtual dv Dv { get; set; }

        /// <summary>
        /// Gets or sets the fl.
        /// </summary>
        public virtual Fl Fl { get; set; }

        /// <summary>
        /// Gets or sets the fnstd.
        /// </summary>
        public virtual fnstd Fnstd { get; set; }

        /// <summary>
        /// Gets or sets the rm.
        /// </summary>
        public virtual Rm Rm { get; set; }
    }
}