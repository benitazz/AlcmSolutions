using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class eq_auditMap : EntityTypeConfiguration<eq_audit>
    {
        public eq_auditMap()
        {
            // Primary Key
            this.HasKey(t => new { t.survey_id, t.eq_id });

            // Properties
            this.Property(t => t.eq_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.mob_locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.survey_comments)
                .HasMaxLength(5000);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.survey_photo_eq)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.survey_redline_eq)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.survey_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.eq_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("eq_audit", "afm");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.marked_for_deletion).HasColumnName("marked_for_deletion");
            this.Property(t => t.mob_is_changed).HasColumnName("mob_is_changed");
            this.Property(t => t.mob_locked_by).HasColumnName("mob_locked_by");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.survey_comments).HasColumnName("survey_comments");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.date_last_surveyed).HasColumnName("date_last_surveyed");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.survey_photo_eq).HasColumnName("survey_photo_eq");
            this.Property(t => t.survey_redline_eq).HasColumnName("survey_redline_eq");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.survey_id).HasColumnName("survey_id");
            this.Property(t => t.eq_id).HasColumnName("eq_id");

            // Relationships
            this.HasRequired(t => t.survey)
                .WithMany(t => t.eq_audit)
                .HasForeignKey(d => d.survey_id);

        }
    }
}
