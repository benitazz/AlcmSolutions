using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_cert_log
    {
        public string cert_std { get; set; }
        public string description { get; set; }
        public System.DateTime log_date { get; set; }
        public string project_name { get; set; }
        public string subject { get; set; }
        public string submitted_by { get; set; }
        public string bl_id { get; set; }
        public int cert_log_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Em em { get; set; }
        public virtual gb_cert_std gb_cert_std { get; set; }
        public virtual gb_cert_proj gb_cert_proj { get; set; }
    }
}
