using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_bim_params
    {
        public string field_name { get; set; }
        public string guid { get; set; }
        public short is_active { get; set; }
        public string language { get; set; }
        public Nullable<int> parameter_id { get; set; }
        public string parameter_name { get; set; }
        public string parameter_name_01 { get; set; }
        public string parameter_name_02 { get; set; }
        public string parameter_name_03 { get; set; }
        public string parameter_name_ch { get; set; }
        public string parameter_name_de { get; set; }
        public string parameter_name_es { get; set; }
        public string parameter_name_fr { get; set; }
        public string parameter_name_it { get; set; }
        public string parameter_name_jp { get; set; }
        public string parameter_name_ko { get; set; }
        public string parameter_name_nl { get; set; }
        public string parameter_name_no { get; set; }
        public string parameter_name_zh { get; set; }
        public int parameter_type { get; set; }
        public short record_source { get; set; }
        public short required_by_ai { get; set; }
        public string table_name { get; set; }
        public int auto_number { get; set; }
        public virtual afm_flds afm_flds { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
    }
}
