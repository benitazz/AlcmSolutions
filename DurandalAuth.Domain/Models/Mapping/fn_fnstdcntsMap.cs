using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class fn_fnstdcntsMap : EntityTypeConfiguration<fn_fnstdcnts>
    {
        public fn_fnstdcntsMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

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

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.fn_std)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("fn_fnstdcnts", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.fn_std).HasColumnName("fn_std");
            this.Property(t => t.fnstd_count).HasColumnName("fnstd_count");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.fn_fnstdcnts)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.fn_fnstdcnts)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.fn_fnstdcnts)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.FnFnstdcnts)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.fnstd)
                .WithMany(t => t.fn_fnstdcnts)
                .HasForeignKey(d => d.fn_std);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.fn_fnstdcnts)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
