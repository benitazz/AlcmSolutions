using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_cert_std
    {
        public gb_cert_std()
        {
            this.gb_cert_cat = new List<gb_cert_cat>();
            this.gb_cert_credits = new List<gb_cert_credits>();
            this.gb_cert_docs = new List<gb_cert_docs>();
            this.gb_cert_levels = new List<gb_cert_levels>();
            this.gb_cert_log = new List<gb_cert_log>();
            this.gb_cert_proj = new List<gb_cert_proj>();
            this.gb_cert_scores = new List<gb_cert_scores>();
        }

        public string description { get; set; }
        public string scoring_type { get; set; }
        public string std_type { get; set; }
        public string cert_std { get; set; }
        public virtual ICollection<gb_cert_cat> gb_cert_cat { get; set; }
        public virtual ICollection<gb_cert_credits> gb_cert_credits { get; set; }
        public virtual ICollection<gb_cert_docs> gb_cert_docs { get; set; }
        public virtual ICollection<gb_cert_levels> gb_cert_levels { get; set; }
        public virtual ICollection<gb_cert_log> gb_cert_log { get; set; }
        public virtual ICollection<gb_cert_proj> gb_cert_proj { get; set; }
        public virtual ICollection<gb_cert_scores> gb_cert_scores { get; set; }
    }
}
