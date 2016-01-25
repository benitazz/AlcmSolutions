using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class acbu
    {
        public decimal budget { get; set; }
        public string ac_id { get; set; }
        public short year { get; set; }
        public short month { get; set; }
        public short is_pm { get; set; }
        public virtual ac ac { get; set; }
    }
}
