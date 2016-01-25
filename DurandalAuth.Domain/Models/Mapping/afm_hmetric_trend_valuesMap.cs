using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_hmetric_trend_valuesMap : EntityTypeConfiguration<afm_hmetric_trend_values>
    {
        public afm_hmetric_trend_valuesMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.collect_by_value)
                .IsFixedLength()
                .HasMaxLength(256);

            this.Property(t => t.collect_err_msg)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.collect_group_by)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.metric_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.metric_value_prev)
                .IsFixedLength()
                .HasMaxLength(1000);

            this.Property(t => t.auto_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("afm_hmetric_trend_values", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.collect_by_value).HasColumnName("collect_by_value");
            this.Property(t => t.collect_err_msg).HasColumnName("collect_err_msg");
            this.Property(t => t.collect_group_by).HasColumnName("collect_group_by");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.metric_date).HasColumnName("metric_date");
            this.Property(t => t.metric_name).HasColumnName("metric_name");
            this.Property(t => t.metric_value).HasColumnName("metric_value");
            this.Property(t => t.metric_value_last).HasColumnName("metric_value_last");
            this.Property(t => t.metric_value_last_yr).HasColumnName("metric_value_last_yr");
            this.Property(t => t.metric_value_prev).HasColumnName("metric_value_prev");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
        }
    }
}
