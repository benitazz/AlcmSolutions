using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class waste_mgmt_methods
    {
        public waste_mgmt_methods()
        {
            this.waste_out = new List<waste_out>();
        }

        public string method_group { get; set; }
        public string method_name { get; set; }
        public string method_code { get; set; }
        public virtual waste_mgmt_methods_groups waste_mgmt_methods_groups { get; set; }
        public virtual ICollection<waste_out> waste_out { get; set; }
    }
}
