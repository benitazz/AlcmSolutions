using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class projfund
    {
        public decimal amount_cap { get; set; }
        public decimal amount_exp { get; set; }
        public string description { get; set; }
        public string project_id { get; set; }
        public string fund_id { get; set; }
        public short fiscal_year { get; set; }
        public virtual funding funding { get; set; }
        public virtual project project { get; set; }
    }
}
