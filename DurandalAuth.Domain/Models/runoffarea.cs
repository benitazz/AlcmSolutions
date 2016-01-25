using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class runoffarea
    {
        public string comments { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string pr_id { get; set; }
        public string runoff_type { get; set; }
        public decimal area_cad { get; set; }
        public int auto_number { get; set; }
        public virtual Property property { get; set; }
        public virtual runofftype runofftype { get; set; }
    }
}
