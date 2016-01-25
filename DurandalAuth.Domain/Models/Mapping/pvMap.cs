using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pvMap : EntityTypeConfiguration<pv>
    {
        public pvMap()
        {
            // Primary Key
            this.HasKey(t => new { t.part_id, t.vn_id });

            // Properties
            this.Property(t => t.vn_pt_num)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.part_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.vn_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pv", "afm");
            this.Property(t => t.lead_time).HasColumnName("lead_time");
            this.Property(t => t.rank).HasColumnName("rank");
            this.Property(t => t.vn_pt_num).HasColumnName("vn_pt_num");
            this.Property(t => t.part_id).HasColumnName("part_id");
            this.Property(t => t.vn_id).HasColumnName("vn_id");

            // Relationships
            this.HasRequired(t => t.pt)
                .WithMany(t => t.pvs)
                .HasForeignKey(d => d.part_id);
            this.HasRequired(t => t.vn)
                .WithMany(t => t.pvs)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
