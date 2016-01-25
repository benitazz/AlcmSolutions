using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class msds_data
    {
        public msds_data()
        {
            this.ehs_chemicals = new List<ehs_chemicals>();
            this.msds_constituent = new List<msds_constituent>();
            this.msds_haz_classification = new List<msds_haz_classification>();
            this.msds_location = new List<msds_location>();
        }

        public string chemical_name { get; set; }
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
        public int msds_id { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_type bill_type1 { get; set; }
        public virtual bill_type bill_type2 { get; set; }
        public virtual bill_type bill_type3 { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual bill_unit bill_unit1 { get; set; }
        public virtual bill_unit bill_unit2 { get; set; }
        public virtual bill_unit bill_unit3 { get; set; }
        public virtual Company company { get; set; }
        public virtual Company company1 { get; set; }
        public virtual Company company2 { get; set; }
        public virtual ICollection<ehs_chemicals> ehs_chemicals { get; set; }
        public virtual ICollection<msds_constituent> msds_constituent { get; set; }
        public virtual ICollection<msds_haz_classification> msds_haz_classification { get; set; }
        public virtual ICollection<msds_location> msds_location { get; set; }
    }
}
