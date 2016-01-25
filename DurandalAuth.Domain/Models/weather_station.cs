using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class weather_station
    {
        public weather_station()
        {
            this.bls = new List<bl>();
        }

        public string ctry_id { get; set; }
        public decimal elevation { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public Nullable<decimal> lat { get; set; }
        public Nullable<decimal> lon { get; set; }
        public string state_id { get; set; }
        public string station_location { get; set; }
        public string units_of_measure { get; set; }
        public string weather_source_id { get; set; }
        public string weather_station_id { get; set; }
        public virtual ICollection<bl> bls { get; set; }
        public virtual weather_station_source weather_station_source { get; set; }
    }
}
