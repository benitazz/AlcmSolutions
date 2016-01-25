using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cardstdMap : EntityTypeConfiguration<cardstd>
    {
        public cardstdMap()
        {
            // Primary Key
            this.HasKey(t => t.card_std);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.netdev_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tc_contained_tbls)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.card_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("cardstd", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.is_multiplexing).HasColumnName("is_multiplexing");
            this.Property(t => t.netdev_type).HasColumnName("netdev_type");
            this.Property(t => t.tc_contained_tbls).HasColumnName("tc_contained_tbls");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_npositions).HasColumnName("tc_npositions");
            this.Property(t => t.card_std).HasColumnName("card_std");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.cardstds)
                .HasForeignKey(d => d.tc_level);

        }
    }
}
