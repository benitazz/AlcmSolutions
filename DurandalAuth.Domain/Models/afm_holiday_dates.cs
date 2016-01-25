using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_holiday_dates
    {
        public System.DateTime cal_date { get; set; }
        public string ctry_id { get; set; }
        public string description { get; set; }
        public string description_01 { get; set; }
        public string description_02 { get; set; }
        public string description_03 { get; set; }
        public string description_ch { get; set; }
        public string description_de { get; set; }
        public string description_es { get; set; }
        public string description_fr { get; set; }
        public string description_it { get; set; }
        public string description_jp { get; set; }
        public string description_ko { get; set; }
        public string description_nl { get; set; }
        public string description_no { get; set; }
        public string description_zh { get; set; }
        public string regn_id { get; set; }
        public string transfer_status { get; set; }
        public int auto_number { get; set; }
        public virtual ctry ctry { get; set; }
        public virtual regn regn { get; set; }
    }
}
