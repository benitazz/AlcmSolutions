using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class property_typeMap : EntityTypeConfiguration<property_type>
    {
        public property_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.property_type1);

            // Properties
            this.Property(t => t.deprec_method)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.property_type1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("property_type", "afm");
            this.Property(t => t.deprec_method).HasColumnName("deprec_method");
            this.Property(t => t.deprec_period).HasColumnName("deprec_period");
            this.Property(t => t.property_type1).HasColumnName("property_type");
        }
    }
}
