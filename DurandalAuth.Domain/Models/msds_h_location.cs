using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class msds_h_location
    {
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public Nullable<System.DateTime> date_updated { get; set; }
        public string description { get; set; }
        public string eq_id { get; set; }
        public decimal evacuation_radius { get; set; }
        public string evacuation_radius_units { get; set; }
        public string evacuation_radius_units_type { get; set; }
        public string fl_id { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public Nullable<decimal> lat { get; set; }
        public Nullable<decimal> lon { get; set; }
        public int msds_id { get; set; }
        public int num_containers { get; set; }
        public Nullable<decimal> pressure { get; set; }
        public string pressure_units { get; set; }
        public string pressure_units_type { get; set; }
        public decimal quantity { get; set; }
        public string quantity_units { get; set; }
        public string quantity_units_type { get; set; }
        public string rm_id { get; set; }
        public string site_id { get; set; }
        public Nullable<decimal> temperature { get; set; }
        public string temperature_units { get; set; }
        public string bl_id { get; set; }
        public string container_cat { get; set; }
        public string container_type { get; set; }
        public int auto_number { get; set; }
        public System.DateTime date_archived { get; set; }
        public System.DateTime time_archived { get; set; }
    }
}
