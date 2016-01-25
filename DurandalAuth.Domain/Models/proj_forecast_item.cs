using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class proj_forecast_item
    {
        public decimal cost_forecast { get; set; }
        public string created_by { get; set; }
        public System.DateTime date_created { get; set; }
        public Nullable<System.DateTime> date_forecast { get; set; }
        public string proj_forecast_id { get; set; }
        public string project_id { get; set; }
        public string work_pkg_id { get; set; }
        public int proj_forecast_item_id { get; set; }
        public virtual proj_forecast proj_forecast { get; set; }
        public virtual project project { get; set; }
        public virtual work_pkgs work_pkgs { get; set; }
    }
}
