using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cb_accredit_type
    {
        public cb_accredit_type()
        {
            this.cb_accredit_person = new List<cb_accredit_person>();
        }

        public string description { get; set; }
        public string name { get; set; }
        public string prob_type { get; set; }
        public string accredit_type_id { get; set; }
        public virtual ICollection<cb_accredit_person> cb_accredit_person { get; set; }
        public virtual probtype probtype { get; set; }
    }
}
