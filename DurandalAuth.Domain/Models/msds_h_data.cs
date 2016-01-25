using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class msds_h_data
    {
        public Nullable<System.DateTime> date_issued { get; set; }
        public Nullable<System.DateTime> date_replaced { get; set; }
        public Nullable<System.DateTime> date_supersedes { get; set; }
        public Nullable<decimal> density_high { get; set; }
        public Nullable<decimal> density_low { get; set; }
        public string density_operator { get; set; }
        public string density_units { get; set; }
        public string density_units_type { get; set; }
        public string description { get; set; }
        public string distributor_id { get; set; }
        public string doc { get; set; }
        public decimal evacuation_radius { get; set; }
        public string evacuation_radius_units { get; set; }
        public string evacuation_radius_units_type { get; set; }
        public string flashpoint_operator { get; set; }
        public string flashpoint_units { get; set; }
        public Nullable<decimal> flashpont { get; set; }
        public string ghs_id { get; set; }
        public string manufacturer_id { get; set; }
        public string physical_state { get; set; }
        public string preparer_id { get; set; }
        public string product_code { get; set; }
        public string product_name { get; set; }
        public string provider_msds_id { get; set; }
        public Nullable<decimal> specific_gravity_high { get; set; }
        public Nullable<decimal> specific_gravity_low { get; set; }
        public string specific_gravity_operator { get; set; }
        public string url { get; set; }
        public Nullable<decimal> vapor_density_high { get; set; }
        public Nullable<decimal> vapor_density_low { get; set; }
        public string vapor_density_operator { get; set; }
        public string vapor_density_units { get; set; }
        public string vapor_density_units_type { get; set; }
        public Nullable<decimal> voc_high { get; set; }
        public Nullable<decimal> voc_low { get; set; }
        public string voc_operator { get; set; }
        public string voc_units { get; set; }
        public string voc_units_type { get; set; }
        public string chemical_name { get; set; }
        public int msds_id { get; set; }
        public System.DateTime date_archived { get; set; }
        public System.DateTime time_archived { get; set; }
    }
}
