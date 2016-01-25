using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gpstdMap : EntityTypeConfiguration<gpstd>
    {
        public gpstdMap()
        {
            // Primary Key
            this.HasKey(t => t.gp_std);

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

            this.Property(t => t.gp_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("gpstd", "afm");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hpattern).HasColumnName("hpattern");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.tot_count).HasColumnName("tot_count");
            this.Property(t => t.gp_std).HasColumnName("gp_std");
        }
    }
}
