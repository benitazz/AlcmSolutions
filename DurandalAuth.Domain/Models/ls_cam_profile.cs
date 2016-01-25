using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ls_cam_profile
    {
        public string cam_alloc_method { get; set; }
        public Nullable<decimal> cam_area_negotiated { get; set; }
        public Nullable<decimal> cam_cost_area { get; set; }
        public Nullable<decimal> cam_cost_fixed { get; set; }
        public Nullable<decimal> cam_cost_per_area { get; set; }
        public Nullable<decimal> cam_cost_rent_pct { get; set; }
        public string cam_freq { get; set; }
        public Nullable<decimal> cam_rent { get; set; }
        public Nullable<decimal> cam_rent_pct { get; set; }
        public string cam_year_type { get; set; }
        public Nullable<System.DateTime> date_rent_last_update { get; set; }
        public string ls_id { get; set; }
        public virtual l l { get; set; }
    }
}
