using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class bas_data_time_norm_num
    {
        public int data_point_id { get; set; }
        public System.DateTime date_measured { get; set; }
        public decimal delta { get; set; }
        public string interval { get; set; }
        public System.DateTime time_measured { get; set; }
        public decimal value_common { get; set; }
        public int auto_number { get; set; }
        public virtual bas_data_point bas_data_point { get; set; }
    }
}
