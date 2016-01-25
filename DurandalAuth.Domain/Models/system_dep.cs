using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class system_dep
    {
        public short propagate_status { get; set; }
        public string system_id_depend { get; set; }
        public string system_id_master { get; set; }
        public int auto_number { get; set; }
        public virtual system_bl system_bl { get; set; }
        public virtual system_bl system_bl1 { get; set; }
    }
}
