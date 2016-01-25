using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_scmpref
    {
        public short afm_scmpref1 { get; set; }
        public short afm_db_version_num { get; set; }
        public short afm_exe_release_num { get; set; }
        public double afm_exe_version_num { get; set; }
        public short autocommit_all { get; set; }
        public string autocommit_tables { get; set; }
        public string cable_std_table { get; set; }
        public string connectable_table_names { get; set; }
        public short fiscalyear_startday { get; set; }
        public short fiscalyear_startmonth { get; set; }
        public string inferrable_field_names { get; set; }
        public short lay_series_pfx_len { get; set; }
        public string lease_area_type { get; set; }
        public string lease_proration_method { get; set; }
        public string linetype_file { get; set; }
        public short num_space_fcast_per { get; set; }
        public string space_area_type { get; set; }
        public string space_hier_field_names { get; set; }
        public short sym_lib_base_metric_units { get; set; }
        public short sym_lib_units { get; set; }
        public short afm_cascades_changes { get; set; }
        public short base_metric_units { get; set; }
        public short cluster_num_servers { get; set; }
        public Nullable<System.DateTime> date_lang_01 { get; set; }
        public Nullable<System.DateTime> date_lang_02 { get; set; }
        public Nullable<System.DateTime> date_lang_03 { get; set; }
        public Nullable<System.DateTime> date_lang_ch { get; set; }
        public Nullable<System.DateTime> date_lang_de { get; set; }
        public Nullable<System.DateTime> date_lang_en { get; set; }
        public Nullable<System.DateTime> date_lang_es { get; set; }
        public Nullable<System.DateTime> date_lang_fr { get; set; }
        public Nullable<System.DateTime> date_lang_it { get; set; }
        public Nullable<System.DateTime> date_lang_jp { get; set; }
        public Nullable<System.DateTime> date_lang_ko { get; set; }
        public Nullable<System.DateTime> date_lang_nl { get; set; }
        public Nullable<System.DateTime> date_lang_no { get; set; }
        public Nullable<System.DateTime> date_lang_zh { get; set; }
        public string doc_cluster_internal_use { get; set; }
        public string hierarchy_delim { get; set; }
        public string preferences { get; set; }
        public string transfer_status { get; set; }
        public short units { get; set; }
        public short use_hier_security { get; set; }
    }
}
