using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class bas_data_clean_num
    {
        public int data_point_id { get; set; }
        public System.DateTime date_measured { get; set; }
        public decimal delta { get; set; }
        public string process_status { get; set; }
        public System.DateTime time_measured { get; set; }
        public decimal value_reported { get; set; }
        public int auto_number { get; set; }
        public virtual bas_data_point bas_data_point { get; set; }
    }
}
