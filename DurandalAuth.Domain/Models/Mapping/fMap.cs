using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class fMap : EntityTypeConfiguration<f>
    {
        public fMap()
        {
            // Primary Key
            this.HasKey(t => new { t.survey_id, t.bl_id, t.fl_id, t.rm_id, t.fn_std });

            // Properties
            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.survey_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rm_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fn_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("fs", "afm");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.fn_count).HasColumnName("fn_count");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.survey_id).HasColumnName("survey_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.fn_std).HasColumnName("fn_std");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.fs)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.fs)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.fs)
                .HasForeignKey(d => d.dv_id);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.Fs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasRequired(t => t.fnstd)
                .WithMany(t => t.fs)
                .HasForeignKey(d => d.fn_std);
            this.HasRequired(t => t.rm)
                .WithMany(t => t.fs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasRequired(t => t.survey)
                .WithMany(t => t.fs)
                .HasForeignKey(d => d.survey_id);

        }
    }
}
