using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_dwgsMap : EntityTypeConfiguration<afm_dwgs>
    {
        public afm_dwgsMap()
        {
            // Primary Key
            this.HasKey(t => t.dwg_name);

            // Properties
            this.Property(t => t.geo_srs)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.model_level)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.model_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.relative_path)
                .HasMaxLength(512);

            this.Property(t => t.space_hier_field_values)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.title)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.dwg_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.dwg_name)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("afm_dwgs", "afm");
            this.Property(t => t.geo_level).HasColumnName("geo_level");
            this.Property(t => t.geo_rotate).HasColumnName("geo_rotate");
            this.Property(t => t.geo_scale).HasColumnName("geo_scale");
            this.Property(t => t.geo_srs).HasColumnName("geo_srs");
            this.Property(t => t.geo_x).HasColumnName("geo_x");
            this.Property(t => t.geo_y).HasColumnName("geo_y");
            this.Property(t => t.locked_by).HasColumnName("locked_by");
            this.Property(t => t.model_level).HasColumnName("model_level");
            this.Property(t => t.model_name).HasColumnName("model_name");
            this.Property(t => t.relative_path).HasColumnName("relative_path");
            this.Property(t => t.report_height).HasColumnName("report_height");
            this.Property(t => t.report_height_tabloid).HasColumnName("report_height_tabloid");
            this.Property(t => t.report_scale).HasColumnName("report_scale");
            this.Property(t => t.report_title_position).HasColumnName("report_title_position");
            this.Property(t => t.report_width).HasColumnName("report_width");
            this.Property(t => t.report_width_tabloid).HasColumnName("report_width_tabloid");
            this.Property(t => t.space_hier_field_values).HasColumnName("space_hier_field_values");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.units).HasColumnName("units");
            this.Property(t => t.base_metric_units).HasColumnName("base_metric_units");
            this.Property(t => t.dwg_file).HasColumnName("dwg_file");
            this.Property(t => t.dwg_name).HasColumnName("dwg_name");
        }
    }
}
