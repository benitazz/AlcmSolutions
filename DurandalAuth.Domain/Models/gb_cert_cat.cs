using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_cert_cat
    {
        public gb_cert_cat()
        {
            this.gb_cert_credits = new List<gb_cert_credits>();
            this.gb_cert_scores = new List<gb_cert_scores>();
        }

        public string cat_name { get; set; }
        public short cat_order { get; set; }
        public decimal weight_factor { get; set; }
        public string cert_std { get; set; }
        public string cert_cat { get; set; }
        public virtual gb_cert_std gb_cert_std { get; set; }
        public virtual ICollection<gb_cert_credits> gb_cert_credits { get; set; }
        public virtual ICollection<gb_cert_scores> gb_cert_scores { get; set; }
    }
}
