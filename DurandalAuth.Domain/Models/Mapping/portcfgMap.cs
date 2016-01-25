using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class portcfgMap : EntityTypeConfiguration<portcfg>
    {
        public portcfgMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.card_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.eq_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.netdev_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pn_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.port_std)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.prefix)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("portcfg", "afm");
            this.Property(t => t.card_std).HasColumnName("card_std");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.netdev_std).HasColumnName("netdev_std");
            this.Property(t => t.num_ports).HasColumnName("num_ports");
            this.Property(t => t.pn_std).HasColumnName("pn_std");
            this.Property(t => t.port_std).HasColumnName("port_std");
            this.Property(t => t.prefix).HasColumnName("prefix");
            this.Property(t => t.start_number).HasColumnName("start_number");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.portcfgs)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.cardstd)
                .WithMany(t => t.portcfgs)
                .HasForeignKey(d => d.card_std);
            this.HasOptional(t => t.eqstd)
                .WithMany(t => t.portcfgs)
                .HasForeignKey(d => d.eq_std);
            this.HasOptional(t => t.netdevstd)
                .WithMany(t => t.portcfgs)
                .HasForeignKey(d => d.netdev_std);
            this.HasOptional(t => t.pnstd)
                .WithMany(t => t.portcfgs)
                .HasForeignKey(d => d.pn_std);
            this.HasOptional(t => t.portstd)
                .WithMany(t => t.portcfgs)
                .HasForeignKey(d => d.port_std);

        }
    }
}
