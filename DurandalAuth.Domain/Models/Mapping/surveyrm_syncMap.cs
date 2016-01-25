using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class surveyrm_syncMap : EntityTypeConfiguration<surveyrm_sync>
    {
        public surveyrm_syncMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.mob_locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.prorate)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.rm_cat)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.rm_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.rm_std)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.rm_type)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.rm_use)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.survey_comments_rm)
                .HasMaxLength(5000);

            this.Property(t => t.survey_id)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.survey_photo)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.survey_redline_rm)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("surveyrm_sync", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cap_em).HasColumnName("cap_em");
            this.Property(t => t.date_last_surveyed).HasColumnName("date_last_surveyed");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.mob_is_changed).HasColumnName("mob_is_changed");
            this.Property(t => t.mob_locked_by).HasColumnName("mob_locked_by");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.prorate).HasColumnName("prorate");
            this.Property(t => t.rm_cat).HasColumnName("rm_cat");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.rm_std).HasColumnName("rm_std");
            this.Property(t => t.rm_type).HasColumnName("rm_type");
            this.Property(t => t.rm_use).HasColumnName("rm_use");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.survey_comments_rm).HasColumnName("survey_comments_rm");
            this.Property(t => t.survey_id).HasColumnName("survey_id");
            this.Property(t => t.survey_photo).HasColumnName("survey_photo");
            this.Property(t => t.survey_redline_rm).HasColumnName("survey_redline_rm");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.surveyrm_sync)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.surveyrm_sync)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.surveyrm_sync)
                .HasForeignKey(d => d.dv_id);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.SurveyrmSync)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rmcat)
                .WithMany(t => t.surveyrm_sync)
                .HasForeignKey(d => d.rm_cat);
            this.HasOptional(t => t.rmstd)
                .WithMany(t => t.surveyrm_sync)
                .HasForeignKey(d => d.rm_std);
            this.HasOptional(t => t.rmtype)
                .WithMany(t => t.surveyrm_sync)
                .HasForeignKey(d => new { d.rm_cat, d.rm_type });

        }
    }
}
