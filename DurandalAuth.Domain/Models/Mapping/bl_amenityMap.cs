using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class bl_amenityMap : EntityTypeConfiguration<bl_amenity>
    {
        public bl_amenityMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.amenity_type });

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.amenity_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("bl_amenity", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.amenity_type).HasColumnName("amenity_type");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.bl_amenity)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.prop_amenity_type)
                .WithMany(t => t.bl_amenity)
                .HasForeignKey(d => d.amenity_type);

        }
    }
}
