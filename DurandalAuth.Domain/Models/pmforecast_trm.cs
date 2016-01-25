using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pmforecast_trm
    {
        public Nullable<decimal> month_01 { get; set; }
        public Nullable<decimal> month_02 { get; set; }
        public Nullable<decimal> month_03 { get; set; }
        public Nullable<decimal> month_04 { get; set; }
        public Nullable<decimal> month_05 { get; set; }
        public Nullable<decimal> month_06 { get; set; }
        public Nullable<decimal> month_07 { get; set; }
        public Nullable<decimal> month_08 { get; set; }
        public Nullable<decimal> month_09 { get; set; }
        public Nullable<decimal> month_10 { get; set; }
        public Nullable<decimal> month_11 { get; set; }
        public Nullable<decimal> month_12 { get; set; }
        public string tr_id { get; set; }
        public virtual tr tr { get; set; }
    }
}
