using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rmpctc
    {
        public int pct_id { get; set; }
        public string rm_id { get; set; }
        public string fl_id { get; set; }
        public string bl_id { get; set; }
        public string site_id { get; set; }
        public Nullable<decimal> flcomrm { get; set; }
        public Nullable<decimal> blcomrm { get; set; }
        public decimal stcomrm { get; set; }
        public Nullable<decimal> flcomsrv { get; set; }
        public Nullable<decimal> blcomsrv { get; set; }
        public decimal stcomsrv { get; set; }
    }
}
