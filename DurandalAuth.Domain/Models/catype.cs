using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class catype
    {
        public catype()
        {
            this.castds = new List<castd>();
            this.nets = new List<net>();
        }

        public string ca_type { get; set; }
        public virtual ICollection<castd> castds { get; set; }
        public virtual ICollection<net> nets { get; set; }
    }
}
