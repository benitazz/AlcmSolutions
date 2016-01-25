using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class fn_trialMap : EntityTypeConfiguration<fn_trial>
    {
        public fn_trialMap()
        {
            // Primary Key
            this.HasKey(t => t.fn_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.fn_std)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.layer_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.trial_project_id)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("fn_trial", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.fn_std).HasColumnName("fn_std");
            this.Property(t => t.layer_name).HasColumnName("layer_name");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.trial_project_id).HasColumnName("trial_project_id");
            this.Property(t => t.fn_id).HasColumnName("fn_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.fn_trial)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.FnTrial)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.fnstd)
                .WithMany(t => t.fn_trial)
                .HasForeignKey(d => d.fn_std);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.fn_trial)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.trialproject)
                .WithMany(t => t.fn_trial)
                .HasForeignKey(d => d.trial_project_id);

        }
    }
}
