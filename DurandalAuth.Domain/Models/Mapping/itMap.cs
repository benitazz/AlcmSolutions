using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class itMap : EntityTypeConfiguration<it>
    {
        public itMap()
        {
            // Primary Key
            this.HasKey(t => t.trans_id);

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.part_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.performed_by)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.trans_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("it", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.cost_total).HasColumnName("cost_total");
            this.Property(t => t.cost_when_used).HasColumnName("cost_when_used");
            this.Property(t => t.part_id).HasColumnName("part_id");
            this.Property(t => t.performed_by).HasColumnName("performed_by");
            this.Property(t => t.trans_date).HasColumnName("trans_date");
            this.Property(t => t.trans_quantity).HasColumnName("trans_quantity");
            this.Property(t => t.trans_time).HasColumnName("trans_time");
            this.Property(t => t.trans_type).HasColumnName("trans_type");
            this.Property(t => t.trans_id).HasColumnName("trans_id");

            // Relationships
            this.HasRequired(t => t.pt)
                .WithMany(t => t.it)
                .HasForeignKey(d => d.part_id);

        }
    }
}
