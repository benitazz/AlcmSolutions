using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pnMap : EntityTypeConfiguration<pn>
    {
        public pnMap()
        {
            // Primary Key
            this.HasKey(t => t.pn_id);

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

            this.Property(t => t.pn_std)
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

            this.Property(t => t.pn_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pn", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cross_connect_level).HasColumnName("cross_connect_level");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.detail_dwg).HasColumnName("detail_dwg");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.pn_std).HasColumnName("pn_std");
            this.Property(t => t.rack_id).HasColumnName("rack_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.shelf_id).HasColumnName("shelf_id");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_service).HasColumnName("tc_service");
            this.Property(t => t.pn_id).HasColumnName("pn_id");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.pns)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.pns)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Pns)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.pnstd)
                .WithMany(t => t.pns)
                .HasForeignKey(d => d.pn_std);
            this.HasOptional(t => t.rack)
                .WithMany(t => t.pns)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id, d.rack_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.pns)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
