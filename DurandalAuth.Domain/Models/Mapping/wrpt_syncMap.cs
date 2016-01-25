using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wrpt_syncMap : EntityTypeConfiguration<wrpt_sync>
    {
        public wrpt_syncMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(5000);

            this.Property(t => t.mob_locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.part_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("wrpt_sync", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.cost_actual).HasColumnName("cost_actual");
            this.Property(t => t.cost_estimated).HasColumnName("cost_estimated");
            this.Property(t => t.date_assigned).HasColumnName("date_assigned");
            this.Property(t => t.debited).HasColumnName("debited");
            this.Property(t => t.mob_is_changed).HasColumnName("mob_is_changed");
            this.Property(t => t.mob_locked_by).HasColumnName("mob_locked_by");
            this.Property(t => t.mob_wr_id).HasColumnName("mob_wr_id");
            this.Property(t => t.part_id).HasColumnName("part_id");
            this.Property(t => t.qty_actual).HasColumnName("qty_actual");
            this.Property(t => t.qty_estimated).HasColumnName("qty_estimated");
            this.Property(t => t.qty_picked).HasColumnName("qty_picked");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.time_assigned).HasColumnName("time_assigned");
            this.Property(t => t.wr_id).HasColumnName("wr_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
        }
    }
}
