using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class hwrptMap : EntityTypeConfiguration<hwrpt>
    {
        public hwrptMap()
        {
            // Primary Key
            this.HasKey(t => new { t.wr_id, t.part_id, t.date_assigned, t.time_assigned });

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(5000);

            this.Property(t => t.status)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.wr_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.part_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("hwrpt", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.cost_actual).HasColumnName("cost_actual");
            this.Property(t => t.cost_estimated).HasColumnName("cost_estimated");
            this.Property(t => t.qty_actual).HasColumnName("qty_actual");
            this.Property(t => t.qty_estimated).HasColumnName("qty_estimated");
            this.Property(t => t.qty_picked).HasColumnName("qty_picked");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.debited).HasColumnName("debited");
            this.Property(t => t.wr_id).HasColumnName("wr_id");
            this.Property(t => t.part_id).HasColumnName("part_id");
            this.Property(t => t.date_assigned).HasColumnName("date_assigned");
            this.Property(t => t.time_assigned).HasColumnName("time_assigned");

            // Relationships
            this.HasRequired(t => t.hwr)
                .WithMany(t => t.hwrpts)
                .HasForeignKey(d => d.wr_id);

        }
    }
}
