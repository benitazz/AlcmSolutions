using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class parking
    {
        public string bl_id { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string em_id { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public Nullable<decimal> lat { get; set; }
        public Nullable<decimal> lon { get; set; }
        public string ls_id { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string parking_std { get; set; }
        public string pr_id { get; set; }
        public string parking_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Em em { get; set; }
        public virtual l l { get; set; }
        public virtual parkingstd parkingstd { get; set; }
        public virtual Property property { get; set; }
    }
}
