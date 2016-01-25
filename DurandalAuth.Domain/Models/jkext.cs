using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class jkext
    {
        public string fp_id { get; set; }
        public string jk_id { get; set; }
        public string phone { get; set; }
        public string extension { get; set; }
        public virtual fp fp { get; set; }
        public virtual jk jk { get; set; }
    }
}
