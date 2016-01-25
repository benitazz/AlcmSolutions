using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class regloc
    {
        public string comp_level { get; set; }
        public string comp_level_calc { get; set; }
        public short comp_level_number_calc { get; set; }
        public string description { get; set; }
        public int event_offset { get; set; }
        public string reg_program { get; set; }
        public string reg_requirement { get; set; }
        public string regulation { get; set; }
        public string resp_person { get; set; }
        public string vn_id { get; set; }
        public int location_id { get; set; }
        public virtual compliance_locations compliance_locations { get; set; }
        public virtual Em em { get; set; }
        public virtual regcomplevel regcomplevel { get; set; }
        public virtual regcomplevel regcomplevel1 { get; set; }
        public virtual regprogram regprogram { get; set; }
        public virtual regrequirement regrequirement { get; set; }
        public virtual regulation regulation1 { get; set; }
        public virtual vn vn { get; set; }
    }
}
