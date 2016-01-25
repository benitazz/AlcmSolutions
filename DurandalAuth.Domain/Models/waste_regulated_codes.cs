using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class waste_regulated_codes
    {
        public waste_regulated_codes()
        {
            this.waste_profiles = new List<waste_profiles>();
        }

        public string description { get; set; }
        public string regulated_code_type { get; set; }
        public string regulated_code { get; set; }
        public virtual ICollection<waste_profiles> waste_profiles { get; set; }
    }
}
