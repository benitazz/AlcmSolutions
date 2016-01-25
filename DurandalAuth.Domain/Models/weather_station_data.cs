using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class weather_station_data
    {
        public short estimated { get; set; }
        public decimal temp_outside_air { get; set; }
        public string weather_source_id { get; set; }
        public string weather_station_id { get; set; }
        public System.DateTime date_reported { get; set; }
        public virtual weather_station_source weather_station_source { get; set; }
    }
}
