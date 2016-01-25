using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class fpMap : EntityTypeConfiguration<fp>
    {
        public fpMap()
        {
            // Primary Key
            this.HasKey(t => t.fp_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.fp_std)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.grid_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("fp", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.date_installed).HasColumnName("date_installed");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.fp_std).HasColumnName("fp_std");
            this.Property(t => t.grid_id).HasColumnName("grid_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.fp_id).HasColumnName("fp_id");

            // Relationships
            this.HasMany(t => t.wies)
                .WithMany(t => t.fps)
                .Map(m =>
                    {
                        m.ToTable("fw", "afm");
                        m.MapLeftKey("fp_id");
                        m.MapRightKey("wy_id");
                    });

            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.fps)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.fps)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.Fps)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Fps)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.fpstd)
                .WithMany(t => t.fps)
                .HasForeignKey(d => d.fp_std);
            this.HasOptional(t => t.grid)
                .WithMany(t => t.fps)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.grid_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.fps)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
