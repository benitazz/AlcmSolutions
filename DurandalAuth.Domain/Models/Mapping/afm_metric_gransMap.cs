using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_metric_gransMap : EntityTypeConfiguration<afm_metric_grans>
    {
        public afm_metric_gransMap()
        {
            // Primary Key
            this.HasKey(t => new { t.metric_name, t.collect_group_by });

            // Properties
            this.Property(t => t.dflt_view)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.tables_required)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.metric_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.collect_group_by)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_metric_grans", "afm");
            this.Property(t => t.dflt_view).HasColumnName("dflt_view");
            this.Property(t => t.tables_required).HasColumnName("tables_required");
            this.Property(t => t.metric_name).HasColumnName("metric_name");
            this.Property(t => t.collect_group_by).HasColumnName("collect_group_by");

            // Relationships
            this.HasRequired(t => t.afm_metric_definitions)
                .WithMany(t => t.afm_metric_grans)
                .HasForeignKey(d => d.metric_name);
            this.HasRequired(t => t.afm_metric_gran_defs)
                .WithMany(t => t.afm_metric_grans)
                .HasForeignKey(d => d.collect_group_by);

        }
    }
}
