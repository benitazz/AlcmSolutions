using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_hmetric_trend_values
    {
        public string bl_id { get; set; }
        public string collect_by_value { get; set; }
        public string collect_err_msg { get; set; }
        public string collect_group_by { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public System.DateTime metric_date { get; set; }
        public string metric_name { get; set; }
        public decimal metric_value { get; set; }
        public decimal metric_value_last { get; set; }
        public decimal metric_value_last_yr { get; set; }
        public string metric_value_prev { get; set; }
        public int auto_number { get; set; }
    }
}
