using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_metric_definitions
    {
        public afm_metric_definitions()
        {
            this.afm_metric_grans = new List<afm_metric_grans>();
            this.afm_metric_scards = new List<afm_metric_scards>();
            this.afm_metric_trend_values = new List<afm_metric_trend_values>();
        }

        public string metric_status { get; set; }
        public string metric_status_test { get; set; }
        public string metric_title { get; set; }
        public string metric_title_01 { get; set; }
        public string metric_title_02 { get; set; }
        public string metric_title_03 { get; set; }
        public string metric_title_04 { get; set; }
        public string metric_title_05 { get; set; }
        public string metric_title_ch { get; set; }
        public string metric_title_de { get; set; }
        public string metric_title_es { get; set; }
        public string metric_title_fr { get; set; }
        public string metric_title_it { get; set; }
        public string metric_title_jp { get; set; }
        public string metric_title_ko { get; set; }
        public string metric_title_nl { get; set; }
        public string metric_title_no { get; set; }
        public string metric_title_zh { get; set; }
        public string ratio_metric_denom { get; set; }
        public string ratio_metric_num { get; set; }
        public string recurring_rule { get; set; }
        public string report_aggregate_as { get; set; }
        public decimal report_benchmark_value { get; set; }
        public Nullable<decimal> report_limit_high_crit { get; set; }
        public Nullable<decimal> report_limit_high_warn { get; set; }
        public Nullable<decimal> report_limit_low_crit { get; set; }
        public Nullable<decimal> report_limit_low_warn { get; set; }
        public Nullable<decimal> report_limit_target { get; set; }
        public short report_trend_dir { get; set; }
        public string value_disp_decimals { get; set; }
        public string value_disp_format { get; set; }
        public string value_disp_format_m { get; set; }
        public string value_disp_numeric { get; set; }
        public string values_remove_method { get; set; }
        public int values_remove_older_than { get; set; }
        public string assumptions { get; set; }
        public string biz_implication { get; set; }
        public string collect_date_end_field { get; set; }
        public string collect_date_field { get; set; }
        public string collect_formula { get; set; }
        public string collect_frequency { get; set; }
        public string collect_group_by { get; set; }
        public string collect_table { get; set; }
        public string collect_where_clause { get; set; }
        public string description { get; set; }
        public System.DateTime metric_date { get; set; }
        public string metric_name { get; set; }
        public virtual afm_flds afm_flds { get; set; }
        public virtual afm_flds afm_flds1 { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
        public virtual ICollection<afm_metric_grans> afm_metric_grans { get; set; }
        public virtual ICollection<afm_metric_scards> afm_metric_scards { get; set; }
        public virtual ICollection<afm_metric_trend_values> afm_metric_trend_values { get; set; }
    }
}
