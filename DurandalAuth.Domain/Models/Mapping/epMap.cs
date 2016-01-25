using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class epMap : EntityTypeConfiguration<ep>
    {
        public epMap()
        {
            // Primary Key
            this.HasKey(t => new { t.eq_id, t.part_id });

            // Properties
            this.Property(t => t.eq_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.part_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("ep", "afm");
            this.Property(t => t.pt_life).HasColumnName("pt_life");
            this.Property(t => t.pt_use_yr).HasColumnName("pt_use_yr");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.part_id).HasColumnName("part_id");

            // Relationships
            this.HasRequired(t => t.eq)
                .WithMany(t => t.eps)
                .HasForeignKey(d => d.eq_id);
            this.HasRequired(t => t.pt)
                .WithMany(t => t.eps)
                .HasForeignKey(d => d.part_id);

        }
    }
}
