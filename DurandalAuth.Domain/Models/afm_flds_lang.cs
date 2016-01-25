using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_flds_lang
    {
        public string enum_list_01 { get; set; }
        public string enum_list_02 { get; set; }
        public string enum_list_03 { get; set; }
        public string enum_list_ch { get; set; }
        public string enum_list_de { get; set; }
        public string enum_list_es { get; set; }
        public string enum_list_fr { get; set; }
        public string enum_list_it { get; set; }
        public string enum_list_jp { get; set; }
        public string enum_list_ko { get; set; }
        public string enum_list_nl { get; set; }
        public string enum_list_no { get; set; }
        public string enum_list_zh { get; set; }
        public string ml_heading_01 { get; set; }
        public string ml_heading_02 { get; set; }
        public string ml_heading_03 { get; set; }
        public string ml_heading_ch { get; set; }
        public string ml_heading_de { get; set; }
        public string ml_heading_es { get; set; }
        public string ml_heading_fr { get; set; }
        public string ml_heading_it { get; set; }
        public string ml_heading_jp { get; set; }
        public string ml_heading_ko { get; set; }
        public string ml_heading_nl { get; set; }
        public string ml_heading_no { get; set; }
        public string ml_heading_zh { get; set; }
        public string table_name { get; set; }
        public string field_name { get; set; }
        public string sl_heading_01 { get; set; }
        public string sl_heading_02 { get; set; }
        public string sl_heading_03 { get; set; }
        public string sl_heading_ch { get; set; }
        public string sl_heading_de { get; set; }
        public string sl_heading_es { get; set; }
        public string sl_heading_fr { get; set; }
        public string sl_heading_it { get; set; }
        public string sl_heading_jp { get; set; }
        public string sl_heading_ko { get; set; }
        public string sl_heading_nl { get; set; }
        public string sl_heading_no { get; set; }
        public string sl_heading_zh { get; set; }
        public string transfer_status { get; set; }
        public virtual afm_flds afm_flds { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
    }
}
