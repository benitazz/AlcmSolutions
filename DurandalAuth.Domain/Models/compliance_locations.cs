using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class compliance_locations
    {
        public compliance_locations()
        {
            this.activity_log = new List<activity_log>();
            this.docs_assigned = new List<docs_assigned>();
            this.ls_comm = new List<ls_comm>();
            this.regviolations = new List<regviolation>();
        }

        public string bl_id { get; set; }
        public string city_id { get; set; }
        public string county_id { get; set; }
        public string ctry_id { get; set; }
        public string em_id { get; set; }
        public string eq_id { get; set; }
        public string eq_std { get; set; }
        public string fl_id { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public string geo_region_id { get; set; }
        public Nullable<decimal> lat { get; set; }
        public Nullable<decimal> lon { get; set; }
        public string pr_id { get; set; }
        public string regn_id { get; set; }
        public string rm_id { get; set; }
        public string site_id { get; set; }
        public string state_id { get; set; }
        public int location_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual bl bl { get; set; }
        public virtual City city { get; set; }
        public virtual County county { get; set; }
        public virtual ctry ctry { get; set; }
        public virtual Em em { get; set; }
        public virtual eq eq { get; set; }
        public virtual eqstd eqstd { get; set; }
        public virtual Fl fl { get; set; }
        public virtual geo_region geo_region { get; set; }
        public virtual Property property { get; set; }
        public virtual regn regn { get; set; }
        public virtual Rm rm { get; set; }
        public virtual site site { get; set; }
        public virtual state state { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
        public virtual ICollection<ls_comm> ls_comm { get; set; }
        public virtual regloc regloc { get; set; }
        public virtual ICollection<regviolation> regviolations { get; set; }
    }
}
