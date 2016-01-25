using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class portMap : EntityTypeConfiguration<port>
    {
        public portMap()
        {
            // Primary Key
            this.HasKey(t => t.port_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.port_std)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.rack_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tc_use_status)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.port_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("port", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.port_std).HasColumnName("port_std");
            this.Property(t => t.rack_id).HasColumnName("rack_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_use_status).HasColumnName("tc_use_status");
            this.Property(t => t.port_id).HasColumnName("port_id");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.ports)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.ports)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Ports)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.portstd)
                .WithMany(t => t.ports)
                .HasForeignKey(d => d.port_std);
            this.HasOptional(t => t.rack)
                .WithMany(t => t.ports)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id, d.rack_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.ports)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
