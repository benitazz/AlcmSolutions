using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class questionnaire_map
    {
        public string description { get; set; }
        public string questionnaire_id { get; set; }
        public string eq_std { get; set; }
        public string project_type { get; set; }
        public virtual eqstd eqstd { get; set; }
        public virtual projecttype projecttype { get; set; }
        public virtual questionnaire questionnaire { get; set; }
    }
}
