using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class sbperiod
    {
        public string p01_title { get; set; }
        public string p02_title { get; set; }
        public string p03_title { get; set; }
        public string p04_title { get; set; }
        public string p05_title { get; set; }
        public string p06_title { get; set; }
        public string p07_title { get; set; }
        public string p08_title { get; set; }
        public string p09_title { get; set; }
        public string p10_title { get; set; }
        public string p11_title { get; set; }
        public string p12_title { get; set; }
        public string sb_name { get; set; }
        public string p00_title { get; set; }
        public virtual sb sb { get; set; }
    }
}
