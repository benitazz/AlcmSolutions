using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class vertstdMap : EntityTypeConfiguration<vertstd>
    {
        public vertstdMap()
        {
            // Primary Key
            this.HasKey(t => t.vert_std);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.hpattern)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.hpattern_acad)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.vert_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("vertstd", "afm");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hpattern).HasColumnName("hpattern");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.tot_count).HasColumnName("tot_count");
            this.Property(t => t.vert_std).HasColumnName("vert_std");
        }
    }
}
