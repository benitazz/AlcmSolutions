using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rmstd_fn
    {
        public int fnstd_count { get; set; }
        public string rm_std { get; set; }
        public string fn_std { get; set; }
        public virtual fnstd fnstd { get; set; }
        public virtual rmstd rmstd { get; set; }
    }
}
