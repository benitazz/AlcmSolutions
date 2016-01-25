using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class blbu
    {
        public decimal budget { get; set; }
        public string bl_id { get; set; }
        public short year { get; set; }
        public short month { get; set; }
        public short is_pm { get; set; }
        public virtual bl bl { get; set; }
    }
}
