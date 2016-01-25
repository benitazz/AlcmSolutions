using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rm_amenityMap : EntityTypeConfiguration<rm_amenity>
    {
        public rm_amenityMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.fl_id, t.rm_id, t.amenity_type });

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rm_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.amenity_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("rm_amenity", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.amenity_type).HasColumnName("amenity_type");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.rm_amenity)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.RmAmenity)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasRequired(t => t.rm)
                .WithMany(t => t.rm_amenity)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasRequired(t => t.rm_amenity_type)
                .WithMany(t => t.rm_amenity)
                .HasForeignKey(d => d.amenity_type);

        }
    }
}
