using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_versionsMap : EntityTypeConfiguration<gb_fp_versions>
    {
        public gb_fp_versionsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.version_type, t.version_name });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(300);

            this.Property(t => t.version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.version_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            // Table & Column Mappings
            this.ToTable("gb_fp_versions", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.version_type).HasColumnName("version_type");
            this.Property(t => t.version_name).HasColumnName("version_name");
        }
    }
}
