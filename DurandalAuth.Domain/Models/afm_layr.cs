using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_layr
    {
        public string linetype { get; set; }
        public string redef_name { get; set; }
        public string table_name { get; set; }
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
        public short color { get; set; }
        public string layer_name { get; set; }
        public virtual afm_atyp afm_atyp { get; set; }
    }
}
