using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class other_rs
    {
        public other_rs()
        {
            this.wr_other = new List<wr_other>();
        }

        public string description { get; set; }
        public string other_rs_type { get; set; }
        public virtual ICollection<wr_other> wr_other { get; set; }
    }
}
