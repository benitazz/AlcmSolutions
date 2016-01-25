using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pbMap : EntityTypeConfiguration<pb>
    {
        public pbMap()
        {
            // Primary Key
            this.HasKey(t => t.pb_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.cross_connect_level)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.detail_dwg)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.mount_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.pb_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rack_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.shelf_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tc_service)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.pb_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pb", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cross_connect_level).HasColumnName("cross_connect_level");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.detail_dwg).HasColumnName("detail_dwg");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.mount_id).HasColumnName("mount_id");
            this.Property(t => t.pb_std).HasColumnName("pb_std");
            this.Property(t => t.rack_id).HasColumnName("rack_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.shelf_id).HasColumnName("shelf_id");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_service).HasColumnName("tc_service");
            this.Property(t => t.pb_id).HasColumnName("pb_id");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.pbs)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.pbs)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Pbs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.pbstd)
                .WithMany(t => t.pbs)
                .HasForeignKey(d => d.pb_std);
            this.HasOptional(t => t.rack)
                .WithMany(t => t.pbs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id, d.rack_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.pbs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
