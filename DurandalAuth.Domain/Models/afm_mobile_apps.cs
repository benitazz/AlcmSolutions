using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_mobile_apps
    {
        public afm_mobile_apps()
        {
            this.afm_mobile_menu = new List<afm_mobile_menu>();
        }

        public Nullable<short> display_order { get; set; }
        public string icon_large { get; set; }
        public string main_page_url { get; set; }
        public string security_group { get; set; }
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
        public string transfer_status { get; set; }
        public string activity_id { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual ICollection<afm_mobile_menu> afm_mobile_menu { get; set; }
    }
}
