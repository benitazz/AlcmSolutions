using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pmpsttMap : EntityTypeConfiguration<pmpstt>
    {
        public pmpsttMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pmp_id, t.pmps_id, t.tool_type });

            // Properties
            this.Property(t => t.pmp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pmps_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tool_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pmpstt", "afm");
            this.Property(t => t.hours_req).HasColumnName("hours_req");
            this.Property(t => t.pmp_id).HasColumnName("pmp_id");
            this.Property(t => t.pmps_id).HasColumnName("pmps_id");
            this.Property(t => t.tool_type).HasColumnName("tool_type");

            // Relationships
            this.HasRequired(t => t.pmp)
                .WithMany(t => t.pmpstts)
                .HasForeignKey(d => d.pmp_id);
            this.HasRequired(t => t.pmp1)
                .WithMany(t => t.pmpstts)
                .HasForeignKey(d => new { d.pmp_id, d.pmps_id });
            this.HasRequired(t => t.tt)
                .WithMany(t => t.pmpstts)
                .HasForeignKey(d => d.tool_type);

        }
    }
}
