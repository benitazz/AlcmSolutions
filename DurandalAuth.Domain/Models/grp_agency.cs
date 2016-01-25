using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class grp_agency
    {
        public grp_agency()
        {
            this.grps = new List<grp>();
            this.grps1 = new List<grp>();
            this.grp_trans = new List<grp_trans>();
            this.grp_trans1 = new List<grp_trans>();
        }

        public string abbreviation_title { get; set; }
        public string title { get; set; }
        public string grp_agency_id { get; set; }
        public virtual ICollection<grp> grps { get; set; }
        public virtual ICollection<grp> grps1 { get; set; }
        public virtual ICollection<grp_trans> grp_trans { get; set; }
        public virtual ICollection<grp_trans> grp_trans1 { get; set; }
    }
}
