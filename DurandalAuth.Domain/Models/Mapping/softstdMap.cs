using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class softstdMap : EntityTypeConfiguration<softstd>
    {
        public softstdMap()
        {
            // Primary Key
            this.HasKey(t => t.soft_std);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.mfr)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.version)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.soft_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("softstd", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.mfr).HasColumnName("mfr");
            this.Property(t => t.version).HasColumnName("version");
            this.Property(t => t.soft_std).HasColumnName("soft_std");
        }
    }
}
