using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class netdevMap : EntityTypeConfiguration<netdev>
    {
        public netdevMap()
        {
            // Primary Key
            this.HasKey(t => t.netdev_id);

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

            this.Property(t => t.hardware_address)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.net_address)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.net_address_ip)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.net_card_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.net_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.net_sub_mask)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.netdev_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.netdev_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.num_serial)
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

            this.Property(t => t.tc_service)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.netdev_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("netdev", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cross_connect_level).HasColumnName("cross_connect_level");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.detail_dwg).HasColumnName("detail_dwg");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.hardware_address).HasColumnName("hardware_address");
            this.Property(t => t.is_multiplexing).HasColumnName("is_multiplexing");
            this.Property(t => t.net_address).HasColumnName("net_address");
            this.Property(t => t.net_address_ip).HasColumnName("net_address_ip");
            this.Property(t => t.net_card_type).HasColumnName("net_card_type");
            this.Property(t => t.net_id).HasColumnName("net_id");
            this.Property(t => t.net_sub_mask).HasColumnName("net_sub_mask");
            this.Property(t => t.netdev_std).HasColumnName("netdev_std");
            this.Property(t => t.netdev_type).HasColumnName("netdev_type");
            this.Property(t => t.num_serial).HasColumnName("num_serial");
            this.Property(t => t.rack_id).HasColumnName("rack_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_service).HasColumnName("tc_service");
            this.Property(t => t.netdev_id).HasColumnName("netdev_id");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.netdevs)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.netdevs)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Netdevs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.net)
                .WithMany(t => t.netdevs)
                .HasForeignKey(d => d.net_id);
            this.HasOptional(t => t.netdevstd)
                .WithMany(t => t.netdevs)
                .HasForeignKey(d => d.netdev_std);
            this.HasOptional(t => t.rack)
                .WithMany(t => t.netdevs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id, d.rack_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.netdevs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
