using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class commtype
    {
        public commtype()
        {
            this.commsubs = new List<commsub>();
            this.ls_comm = new List<ls_comm>();
        }

        public string comm_type { get; set; }
        public virtual ICollection<commsub> commsubs { get; set; }
        public virtual ICollection<ls_comm> ls_comm { get; set; }
    }
}
