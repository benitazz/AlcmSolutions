using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class grp_use
    {
        public grp_use()
        {
            this.grps = new List<grp>();
            this.grp_trans = new List<grp_trans>();
        }

        public string grp_use_description { get; set; }
        public short grp_type_id { get; set; }
        public short grp_use_id { get; set; }
        public virtual ICollection<grp> grps { get; set; }
        public virtual ICollection<grp_trans> grp_trans { get; set; }
        public virtual grp_type grp_type { get; set; }
    }
}
