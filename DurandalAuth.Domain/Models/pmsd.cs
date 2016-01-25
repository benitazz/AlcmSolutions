using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pmsd
    {
        public int pms_id { get; set; }
        public System.DateTime date_todo { get; set; }
        public virtual Pm pm { get; set; }
    }
}
