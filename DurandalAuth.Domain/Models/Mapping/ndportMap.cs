using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ndportMap : EntityTypeConfiguration<ndport>
    {
        public ndportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.netdev_id, t.port_id });

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.hardware_address)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.net_address)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.port_std)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.segment)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tc_use_status)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.netdev_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.port_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("ndport", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hardware_address).HasColumnName("hardware_address");
            this.Property(t => t.net_address).HasColumnName("net_address");
            this.Property(t => t.port_std).HasColumnName("port_std");
            this.Property(t => t.segment).HasColumnName("segment");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_use_status).HasColumnName("tc_use_status");
            this.Property(t => t.netdev_id).HasColumnName("netdev_id");
            this.Property(t => t.port_id).HasColumnName("port_id");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.ndports)
                .HasForeignKey(d => d.tc_level);
            this.HasRequired(t => t.netdev)
                .WithMany(t => t.ndports)
                .HasForeignKey(d => d.netdev_id);
            this.HasOptional(t => t.portstd)
                .WithMany(t => t.ndports)
                .HasForeignKey(d => d.port_std);

        }
    }
}
