using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_wf_stepsMap : EntityTypeConfiguration<afm_wf_steps>
    {
        public afm_wf_stepsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.activity_id, t.status, t.step });

            // Properties
            this.Property(t => t.step_01)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.step_02)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.step_03)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.step_ch)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.step_de)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.step_es)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.step_fr)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.step_it)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.step_jp)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.step_ko)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.step_nl)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.step_no)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.step_status_rejected)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.step_status_result)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.step_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.step_zh)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.subject_message_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.attachments)
                .IsFixedLength()
                .HasMaxLength(256);

            this.Property(t => t.body_message_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.form_fields)
                .IsFixedLength()
                .HasMaxLength(256);

            this.Property(t => t.status_after)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.step)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_wf_steps", "afm");
            this.Property(t => t.step_01).HasColumnName("step_01");
            this.Property(t => t.step_02).HasColumnName("step_02");
            this.Property(t => t.step_03).HasColumnName("step_03");
            this.Property(t => t.step_ch).HasColumnName("step_ch");
            this.Property(t => t.step_de).HasColumnName("step_de");
            this.Property(t => t.step_es).HasColumnName("step_es");
            this.Property(t => t.step_fr).HasColumnName("step_fr");
            this.Property(t => t.step_it).HasColumnName("step_it");
            this.Property(t => t.step_jp).HasColumnName("step_jp");
            this.Property(t => t.step_ko).HasColumnName("step_ko");
            this.Property(t => t.step_nl).HasColumnName("step_nl");
            this.Property(t => t.step_no).HasColumnName("step_no");
            this.Property(t => t.step_status_rejected).HasColumnName("step_status_rejected");
            this.Property(t => t.step_status_result).HasColumnName("step_status_result");
            this.Property(t => t.step_type).HasColumnName("step_type");
            this.Property(t => t.step_zh).HasColumnName("step_zh");
            this.Property(t => t.subject_message_id).HasColumnName("subject_message_id");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.attachments).HasColumnName("attachments");
            this.Property(t => t.body_message_id).HasColumnName("body_message_id");
            this.Property(t => t.display_order).HasColumnName("display_order");
            this.Property(t => t.form_fields).HasColumnName("form_fields");
            this.Property(t => t.status_after).HasColumnName("status_after");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.step).HasColumnName("step");

            // Relationships
            this.HasRequired(t => t.afm_activities)
                .WithMany(t => t.afm_wf_steps)
                .HasForeignKey(d => d.activity_id);

        }
    }
}
