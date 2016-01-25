using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_cal_dates
    {
        public string day_type { get; set; }
        public string description { get; set; }
        public string transfer_status { get; set; }
        public System.DateTime cal_date { get; set; }
    }
}
