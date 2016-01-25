using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class eq_bar_code_list
    {
        public string eq_id { get; set; }
        public virtual eq eq { get; set; }
    }
}
