using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_flds_trans
    {
        public string change_type { get; set; }
        public string chosen_action { get; set; }
        public string comments { get; set; }
        public string data_dict_diffs { get; set; }
        public short data_type { get; set; }
        public short decimals { get; set; }
        public string dep_cols { get; set; }
        public string dflt_val { get; set; }
        public string edit_group { get; set; }
        public string edit_mask { get; set; }
        public string enum_list { get; set; }
        public string field_grouping { get; set; }
        public string field_name { get; set; }
        public short is_atxt { get; set; }
        public short is_tc_traceable { get; set; }
        public string max_val { get; set; }
        public string min_val { get; set; }
        public string ml_heading { get; set; }
        public short num_format { get; set; }
        public short primary_key { get; set; }
        public string rec_action { get; set; }
        public string ref_table { get; set; }
        public string review_group { get; set; }
        public string sl_heading { get; set; }
        public string sql_table_diffs { get; set; }
        public short string_format { get; set; }
        public string table_name { get; set; }
        public string transfer_status { get; set; }
        public short validate_data { get; set; }
        public Nullable<short> afm_module { get; set; }
        public short afm_size { get; set; }
        public short afm_type { get; set; }
        public short allow_null { get; set; }
        public string attributes { get; set; }
        public int autonumbered_id { get; set; }
    }
}
