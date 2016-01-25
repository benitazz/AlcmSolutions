using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_activity_params
    {
        public string applies_to { get; set; }
        public string description { get; set; }
        public string param_value { get; set; }
        public string transfer_status { get; set; }
        public string activity_id { get; set; }
        public string param_id { get; set; }
        public virtual afm_activities afm_activities { get; set; }
    }
}
