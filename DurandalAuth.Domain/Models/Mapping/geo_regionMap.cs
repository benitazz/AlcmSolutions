using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class geo_regionMap : EntityTypeConfiguration<geo_region>
    {
        public geo_regionMap()
        {
            // Primary Key
            this.HasKey(t => t.geo_region_id);

            // Properties
            this.Property(t => t.geo_region_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.hpattern_acad)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .HasMaxLength(1000);

            this.Property(t => t.geo_region_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("geo_region", "afm");
            this.Property(t => t.geo_region_name).HasColumnName("geo_region_name");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.geo_region_id).HasColumnName("geo_region_id");
        }
    }
}
