using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class waste_areas
    {
        public waste_areas()
        {
            this.waste_out = new List<waste_out>();
        }

        public string area_type { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public Nullable<decimal> lat { get; set; }
        public Nullable<decimal> lon { get; set; }
        public string pr_id { get; set; }
        public string rm_id { get; set; }
        public string site_id { get; set; }
        public string storage_location { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Property property { get; set; }
        public virtual Rm rm { get; set; }
        public virtual site site { get; set; }
        public virtual ICollection<waste_out> waste_out { get; set; }
    }
}
