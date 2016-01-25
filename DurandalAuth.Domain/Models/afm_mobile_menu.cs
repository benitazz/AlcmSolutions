using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_mobile_menu
    {
        public string activity_id { get; set; }
        public string description { get; set; }
        public string description_01 { get; set; }
        public string description_02 { get; set; }
        public string description_03 { get; set; }
        public string description_ch { get; set; }
        public string description_de { get; set; }
        public string description_es { get; set; }
        public string description_fr { get; set; }
        public string description_it { get; set; }
        public string description_jp { get; set; }
        public string description_ko { get; set; }
        public string description_nl { get; set; }
        public string description_no { get; set; }
        public string description_zh { get; set; }
        public Nullable<short> display_order { get; set; }
        public string group_name { get; set; }
        public string menu_icon { get; set; }
        public string mobile_action { get; set; }
        public string title { get; set; }
        public string title_01 { get; set; }
        public string title_02 { get; set; }
        public string title_03 { get; set; }
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
        public string menu_id { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual afm_mobile_apps afm_mobile_apps { get; set; }
    }
}
