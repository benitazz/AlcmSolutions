using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class waste_areasMap : EntityTypeConfiguration<waste_areas>
    {
        public waste_areasMap()
        {
            // Primary Key
            this.HasKey(t => t.storage_location);

            // Properties
            this.Property(t => t.area_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.site_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.storage_location)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("waste_areas", "afm");
            this.Property(t => t.area_type).HasColumnName("area_type");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.storage_location).HasColumnName("storage_location");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.waste_areas)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.WasteAreas)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.property)
                .WithMany(t => t.waste_areas)
                .HasForeignKey(d => d.pr_id);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.waste_areas)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasRequired(t => t.site)
                .WithMany(t => t.waste_areas)
                .HasForeignKey(d => d.site_id);

        }
    }
}
