using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_cert_credits
    {
        public gb_cert_credits()
        {
            this.gb_cert_scores = new List<gb_cert_scores>();
        }

        public string credit_name { get; set; }
        public short max_points { get; set; }
        public short min_points { get; set; }
        public string subcredit_name { get; set; }
        public string cert_std { get; set; }
        public string cert_cat { get; set; }
        public string credit_num { get; set; }
        public string subcredit_num { get; set; }
        public string credit_type { get; set; }
        public virtual gb_cert_cat gb_cert_cat { get; set; }
        public virtual gb_cert_std gb_cert_std { get; set; }
        public virtual ICollection<gb_cert_scores> gb_cert_scores { get; set; }
    }
}
