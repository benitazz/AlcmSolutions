using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class proj_forecast
    {
        public proj_forecast()
        {
            this.proj_forecast_item = new List<proj_forecast_item>();
        }

        public System.DateTime date_created { get; set; }
        public string description { get; set; }
        public string project_id { get; set; }
        public string proj_forecast_id { get; set; }
        public virtual ICollection<proj_forecast_item> proj_forecast_item { get; set; }
        public virtual project project { get; set; }
    }
}
