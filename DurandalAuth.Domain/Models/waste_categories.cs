using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class waste_categories
    {
        public waste_categories()
        {
            this.waste_profiles = new List<waste_profiles>();
        }

        public string description { get; set; }
        public string waste_category { get; set; }
        public virtual ICollection<waste_profiles> waste_profiles { get; set; }
    }
}
