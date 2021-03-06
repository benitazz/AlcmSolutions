using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pmpsptMap : EntityTypeConfiguration<pmpspt>
    {
        public pmpsptMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pmp_id, t.pmps_id, t.part_id });

            // Properties
            this.Property(t => t.pmp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pmps_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.part_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pmpspt", "afm");
            this.Property(t => t.qty_required).HasColumnName("qty_required");
            this.Property(t => t.pmp_id).HasColumnName("pmp_id");
            this.Property(t => t.pmps_id).HasColumnName("pmps_id");
            this.Property(t => t.part_id).HasColumnName("part_id");

            // Relationships
            this.HasRequired(t => t.pmp)
                .WithMany(t => t.pmpspts)
                .HasForeignKey(d => d.pmp_id);
            this.HasRequired(t => t.pmp1)
                .WithMany(t => t.pmpspts)
                .HasForeignKey(d => new { d.pmp_id, d.pmps_id });
            this.HasRequired(t => t.pt)
                .WithMany(t => t.pmpspts)
                .HasForeignKey(d => d.part_id);

        }
    }
}
