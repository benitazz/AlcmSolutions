using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cbudcmpr
    {
        public decimal amount_expense_bud1 { get; set; }
        public decimal amount_expense_bud2 { get; set; }
        public decimal amount_income_bud1 { get; set; }
        public decimal amount_income_bud2 { get; set; }
        public string budget_id1 { get; set; }
        public string budget_id2 { get; set; }
        public string cost_cat_id { get; set; }
        public decimal diff_expense { get; set; }
        public decimal diff_income { get; set; }
        public decimal diff_total { get; set; }
        public int auto_number { get; set; }
    }
}
