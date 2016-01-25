using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class prog_budget_items
    {
        public decimal cost_budget_cap { get; set; }
        public decimal cost_budget_exp { get; set; }
        public string source { get; set; }
        public string budget_id { get; set; }
        public string program_id { get; set; }
        public short fiscal_year { get; set; }
        public virtual budget budget { get; set; }
        public virtual program program { get; set; }
    }
}
