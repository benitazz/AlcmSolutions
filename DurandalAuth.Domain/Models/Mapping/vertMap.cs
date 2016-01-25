using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class vertMap : EntityTypeConfiguration<vert>
    {
        public vertMap()
        {
            // Primary Key
            this.HasKey(t => t.vert_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.layer_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.vert_num)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.vert_std)
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("vert", "afm");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.layer_name).HasColumnName("layer_name");
            this.Property(t => t.vert_num).HasColumnName("vert_num");
            this.Property(t => t.vert_std).HasColumnName("vert_std");
            this.Property(t => t.vert_id).HasColumnName("vert_id");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.verts)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.Verts)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.vertstd)
                .WithMany(t => t.verts)
                .HasForeignKey(d => d.vert_std);

        }
    }
}
