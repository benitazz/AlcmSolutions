using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_metric_definitionsMap : EntityTypeConfiguration<afm_metric_definitions>
    {
        public afm_metric_definitionsMap()
        {
            // Primary Key
            this.HasKey(t => t.metric_name);

            // Properties
            this.Property(t => t.metric_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.metric_status_test)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.metric_title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_01)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_02)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_03)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_04)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_05)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_ch)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_de)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_es)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_fr)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_it)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_jp)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_ko)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_nl)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_no)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_title_zh)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ratio_metric_denom)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ratio_metric_num)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.recurring_rule)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.report_aggregate_as)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.value_disp_decimals)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.value_disp_format)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.value_disp_format_m)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.value_disp_numeric)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.values_remove_method)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.assumptions)
                .HasMaxLength(500);

            this.Property(t => t.biz_implication)
                .HasMaxLength(1000);

            this.Property(t => t.collect_date_end_field)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.collect_date_field)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.collect_formula)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.collect_frequency)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.collect_group_by)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.collect_table)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.collect_where_clause)
                .HasMaxLength(2000);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.metric_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("afm_metric_definitions", "afm");
            this.Property(t => t.metric_status).HasColumnName("metric_status");
            this.Property(t => t.metric_status_test).HasColumnName("metric_status_test");
            this.Property(t => t.metric_title).HasColumnName("metric_title");
            this.Property(t => t.metric_title_01).HasColumnName("metric_title_01");
            this.Property(t => t.metric_title_02).HasColumnName("metric_title_02");
            this.Property(t => t.metric_title_03).HasColumnName("metric_title_03");
            this.Property(t => t.metric_title_04).HasColumnName("metric_title_04");
            this.Property(t => t.metric_title_05).HasColumnName("metric_title_05");
            this.Property(t => t.metric_title_ch).HasColumnName("metric_title_ch");
            this.Property(t => t.metric_title_de).HasColumnName("metric_title_de");
            this.Property(t => t.metric_title_es).HasColumnName("metric_title_es");
            this.Property(t => t.metric_title_fr).HasColumnName("metric_title_fr");
            this.Property(t => t.metric_title_it).HasColumnName("metric_title_it");
            this.Property(t => t.metric_title_jp).HasColumnName("metric_title_jp");
            this.Property(t => t.metric_title_ko).HasColumnName("metric_title_ko");
            this.Property(t => t.metric_title_nl).HasColumnName("metric_title_nl");
            this.Property(t => t.metric_title_no).HasColumnName("metric_title_no");
            this.Property(t => t.metric_title_zh).HasColumnName("metric_title_zh");
            this.Property(t => t.ratio_metric_denom).HasColumnName("ratio_metric_denom");
            this.Property(t => t.ratio_metric_num).HasColumnName("ratio_metric_num");
            this.Property(t => t.recurring_rule).HasColumnName("recurring_rule");
            this.Property(t => t.report_aggregate_as).HasColumnName("report_aggregate_as");
            this.Property(t => t.report_benchmark_value).HasColumnName("report_benchmark_value");
            this.Property(t => t.report_limit_high_crit).HasColumnName("report_limit_high_crit");
            this.Property(t => t.report_limit_high_warn).HasColumnName("report_limit_high_warn");
            this.Property(t => t.report_limit_low_crit).HasColumnName("report_limit_low_crit");
            this.Property(t => t.report_limit_low_warn).HasColumnName("report_limit_low_warn");
            this.Property(t => t.report_limit_target).HasColumnName("report_limit_target");
            this.Property(t => t.report_trend_dir).HasColumnName("report_trend_dir");
            this.Property(t => t.value_disp_decimals).HasColumnName("value_disp_decimals");
            this.Property(t => t.value_disp_format).HasColumnName("value_disp_format");
            this.Property(t => t.value_disp_format_m).HasColumnName("value_disp_format_m");
            this.Property(t => t.value_disp_numeric).HasColumnName("value_disp_numeric");
            this.Property(t => t.values_remove_method).HasColumnName("values_remove_method");
            this.Property(t => t.values_remove_older_than).HasColumnName("values_remove_older_than");
            this.Property(t => t.assumptions).HasColumnName("assumptions");
            this.Property(t => t.biz_implication).HasColumnName("biz_implication");
            this.Property(t => t.collect_date_end_field).HasColumnName("collect_date_end_field");
            this.Property(t => t.collect_date_field).HasColumnName("collect_date_field");
            this.Property(t => t.collect_formula).HasColumnName("collect_formula");
            this.Property(t => t.collect_frequency).HasColumnName("collect_frequency");
            this.Property(t => t.collect_group_by).HasColumnName("collect_group_by");
            this.Property(t => t.collect_table).HasColumnName("collect_table");
            this.Property(t => t.collect_where_clause).HasColumnName("collect_where_clause");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.metric_date).HasColumnName("metric_date");
            this.Property(t => t.metric_name).HasColumnName("metric_name");

            // Relationships
            this.HasOptional(t => t.afm_flds)
                .WithMany(t => t.afm_metric_definitions)
                .HasForeignKey(d => new { d.collect_table, d.collect_date_end_field });
            this.HasOptional(t => t.afm_flds1)
                .WithMany(t => t.afm_metric_definitions1)
                .HasForeignKey(d => new { d.collect_table, d.collect_date_field });
            this.HasOptional(t => t.afm_tbls)
                .WithMany(t => t.afm_metric_definitions)
                .HasForeignKey(d => d.collect_table);

        }
    }
}
