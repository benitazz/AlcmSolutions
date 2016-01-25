using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class eq_schedMap : EntityTypeConfiguration<eq_sched>
    {
        public eq_schedMap()
        {
            // Primary Key
            this.HasKey(t => new { t.eq_id, t.date_scheduled, t.schedule_type });

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(250);

            this.Property(t => t.eq_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.schedule_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("eq_sched", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.hours_commited).HasColumnName("hours_commited");
            this.Property(t => t.time_start).HasColumnName("time_start");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.date_scheduled).HasColumnName("date_scheduled");
            this.Property(t => t.schedule_type).HasColumnName("schedule_type");

            // Relationships
            this.HasRequired(t => t.eq)
                .WithMany(t => t.eq_sched)
                .HasForeignKey(d => d.eq_id);

        }
    }
}
