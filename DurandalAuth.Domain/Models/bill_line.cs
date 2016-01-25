using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class bill_line
    {
        public string bill_type_id { get; set; }
        public string bill_unit_id { get; set; }
        public string description { get; set; }
        public decimal qty { get; set; }
        public decimal qty_energy { get; set; }
        public decimal qty_power { get; set; }
        public decimal qty_volume { get; set; }
        public decimal amount_expense { get; set; }
        public decimal amount_income { get; set; }
        public string vn_id { get; set; }
        public string bill_id { get; set; }
        public short bill_line_id { get; set; }
        public virtual bill bill { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual vn vn { get; set; }
    }
}
