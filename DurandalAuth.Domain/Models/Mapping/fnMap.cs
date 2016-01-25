using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class fnMap : EntityTypeConfiguration<fn>
    {
        public fnMap()
        {
            // Primary Key
            this.HasKey(t => t.FnId);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Dwgname)
                .HasMaxLength(128);

            this.Property(t => t.Ehandle)
                .HasMaxLength(64);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.FnStd)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.LayerName)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.Status)
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("fn", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.Dwgname).HasColumnName("dwgname");
            this.Property(t => t.Ehandle).HasColumnName("ehandle");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.FnStd).HasColumnName("fn_std");
            this.Property(t => t.LayerName).HasColumnName("layer_name");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.Status).HasColumnName("status");
            this.Property(t => t.FnId).HasColumnName("fn_id");

            // Relationships
            this.HasOptional(t => t.Bl)
                .WithMany(t => t.fns)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.Dp)
                .WithMany(t => t.fns)
                .HasForeignKey(d => new { dv_id = d.dv_id, dp_id = d.dp_id });
            this.HasOptional(t => t.Dv)
                .WithMany(t => t.fns)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.Fl)
                .WithMany(t => t.Fns)
                .HasForeignKey(d => new { bl_id = d.bl_id, fl_id = d.fl_id });
            this.HasOptional(t => t.Fnstd)
                .WithMany(t => t.fns)
                .HasForeignKey(d => d.FnStd);
            this.HasOptional(t => t.Rm)
                .WithMany(t => t.fns)
                .HasForeignKey(d => new { bl_id = d.bl_id, fl_id = d.fl_id, rm_id = d.rm_id });

        }
    }
}
