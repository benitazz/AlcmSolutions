using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class runofftype
    {
        public runofftype()
        {
            this.runoffareas = new List<runoffarea>();
        }

        public string description { get; set; }
        public string hpattern { get; set; }
        public string hpattern_acad { get; set; }
        public string material { get; set; }
        public string permiability { get; set; }
        public string runoff_class { get; set; }
        public string runoff_type { get; set; }
        public virtual ICollection<runoffarea> runoffareas { get; set; }
    }
}
