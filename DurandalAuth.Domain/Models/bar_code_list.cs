using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class bar_code_list
    {
        public string ta_id { get; set; }
        public virtual ta ta { get; set; }
    }
}
