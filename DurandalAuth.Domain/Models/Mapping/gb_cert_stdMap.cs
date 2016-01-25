using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_cert_stdMap : EntityTypeConfiguration<gb_cert_std>
    {
        public gb_cert_stdMap()
        {
            // Primary Key
            this.HasKey(t => t.cert_std);

            // Properties
            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.scoring_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.std_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cert_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("gb_cert_std", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.scoring_type).HasColumnName("scoring_type");
            this.Property(t => t.std_type).HasColumnName("std_type");
            this.Property(t => t.cert_std).HasColumnName("cert_std");
        }
    }
}
