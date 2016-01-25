using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gro
    {
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public decimal area { get; set; }
        public string layer_name { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string gros_type { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
    }
}
