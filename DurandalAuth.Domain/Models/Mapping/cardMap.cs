using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cardMap : EntityTypeConfiguration<card>
    {
        public cardMap()
        {
            // Primary Key
            this.HasKey(t => t.card_id);

            // Properties
            this.Property(t => t.card_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.hardware_address)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.net_address)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.net_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.netdev_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.netdev_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.slot_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.card_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("card", "afm");
            this.Property(t => t.card_std).HasColumnName("card_std");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.hardware_address).HasColumnName("hardware_address");
            this.Property(t => t.is_multiplexing).HasColumnName("is_multiplexing");
            this.Property(t => t.net_address).HasColumnName("net_address");
            this.Property(t => t.net_id).HasColumnName("net_id");
            this.Property(t => t.netdev_id).HasColumnName("netdev_id");
            this.Property(t => t.netdev_type).HasColumnName("netdev_type");
            this.Property(t => t.slot_id).HasColumnName("slot_id");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.card_id).HasColumnName("card_id");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.cards)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.cardstd)
                .WithMany(t => t.cards)
                .HasForeignKey(d => d.card_std);
            this.HasOptional(t => t.eq)
                .WithMany(t => t.cards)
                .HasForeignKey(d => d.eq_id);
            this.HasOptional(t => t.net)
                .WithMany(t => t.cards)
                .HasForeignKey(d => d.net_id);
            this.HasOptional(t => t.netdev)
                .WithMany(t => t.cards)
                .HasForeignKey(d => d.netdev_id);

        }
    }
}
