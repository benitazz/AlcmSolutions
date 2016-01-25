using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wrtr_syncMap : EntityTypeConfiguration<wrtr_sync>
    {
        public wrtr_syncMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.mob_locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.tr_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("wrtr_sync", "afm");
            this.Property(t => t.cost_estimated).HasColumnName("cost_estimated");
            this.Property(t => t.date_assigned).HasColumnName("date_assigned");
            this.Property(t => t.hours_est).HasColumnName("hours_est");
            this.Property(t => t.mob_is_changed).HasColumnName("mob_is_changed");
            this.Property(t => t.mob_locked_by).HasColumnName("mob_locked_by");
            this.Property(t => t.mob_wr_id).HasColumnName("mob_wr_id");
            this.Property(t => t.time_assigned).HasColumnName("time_assigned");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.wr_id).HasColumnName("wr_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
        }
    }
}
