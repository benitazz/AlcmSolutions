using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class msds_h_chemical
    {
        public string alias { get; set; }
        public string cas_number { get; set; }
        public string ec_number { get; set; }
        public string icsc_number { get; set; }
        public string rtecs_number { get; set; }
        public string tier2 { get; set; }
        public string un_number { get; set; }
        public string chemical_id { get; set; }
        public System.DateTime date_archived { get; set; }
        public System.DateTime time_archived { get; set; }
    }
}
