using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class waste_mgmt_methods_groups
    {
        public waste_mgmt_methods_groups()
        {
            this.waste_mgmt_methods = new List<waste_mgmt_methods>();
        }

        public string description { get; set; }
        public string method_group { get; set; }
        public virtual ICollection<waste_mgmt_methods> waste_mgmt_methods { get; set; }
    }
}
