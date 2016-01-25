using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class bas_data_point
    {
        public bas_data_point()
        {
            this.bas_data_clean_num = new List<bas_data_clean_num>();
            this.bas_data_time_norm_num = new List<bas_data_time_norm_num>();
            this.bas_measurement_scope = new List<bas_measurement_scope>();
        }

        public decimal area { get; set; }
        public decimal area_manual { get; set; }
        public string bill_type_id { get; set; }
        public string bill_unit_id { get; set; }
        public string data_point_type { get; set; }
        public string data_type { get; set; }
        public string description { get; set; }
        public string eq_id { get; set; }
        public string name { get; set; }
        public int sampling_interval { get; set; }
        public int data_point_id { get; set; }
        public virtual ICollection<bas_data_clean_num> bas_data_clean_num { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual eq eq { get; set; }
        public virtual ICollection<bas_data_time_norm_num> bas_data_time_norm_num { get; set; }
        public virtual ICollection<bas_measurement_scope> bas_measurement_scope { get; set; }
    }
}
