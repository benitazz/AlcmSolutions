using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class mpMap : EntityTypeConfiguration<mp>
    {
        public mpMap()
        {
            // Primary Key
            this.HasKey(t => t.mp_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.mp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("mp", "afm");
            this.Property(t => t.cost_comp_eq).HasColumnName("cost_comp_eq");
            this.Property(t => t.cost_comp_fn).HasColumnName("cost_comp_fn");
            this.Property(t => t.cost_comp_other).HasColumnName("cost_comp_other");
            this.Property(t => t.cost_comp_ta).HasColumnName("cost_comp_ta");
            this.Property(t => t.cost_comp_total).HasColumnName("cost_comp_total");
            this.Property(t => t.cost_moving_eq).HasColumnName("cost_moving_eq");
            this.Property(t => t.cost_moving_fn).HasColumnName("cost_moving_fn");
            this.Property(t => t.cost_moving_other).HasColumnName("cost_moving_other");
            this.Property(t => t.cost_moving_ta).HasColumnName("cost_moving_ta");
            this.Property(t => t.cost_moving_total).HasColumnName("cost_moving_total");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.mp_id).HasColumnName("mp_id");

            // Relationships
            this.HasOptional(t => t.em)
                .WithMany(t => t.mps)
                .HasForeignKey(d => d.em_id);

        }
    }
}
