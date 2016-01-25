using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_cert_levelsMap : EntityTypeConfiguration<gb_cert_levels>
    {
        public gb_cert_levelsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cert_std, t.cert_level });

            // Properties
            this.Property(t => t.cert_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cert_level)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("gb_cert_levels", "afm");
            this.Property(t => t.max_score).HasColumnName("max_score");
            this.Property(t => t.min_score).HasColumnName("min_score");
            this.Property(t => t.cert_std).HasColumnName("cert_std");
            this.Property(t => t.cert_level).HasColumnName("cert_level");

            // Relationships
            this.HasRequired(t => t.gb_cert_std)
                .WithMany(t => t.gb_cert_levels)
                .HasForeignKey(d => d.cert_std);

        }
    }
}
