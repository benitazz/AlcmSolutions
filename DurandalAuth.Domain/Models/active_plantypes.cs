using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class active_plantypes
    {
        public short active { get; set; }
        public string hs_ds { get; set; }
        public string hs_ds2 { get; set; }
        public Nullable<short> hs_hide { get; set; }
        public Nullable<short> hs_hide2 { get; set; }
        public string label_clr { get; set; }
        public string label_clr2 { get; set; }
        public string label_ds { get; set; }
        public string label_ds2 { get; set; }
        public Nullable<decimal> label_ht { get; set; }
        public Nullable<decimal> label_ht2 { get; set; }
        public string title { get; set; }
        public string title_ch { get; set; }
        public string title_de { get; set; }
        public string title_es { get; set; }
        public string title_fr { get; set; }
        public string title_it { get; set; }
        public string title_jp { get; set; }
        public string title_ko { get; set; }
        public string title_nl { get; set; }
        public string title_no { get; set; }
        public string title_zh { get; set; }
        public string view_file { get; set; }
        public string view_file2 { get; set; }
        public string plan_type { get; set; }
    }
}
