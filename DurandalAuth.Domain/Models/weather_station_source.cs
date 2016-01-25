using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class weather_station_source
    {
        public weather_station_source()
        {
            this.bls = new List<bl>();
            this.weather_station = new List<weather_station>();
            this.weather_station_data = new List<weather_station_data>();
            this.weather_station_data_sum = new List<weather_station_data_sum>();
        }

        public string access_id { get; set; }
        public string access_pwd { get; set; }
        public string description { get; set; }
        public string protocol { get; set; }
        public string url_address { get; set; }
        public string weather_source_id { get; set; }
        public virtual ICollection<bl> bls { get; set; }
        public virtual ICollection<weather_station> weather_station { get; set; }
        public virtual ICollection<weather_station_data> weather_station_data { get; set; }
        public virtual ICollection<weather_station_data_sum> weather_station_data_sum { get; set; }
    }
}
