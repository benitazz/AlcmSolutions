using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class notificationMap : EntityTypeConfiguration<notification>
    {
        public notificationMap()
        {
            // Primary Key
            this.HasKey(t => t.notify_id);

            // Properties
            this.Property(t => t.notify_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status_previous)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.template_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.view_pkeys)
                .HasMaxLength(256);

            this.Property(t => t.view_url)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("notifications", "afm");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.date_notify).HasColumnName("date_notify");
            this.Property(t => t.date_sent).HasColumnName("date_sent");
            this.Property(t => t.is_active).HasColumnName("is_active");
            this.Property(t => t.notify_count).HasColumnName("notify_count");
            this.Property(t => t.notify_type).HasColumnName("notify_type");
            this.Property(t => t.status_previous).HasColumnName("status_previous");
            this.Property(t => t.template_id).HasColumnName("template_id");
            this.Property(t => t.time_notify).HasColumnName("time_notify");
            this.Property(t => t.time_sent).HasColumnName("time_sent");
            this.Property(t => t.view_pkeys).HasColumnName("view_pkeys");
            this.Property(t => t.view_url).HasColumnName("view_url");
            this.Property(t => t.notify_id).HasColumnName("notify_id");

            // Relationships
            this.HasOptional(t => t.activity_log)
                .WithMany(t => t.notifications)
                .HasForeignKey(d => d.activity_log_id);
            this.HasRequired(t => t.notify_templates)
                .WithMany(t => t.notifications)
                .HasForeignKey(d => d.template_id);

        }
    }
}
