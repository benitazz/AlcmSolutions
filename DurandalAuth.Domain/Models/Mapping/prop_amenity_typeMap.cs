using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class prop_amenity_typeMap : EntityTypeConfiguration<prop_amenity_type>
    {
        public prop_amenity_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.amenity_type);

            // Properties
            this.Property(t => t.amenity_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("prop_amenity_type", "afm");
            this.Property(t => t.amenity_type).HasColumnName("amenity_type");
        }
    }
}
