using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gpc
    {
        public int gp_id { get; set; }
        public string fl_id { get; set; }
        public string bl_id { get; set; }
        public string site_id { get; set; }
        public Nullable<decimal> flcomgp { get; set; }
        public Nullable<decimal> blcomgp { get; set; }
        public decimal stcomgp { get; set; }
        public Nullable<decimal> flcomsrv { get; set; }
        public Nullable<decimal> blcomsrv { get; set; }
        public decimal stcomsrv { get; set; }
    }
}
