using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_dwgvers
    {
        public string comments { get; set; }
        public System.DateTime date_occurred { get; set; }
        public string dwg_name { get; set; }
        public string performed_by { get; set; }
        public System.DateTime time_occurred { get; set; }
        public string action { get; set; }
        public int auto_number { get; set; }
        public virtual afm_dwgs afm_dwgs { get; set; }
    }
}
