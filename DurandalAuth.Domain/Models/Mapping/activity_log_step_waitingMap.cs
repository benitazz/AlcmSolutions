using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class activity_log_step_waitingMap : EntityTypeConfiguration<activity_log_step_waiting>
    {
        public activity_log_step_waitingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.activity_log_id, t.date_created, t.time_created, t.status, t.step, t.step_type, t.step_log_id, t.activity_id });

            // Properties
            this.Property(t => t.activity_log_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cf_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.user_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.step)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.step_code)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.step_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.step_log_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("activity_log_step_waiting", "afm");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.cf_id).HasColumnName("cf_id");
            this.Property(t => t.user_name).HasColumnName("user_name");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.time_created).HasColumnName("time_created");
            this.Property(t => t.date_response).HasColumnName("date_response");
            this.Property(t => t.time_response).HasColumnName("time_response");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.step).HasColumnName("step");
            this.Property(t => t.step_code).HasColumnName("step_code");
            this.Property(t => t.step_type).HasColumnName("step_type");
            this.Property(t => t.step_log_id).HasColumnName("step_log_id");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
        }
    }
}
