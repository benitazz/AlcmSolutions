using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_products
    {
        public afm_products()
        {
            this.afm_actprods = new List<afm_actprods>();
        }

        public Nullable<short> revision { get; set; }
        public string summary { get; set; }
        public string summary_01 { get; set; }
        public string summary_02 { get; set; }
        public string summary_03 { get; set; }
        public string summary_ch { get; set; }
        public string summary_de { get; set; }
        public string summary_es { get; set; }
        public string summary_fr { get; set; }
        public string summary_it { get; set; }
        public string summary_jp { get; set; }
        public string summary_ko { get; set; }
        public string summary_nl { get; set; }
        public string summary_no { get; set; }
        public string summary_zh { get; set; }
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
        public short version { get; set; }
        public string comments { get; set; }
        public Nullable<short> display_order { get; set; }
        public string help_link { get; set; }
        public string icon_large { get; set; }
        public string icon_small { get; set; }
        public Nullable<short> is_active { get; set; }
        public string product_id { get; set; }
        public virtual ICollection<afm_actprods> afm_actprods { get; set; }
    }
}
