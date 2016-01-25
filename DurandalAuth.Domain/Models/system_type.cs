using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class system_type
    {
        public system_type()
        {
            this.system_bl = new List<system_bl>();
        }

        public string system_cat { get; set; }
        public string system_type1 { get; set; }
        public virtual ICollection<system_bl> system_bl { get; set; }
    }
}
