using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class jkcfgMap : EntityTypeConfiguration<jkcfg>
    {
        public jkcfgMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.fp_std)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.jk_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.prefix)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("jkcfg", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.fp_std).HasColumnName("fp_std");
            this.Property(t => t.jk_std).HasColumnName("jk_std");
            this.Property(t => t.num_ports).HasColumnName("num_ports");
            this.Property(t => t.prefix).HasColumnName("prefix");
            this.Property(t => t.start_number).HasColumnName("start_number");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.jkcfgs)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.fpstd)
                .WithMany(t => t.jkcfgs)
                .HasForeignKey(d => d.fp_std);
            this.HasOptional(t => t.jkstd)
                .WithMany(t => t.jkcfgs)
                .HasForeignKey(d => d.jk_std);

        }
    }
}
