using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class waste_profiles
    {
        public waste_profiles()
        {
            this.waste_out = new List<waste_out>();
            this.waste_regulated_codes = new List<waste_regulated_codes>();
        }

        public string cas_number { get; set; }
        public short is_recyclable { get; set; }
        public Nullable<int> msds_id { get; set; }
        public decimal specific_gravity { get; set; }
        public string status { get; set; }
        public string transp_classification { get; set; }
        public short transp_hazardous { get; set; }
        public string transp_shipping_name { get; set; }
        public string units_type { get; set; }
        public string waste_category { get; set; }
        public string waste_name { get; set; }
        public string waste_type { get; set; }
        public string waste_profile { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual waste_categories waste_categories { get; set; }
        public virtual ICollection<waste_out> waste_out { get; set; }
        public virtual ICollection<waste_regulated_codes> waste_regulated_codes { get; set; }
    }
}
