using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class prop_amenityMap : EntityTypeConfiguration<prop_amenity>
    {
        public prop_amenityMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pr_id, t.amenity_type });

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.pr_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.amenity_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("prop_amenity", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.amenity_type).HasColumnName("amenity_type");

            // Relationships
            this.HasRequired(t => t.prop_amenity_type)
                .WithMany(t => t.prop_amenity)
                .HasForeignKey(d => d.amenity_type);
            this.HasRequired(t => t.property)
                .WithMany(t => t.prop_amenity)
                .HasForeignKey(d => d.pr_id);

        }
    }
}
