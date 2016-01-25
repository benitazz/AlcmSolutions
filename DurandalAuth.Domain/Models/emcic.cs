using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class emcic
    {
        public string rm_id { get; set; }
        public string fl_id { get; set; }
        public string bl_id { get; set; }
        public string site_id { get; set; }
        public Nullable<decimal> flcomrm { get; set; }
        public Nullable<decimal> blcomrm { get; set; }
        public Nullable<decimal> stcomrm { get; set; }
        public Nullable<decimal> flcomsrv { get; set; }
        public Nullable<decimal> blcomsrv { get; set; }
        public Nullable<decimal> stcomsrv { get; set; }
    }
}
