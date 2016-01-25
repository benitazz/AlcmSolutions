using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_tbl_map
    {
        public string old_field { get; set; }
        public string old_table { get; set; }
        public string transfer_status { get; set; }
        public string new_table { get; set; }
        public string new_field { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
    }
}
