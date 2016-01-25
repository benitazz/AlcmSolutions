using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pa_depMap : EntityTypeConfiguration<pa_dep>
    {
        public pa_depMap()
        {
            // Primary Key
            this.HasKey(t => new { t.report_id, t.pr_id, t.pa_name });

            // Properties
            this.Property(t => t.report_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.pr_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pa_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("pa_dep", "afm");
            this.Property(t => t.value_accum_dep).HasColumnName("value_accum_dep");
            this.Property(t => t.value_current).HasColumnName("value_current");
            this.Property(t => t.value_current_dep).HasColumnName("value_current_dep");
            this.Property(t => t.report_id).HasColumnName("report_id");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.pa_name).HasColumnName("pa_name");

            // Relationships
            this.HasRequired(t => t.dep_reports)
                .WithMany(t => t.pa_dep)
                .HasForeignKey(d => d.report_id);
            this.HasRequired(t => t.pa)
                .WithMany(t => t.pa_dep)
                .HasForeignKey(d => new { d.pr_id, d.pa_name });
            this.HasRequired(t => t.property)
                .WithMany(t => t.pa_dep)
                .HasForeignKey(d => d.pr_id);

        }
    }
}
