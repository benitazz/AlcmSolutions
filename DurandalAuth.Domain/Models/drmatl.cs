using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class drmatl
    {
        public drmatl()
        {
            this.drs = new List<dr>();
            this.drstds = new List<drstd>();
        }

        public string description { get; set; }
        public string dr_matl { get; set; }
        public virtual ICollection<dr> drs { get; set; }
        public virtual ICollection<drstd> drstds { get; set; }
    }
}
