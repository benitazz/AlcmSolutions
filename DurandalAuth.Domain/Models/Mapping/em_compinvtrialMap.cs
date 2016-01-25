using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class em_compinvtrialMap : EntityTypeConfiguration<em_compinvtrial>
    {
        public em_compinvtrialMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.difference)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.dwgnames)
                .HasMaxLength(128);

            this.Property(t => t.em_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.inv_bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.inv_fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.inv_rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.layers)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.trial_bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.trial_fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.trial_project_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.trial_rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("em_compinvtrial", "afm");
            this.Property(t => t.difference).HasColumnName("difference");
            this.Property(t => t.dwgnames).HasColumnName("dwgnames");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.inv_bl_id).HasColumnName("inv_bl_id");
            this.Property(t => t.inv_fl_id).HasColumnName("inv_fl_id");
            this.Property(t => t.inv_rm_id).HasColumnName("inv_rm_id");
            this.Property(t => t.layers).HasColumnName("layers");
            this.Property(t => t.mo_id).HasColumnName("mo_id");
            this.Property(t => t.trial_bl_id).HasColumnName("trial_bl_id");
            this.Property(t => t.trial_fl_id).HasColumnName("trial_fl_id");
            this.Property(t => t.trial_project_id).HasColumnName("trial_project_id");
            this.Property(t => t.trial_rm_id).HasColumnName("trial_rm_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.em_compinvtrial)
                .HasForeignKey(d => d.inv_bl_id);
            this.HasOptional(t => t.bl1)
                .WithMany(t => t.em_compinvtrial1)
                .HasForeignKey(d => d.trial_bl_id);
            this.HasRequired(t => t.em)
                .WithMany(t => t.EmCompinvtrial)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.EmCompinvtrial)
                .HasForeignKey(d => new { d.inv_bl_id, d.inv_fl_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.em_compinvtrial)
                .HasForeignKey(d => new { d.inv_bl_id, d.inv_fl_id, d.inv_rm_id });
            this.HasOptional(t => t.mo)
                .WithMany(t => t.em_compinvtrial)
                .HasForeignKey(d => d.mo_id);
            this.HasOptional(t => t.fl1)
                .WithMany(t => t.EmCompinvtrial1)
                .HasForeignKey(d => new { d.trial_bl_id, d.trial_fl_id });
            this.HasOptional(t => t.rm1)
                .WithMany(t => t.em_compinvtrial1)
                .HasForeignKey(d => new { d.trial_bl_id, d.trial_fl_id, d.trial_rm_id });

        }
    }
}
