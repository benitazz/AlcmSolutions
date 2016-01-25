using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class hhelpdesk_step_logMap : EntityTypeConfiguration<hhelpdesk_step_log>
    {
        public hhelpdesk_step_logMap()
        {
            // Primary Key
            this.HasKey(t => t.step_log_id);

            // Properties
            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.cf_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.condition)
                .HasMaxLength(200);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.field_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.role_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.step)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.step_code)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.step_status_result)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.step_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.table_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.user_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.step_log_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("hhelpdesk_step_log", "afm");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.cf_id).HasColumnName("cf_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.condition).HasColumnName("condition");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.date_response).HasColumnName("date_response");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.email_sent).HasColumnName("email_sent");
            this.Property(t => t.field_name).HasColumnName("field_name");
            this.Property(t => t.multiple_required).HasColumnName("multiple_required");
            this.Property(t => t.pkey_value).HasColumnName("pkey_value");
            this.Property(t => t.role_name).HasColumnName("role_name");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.step).HasColumnName("step");
            this.Property(t => t.step_code).HasColumnName("step_code");
            this.Property(t => t.step_order).HasColumnName("step_order");
            this.Property(t => t.step_status_result).HasColumnName("step_status_result");
            this.Property(t => t.step_type).HasColumnName("step_type");
            this.Property(t => t.table_name).HasColumnName("table_name");
            this.Property(t => t.time_created).HasColumnName("time_created");
            this.Property(t => t.time_response).HasColumnName("time_response");
            this.Property(t => t.user_name).HasColumnName("user_name");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.step_log_id).HasColumnName("step_log_id");
        }
    }
}
