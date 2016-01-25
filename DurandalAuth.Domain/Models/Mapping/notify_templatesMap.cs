using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class notify_templatesMap : EntityTypeConfiguration<notify_templates>
    {
        public notify_templatesMap()
        {
            // Primary Key
            this.HasKey(t => t.template_id);

            // Properties
            this.Property(t => t.activity_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.alert_duration_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.internal_code)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.notify_cat)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.notify_message_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.notify_message_refby)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.notify_recipients)
                .HasMaxLength(2000);

            this.Property(t => t.notify_recipients_grp)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.notify_subject)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.notify_subject_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.notify_subject_refby)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.notify_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.trigger_condition_from)
                .HasMaxLength(256);

            this.Property(t => t.trigger_condition_to)
                .HasMaxLength(256);

            this.Property(t => t.trigger_date_field)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.trigger_lead_seq)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.trigger_time_field)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.view_url)
                .HasMaxLength(256);

            this.Property(t => t.template_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("notify_templates", "afm");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.alert_duration_days).HasColumnName("alert_duration_days");
            this.Property(t => t.alert_duration_type).HasColumnName("alert_duration_type");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.internal_code).HasColumnName("internal_code");
            this.Property(t => t.notify_cat).HasColumnName("notify_cat");
            this.Property(t => t.notify_message_id).HasColumnName("notify_message_id");
            this.Property(t => t.notify_message_refby).HasColumnName("notify_message_refby");
            this.Property(t => t.notify_recipients).HasColumnName("notify_recipients");
            this.Property(t => t.notify_recipients_grp).HasColumnName("notify_recipients_grp");
            this.Property(t => t.notify_recurrence).HasColumnName("notify_recurrence");
            this.Property(t => t.notify_subject).HasColumnName("notify_subject");
            this.Property(t => t.notify_subject_id).HasColumnName("notify_subject_id");
            this.Property(t => t.notify_subject_refby).HasColumnName("notify_subject_refby");
            this.Property(t => t.notify_type).HasColumnName("notify_type");
            this.Property(t => t.total_recurrence).HasColumnName("total_recurrence");
            this.Property(t => t.trigger_condition_from).HasColumnName("trigger_condition_from");
            this.Property(t => t.trigger_condition_to).HasColumnName("trigger_condition_to");
            this.Property(t => t.trigger_date_field).HasColumnName("trigger_date_field");
            this.Property(t => t.trigger_lead).HasColumnName("trigger_lead");
            this.Property(t => t.trigger_lead_seq).HasColumnName("trigger_lead_seq");
            this.Property(t => t.trigger_time_field).HasColumnName("trigger_time_field");
            this.Property(t => t.view_url).HasColumnName("view_url");
            this.Property(t => t.template_id).HasColumnName("template_id");

            // Relationships
            this.HasOptional(t => t.afm_activities)
                .WithMany(t => t.notify_templates)
                .HasForeignKey(d => d.activity_id);
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.notify_templates)
                .HasForeignKey(d => d.notify_recipients_grp);
            this.HasOptional(t => t.message)
                .WithMany(t => t.notify_templates)
                .HasForeignKey(d => new { d.activity_id, d.notify_message_refby, d.notify_message_id });
            this.HasOptional(t => t.message1)
                .WithMany(t => t.notify_templates1)
                .HasForeignKey(d => new { d.activity_id, d.notify_subject_refby, d.notify_subject_id });
            this.HasOptional(t => t.notifycat)
                .WithMany(t => t.notify_templates)
                .HasForeignKey(d => new { d.activity_id, d.notify_cat });

        }
    }
}
