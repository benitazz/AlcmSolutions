using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_cert_scores
    {
        public int annual_savings { get; set; }
        public int capital_cost { get; set; }
        public string final_notes { get; set; }
        public short final_score { get; set; }
        public Nullable<System.DateTime> last_update { get; set; }
        public string score_note { get; set; }
        public short self_score { get; set; }
        public string bl_id { get; set; }
        public string cert_std { get; set; }
        public string project_name { get; set; }
        public string cert_cat { get; set; }
        public string credit_num { get; set; }
        public string subcredit_num { get; set; }
        public string credit_type { get; set; }
        public virtual bl bl { get; set; }
        public virtual gb_cert_cat gb_cert_cat { get; set; }
        public virtual gb_cert_credits gb_cert_credits { get; set; }
        public virtual gb_cert_proj gb_cert_proj { get; set; }
        public virtual gb_cert_std gb_cert_std { get; set; }
    }
}
