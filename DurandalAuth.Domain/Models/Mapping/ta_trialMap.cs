using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ta_trialMap : EntityTypeConfiguration<ta_trial>
    {
        public ta_trialMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ta_id, t.layer_name });

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

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.trial_project_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ta_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.layer_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ta_trial", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.fn_std).HasColumnName("fn_std");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.trial_project_id).HasColumnName("trial_project_id");
            this.Property(t => t.ta_id).HasColumnName("ta_id");
            this.Property(t => t.layer_name).HasColumnName("layer_name");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.ta_trial)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.TaTrial)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.fnstd)
                .WithMany(t => t.ta_trial)
                .HasForeignKey(d => d.fn_std);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.ta_trial)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasRequired(t => t.ta)
                .WithMany(t => t.ta_trial)
                .HasForeignKey(d => d.ta_id);
            this.HasOptional(t => t.trialproject)
                .WithMany(t => t.ta_trial)
                .HasForeignKey(d => d.trial_project_id);

        }
    }
}
