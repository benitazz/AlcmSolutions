using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class fn_compinvsurMap : EntityTypeConfiguration<fn_compinvsur>
    {
        public fn_compinvsurMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.fn_std)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.survey_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("fn_compinvsur", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.count_audit).HasColumnName("count_audit");
            this.Property(t => t.count_inv).HasColumnName("count_inv");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.fn_std).HasColumnName("fn_std");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.survey_id).HasColumnName("survey_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.fn_compinvsur)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.FnCompinvsur)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.fnstd)
                .WithMany(t => t.fn_compinvsur)
                .HasForeignKey(d => d.fn_std);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.fn_compinvsur)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasRequired(t => t.survey)
                .WithMany(t => t.fn_compinvsur)
                .HasForeignKey(d => d.survey_id);

        }
    }
}
