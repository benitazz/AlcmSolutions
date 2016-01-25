using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class recovery_team
    {
        public string em_id { get; set; }
        public string dv_id { get; set; }
        public string role { get; set; }
        public virtual dv dv { get; set; }
        public virtual Em em { get; set; }
    }
}
