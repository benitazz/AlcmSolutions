using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_bim_families
    {
        public string category_id { get; set; }
        public string family { get; set; }
        public string language { get; set; }
        public string parameter_group { get; set; }
        public string phase_name_contains { get; set; }
        public string super_category { get; set; }
        public string table_name { get; set; }
        public string type { get; set; }
        public string view_name_contains { get; set; }
        public int auto_number { get; set; }
        public virtual afm_bim_categories afm_bim_categories { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
    }
}
