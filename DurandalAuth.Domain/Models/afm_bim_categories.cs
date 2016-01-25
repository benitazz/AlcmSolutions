using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_bim_categories
    {
        public afm_bim_categories()
        {
            this.afm_bim_families = new List<afm_bim_families>();
        }

        public string description { get; set; }
        public Nullable<int> revit_id { get; set; }
        public string category_id { get; set; }
        public virtual ICollection<afm_bim_families> afm_bim_families { get; set; }
    }
}
