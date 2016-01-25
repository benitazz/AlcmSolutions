using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class jkstdMap : EntityTypeConfiguration<jkstd>
    {
        public jkstdMap()
        {
            // Primary Key
            this.HasKey(t => t.jk_std);

            // Properties
            this.Property(t => t.ca_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.connector_type)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.image_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.symbol)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tc_service)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.jk_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("jkstd", "afm");
            this.Property(t => t.ca_std).HasColumnName("ca_std");
            this.Property(t => t.connector_type).HasColumnName("connector_type");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.image_file).HasColumnName("image_file");
            this.Property(t => t.symbol).HasColumnName("symbol");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_service).HasColumnName("tc_service");
            this.Property(t => t.jk_std).HasColumnName("jk_std");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.jkstds)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.castd)
                .WithMany(t => t.jkstds)
                .HasForeignKey(d => d.ca_std);

        }
    }
}
