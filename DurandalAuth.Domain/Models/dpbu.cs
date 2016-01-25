using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class dpbu
    {
        public decimal budget { get; set; }
        public string dv_id { get; set; }
        public string dp_id { get; set; }
        public short year { get; set; }
        public short month { get; set; }
        public short is_pm { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
    }
}
