using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class weather_station_data_sum
    {
        public short sum_cdd { get; set; }
        public short sum_hdd { get; set; }
        public string weather_source_id { get; set; }
        public string weather_station_id { get; set; }
        public short year_reported { get; set; }
        public string month_reported { get; set; }
        public virtual weather_station_source weather_station_source { get; set; }
    }
}
