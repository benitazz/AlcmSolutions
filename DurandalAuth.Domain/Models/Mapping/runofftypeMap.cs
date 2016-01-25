using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class runofftypeMap : EntityTypeConfiguration<runofftype>
    {
        public runofftypeMap()
        {
            // Primary Key
            this.HasKey(t => t.runoff_type);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(256);

            this.Property(t => t.hpattern)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.hpattern_acad)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.material)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.permiability)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.runoff_class)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.runoff_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("runofftype", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hpattern).HasColumnName("hpattern");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.material).HasColumnName("material");
            this.Property(t => t.permiability).HasColumnName("permiability");
            this.Property(t => t.runoff_class).HasColumnName("runoff_class");
            this.Property(t => t.runoff_type).HasColumnName("runoff_type");
        }
    }
}
