using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wrpthwrpt
    {
        public string comments { get; set; }
        public decimal cost_actual { get; set; }
        public decimal cost_estimated { get; set; }
        public System.DateTime date_assigned { get; set; }
        public Nullable<short> debited { get; set; }
        public string part_id { get; set; }
        public decimal qty_actual { get; set; }
        public decimal qty_estimated { get; set; }
        public decimal qty_picked { get; set; }
        public string status { get; set; }
        public System.DateTime time_assigned { get; set; }
        public int wr_id { get; set; }
    }
}
