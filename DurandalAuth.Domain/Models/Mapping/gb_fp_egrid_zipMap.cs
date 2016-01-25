using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_egrid_zipMap : EntityTypeConfiguration<gb_fp_egrid_zip>
    {
        public gb_fp_egrid_zipMap()
        {
            // Primary Key
            this.HasKey(t => new { t.version_type, t.version_name, t.subregion_code, t.zip });

            // Properties
            this.Property(t => t.city_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.state_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.version_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.subregion_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.zip)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("gb_fp_egrid_zip", "afm");
            this.Property(t => t.city_id).HasColumnName("city_id");
            this.Property(t => t.state_id).HasColumnName("state_id");
            this.Property(t => t.version_type).HasColumnName("version_type");
            this.Property(t => t.version_name).HasColumnName("version_name");
            this.Property(t => t.subregion_code).HasColumnName("subregion_code");
            this.Property(t => t.zip).HasColumnName("zip");

            // Relationships
            this.HasOptional(t => t.city)
                .WithMany(t => t.GbFpEgridZip)
                .HasForeignKey(d => new { d.state_id, d.city_id });
            this.HasRequired(t => t.gb_fp_egrid_subregions)
                .WithMany(t => t.gb_fp_egrid_zip)
                .HasForeignKey(d => new { d.version_type, d.version_name, d.subregion_code });
            this.HasOptional(t => t.state)
                .WithMany(t => t.gb_fp_egrid_zip)
                .HasForeignKey(d => d.state_id);
            this.HasRequired(t => t.gb_fp_versions)
                .WithMany(t => t.gb_fp_egrid_zip)
                .HasForeignKey(d => new { d.version_type, d.version_name });

        }
    }
}
