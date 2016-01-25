using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class hwrcfana
    {
        public decimal avail_labor_hours { get; set; }
        public decimal avg_response_time { get; set; }
        public string cause_type { get; set; }
        public string cf_id { get; set; }
        public decimal est_labor_hours { get; set; }
        public short is_pm { get; set; }
        public Nullable<short> month { get; set; }
        public string prob_type { get; set; }
        public string repair_type { get; set; }
        public string reports_to { get; set; }
        public string tr_id { get; set; }
        public string work_type { get; set; }
        public Nullable<short> year { get; set; }
        public decimal act_labor_hours { get; set; }
        public int auto_number { get; set; }
    }
}
