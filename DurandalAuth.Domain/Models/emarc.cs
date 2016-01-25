using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class emarc
    {
        public string rm_id { get; set; }
        public string fl_id { get; set; }
        public string bl_id { get; set; }
        public string site_id { get; set; }
        public Nullable<decimal> flcomocup { get; set; }
        public Nullable<decimal> blcomocup { get; set; }
        public Nullable<decimal> stcomocup { get; set; }
        public Nullable<decimal> flcomnocup { get; set; }
        public Nullable<decimal> blcomnocup { get; set; }
        public Nullable<decimal> stcomnocup { get; set; }
    }
}
