using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pnportMap : EntityTypeConfiguration<pnport>
    {
        public pnportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pn_id, t.port_id });

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.pairs)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.port_std)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tc_use_status)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.pn_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.port_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("pnport", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.pairs).HasColumnName("pairs");
            this.Property(t => t.port_std).HasColumnName("port_std");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_use_status).HasColumnName("tc_use_status");
            this.Property(t => t.pn_id).HasColumnName("pn_id");
            this.Property(t => t.port_id).HasColumnName("port_id");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.pnports)
                .HasForeignKey(d => d.tc_level);
            this.HasRequired(t => t.pn)
                .WithMany(t => t.pnports)
                .HasForeignKey(d => d.pn_id);
            this.HasOptional(t => t.portstd)
                .WithMany(t => t.pnports)
                .HasForeignKey(d => d.port_std);

        }
    }
}
