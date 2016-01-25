using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_notifications_logMap : EntityTypeConfiguration<afm_notifications_log>
    {
        public afm_notifications_logMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.email_from)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.email_host)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.email_message)
                .HasMaxLength(5000);

            this.Property(t => t.email_subject)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.email_to)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status_message)
                .HasMaxLength(1000);

            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_notifications_log", "afm");
            this.Property(t => t.email_from).HasColumnName("email_from");
            this.Property(t => t.email_host).HasColumnName("email_host");
            this.Property(t => t.email_message).HasColumnName("email_message");
            this.Property(t => t.email_subject).HasColumnName("email_subject");
            this.Property(t => t.email_to).HasColumnName("email_to");
            this.Property(t => t.server_date_sent).HasColumnName("server_date_sent");
            this.Property(t => t.server_time_sent).HasColumnName("server_time_sent");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.status_message).HasColumnName("status_message");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasRequired(t => t.afm_activities)
                .WithMany(t => t.afm_notifications_log)
                .HasForeignKey(d => d.activity_id);

        }
    }
}
