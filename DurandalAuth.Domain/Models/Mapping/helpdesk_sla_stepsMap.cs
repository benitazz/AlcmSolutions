using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class helpdesk_sla_stepsMap : EntityTypeConfiguration<helpdesk_sla_steps>
    {
        public helpdesk_sla_stepsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.activity_id, t.activity_type, t.ordering_seq, t.priority, t.status, t.step_order });

            // Properties
            this.Property(t => t.cf_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.condition)
                .IsFixedLength()
                .HasMaxLength(256);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.role)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.role_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.step)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.step_status)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.step_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.activity_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ordering_seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.priority)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.step_order)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("helpdesk_sla_steps", "afm");
            this.Property(t => t.cf_id).HasColumnName("cf_id");
            this.Property(t => t.condition).HasColumnName("condition");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.multiple_required).HasColumnName("multiple_required");
            this.Property(t => t.notify_responsible).HasColumnName("notify_responsible");
            this.Property(t => t.role).HasColumnName("role");
            this.Property(t => t.role_name).HasColumnName("role_name");
            this.Property(t => t.step).HasColumnName("step");
            this.Property(t => t.step_status).HasColumnName("step_status");
            this.Property(t => t.step_type).HasColumnName("step_type");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.activity_type).HasColumnName("activity_type");
            this.Property(t => t.ordering_seq).HasColumnName("ordering_seq");
            this.Property(t => t.priority).HasColumnName("priority");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.step_order).HasColumnName("step_order");

            // Relationships
            this.HasRequired(t => t.activitytype)
                .WithMany(t => t.helpdesk_sla_steps)
                .HasForeignKey(d => d.activity_type);
            this.HasRequired(t => t.afm_activities)
                .WithMany(t => t.helpdesk_sla_steps)
                .HasForeignKey(d => d.activity_id);
            this.HasOptional(t => t.afm_roles)
                .WithMany(t => t.helpdesk_sla_steps)
                .HasForeignKey(d => d.role_name);
            this.HasRequired(t => t.afm_wf_steps)
                .WithMany(t => t.helpdesk_sla_steps)
                .HasForeignKey(d => new { d.activity_id, d.status, d.step });
            this.HasOptional(t => t.cf)
                .WithMany(t => t.HelpdeskSlaSteps)
                .HasForeignKey(d => d.cf_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.HelpdeskSlaSteps)
                .HasForeignKey(d => d.em_id);
            this.HasRequired(t => t.helpdesk_sla_request)
                .WithMany(t => t.helpdesk_sla_steps)
                .HasForeignKey(d => new { d.activity_type, d.ordering_seq });
            this.HasRequired(t => t.helpdesk_sla_response)
                .WithMany(t => t.helpdesk_sla_steps)
                .HasForeignKey(d => new { d.activity_type, d.ordering_seq, d.priority });
            this.HasOptional(t => t.vn)
                .WithMany(t => t.helpdesk_sla_steps)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
