using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ta_depMap : EntityTypeConfiguration<ta_dep>
    {
        public ta_depMap()
        {
            // Primary Key
            this.HasKey(t => new { t.report_id, t.ta_id });

            // Properties
            this.Property(t => t.report_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.ta_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("ta_dep", "afm");
            this.Property(t => t.value_accum_dep).HasColumnName("value_accum_dep");
            this.Property(t => t.value_current).HasColumnName("value_current");
            this.Property(t => t.value_current_dep).HasColumnName("value_current_dep");
            this.Property(t => t.report_id).HasColumnName("report_id");
            this.Property(t => t.ta_id).HasColumnName("ta_id");

            // Relationships
            this.HasRequired(t => t.dep_reports)
                .WithMany(t => t.ta_dep)
                .HasForeignKey(d => d.report_id);
            this.HasRequired(t => t.ta)
                .WithMany(t => t.ta_dep)
                .HasForeignKey(d => d.ta_id);

        }
    }
}
