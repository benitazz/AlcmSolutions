using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class geo_region
    {
        public geo_region()
        {
            this.compliance_locations = new List<compliance_locations>();
            this.ctries = new List<ctry>();
        }

        public string geo_region_name { get; set; }
        public string hpattern_acad { get; set; }
        public Nullable<decimal> lat { get; set; }
        public Nullable<decimal> lon { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string description { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public string geo_region_id { get; set; }
        public virtual ICollection<compliance_locations> compliance_locations { get; set; }
        public virtual ICollection<ctry> ctries { get; set; }
    }
}
