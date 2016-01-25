using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class hprorateMap : EntityTypeConfiguration<hprorate>
    {
        public hprorateMap()
        {
            // Primary Key
            this.HasKey(t => t.prorate);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.hpattern)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.hpattern_acad)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.prorate)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("hprorate", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hpattern).HasColumnName("hpattern");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.prorate).HasColumnName("prorate");
        }
    }
}
