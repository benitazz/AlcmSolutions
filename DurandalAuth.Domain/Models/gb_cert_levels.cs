using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_cert_levels
    {
        public gb_cert_levels()
        {
            this.gb_cert_proj = new List<gb_cert_proj>();
            this.gb_cert_proj1 = new List<gb_cert_proj>();
        }

        public short max_score { get; set; }
        public short min_score { get; set; }
        public string cert_std { get; set; }
        public string cert_level { get; set; }
        public virtual gb_cert_std gb_cert_std { get; set; }
        public virtual ICollection<gb_cert_proj> gb_cert_proj { get; set; }
        public virtual ICollection<gb_cert_proj> gb_cert_proj1 { get; set; }
    }
}
