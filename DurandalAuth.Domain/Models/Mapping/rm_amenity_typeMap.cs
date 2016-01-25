using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rm_amenity_typeMap : EntityTypeConfiguration<rm_amenity_type>
    {
        public rm_amenity_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.amenity_type);

            // Properties
            this.Property(t => t.amenity_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("rm_amenity_type", "afm");
            this.Property(t => t.amenity_type).HasColumnName("amenity_type");
        }
    }
}
