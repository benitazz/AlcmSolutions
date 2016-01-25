using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pmpsum
    {
        public decimal hours { get; set; }
        public System.DateTime date_todo { get; set; }
        public string eq_id { get; set; }
        public string pmp_id { get; set; }
        public string tr_id { get; set; }
    }
}
