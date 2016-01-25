using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ctryMap : EntityTypeConfiguration<ctry>
    {
        public ctryMap()
        {
            // Primary Key
            this.HasKey(t => t.ctry_id);

            // Properties
            this.Property(t => t.detail_dwg)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.geo_region_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ctry_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("ctry", "afm");
            this.Property(t => t.detail_dwg).HasColumnName("detail_dwg");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.geo_region_id).HasColumnName("geo_region_id");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");

            // Relationships
            this.HasOptional(t => t.geo_region)
                .WithMany(t => t.ctries)
                .HasForeignKey(d => d.geo_region_id);

        }
    }
}
