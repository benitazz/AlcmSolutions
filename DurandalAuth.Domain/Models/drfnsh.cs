using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class drfnsh
    {
        public drfnsh()
        {
            this.drs = new List<dr>();
            this.drstds = new List<drstd>();
        }

        public string description { get; set; }
        public string dr_fnsh { get; set; }
        public virtual ICollection<dr> drs { get; set; }
        public virtual ICollection<drstd> drstds { get; set; }
    }
}
