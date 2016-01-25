using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_metric_scardsMap : EntityTypeConfiguration<afm_metric_scards>
    {
        public afm_metric_scardsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.metric_name, t.scorecard_code });

            // Properties
            this.Property(t => t.value_disp_decimals_ovr)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.metric_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.scorecard_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_metric_scards", "afm");
            this.Property(t => t.is_displayed).HasColumnName("is_displayed");
            this.Property(t => t.value_disp_decimals_ovr).HasColumnName("value_disp_decimals_ovr");
            this.Property(t => t.metric_name).HasColumnName("metric_name");
            this.Property(t => t.scorecard_code).HasColumnName("scorecard_code");

            // Relationships
            this.HasRequired(t => t.afm_metric_definitions)
                .WithMany(t => t.afm_metric_scards)
                .HasForeignKey(d => d.metric_name);
            this.HasRequired(t => t.afm_metric_scard_defs)
                .WithMany(t => t.afm_metric_scards)
                .HasForeignKey(d => d.scorecard_code);

        }
    }
}
