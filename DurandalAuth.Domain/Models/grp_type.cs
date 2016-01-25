using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class grp_type
    {
        public grp_type()
        {
            this.grps = new List<grp>();
            this.grp_trans = new List<grp_trans>();
            this.grp_use = new List<grp_use>();
        }

        public string grp_type_description { get; set; }
        public short grp_type_id { get; set; }
        public virtual ICollection<grp> grps { get; set; }
        public virtual ICollection<grp_trans> grp_trans { get; set; }
        public virtual ICollection<grp_use> grp_use { get; set; }
    }
}
