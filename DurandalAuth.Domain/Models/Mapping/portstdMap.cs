using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class portstdMap : EntityTypeConfiguration<portstd>
    {
        public portstdMap()
        {
            // Primary Key
            this.HasKey(t => t.port_std);

            // Properties
            this.Property(t => t.connector_type)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.port_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("portstd", "afm");
            this.Property(t => t.connector_type).HasColumnName("connector_type");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.port_std).HasColumnName("port_std");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.portstds)
                .HasForeignKey(d => d.tc_level);

        }
    }
}
