using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_fuel_typesMap : EntityTypeConfiguration<gb_fp_fuel_types>
    {
        public gb_fp_fuel_typesMap()
        {
            // Primary Key
            this.HasKey(t => t.fuel_base_code);

            // Properties
            this.Property(t => t.fuel_base_name)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.fuel_base_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("gb_fp_fuel_types", "afm");
            this.Property(t => t.fuel_base_name).HasColumnName("fuel_base_name");
            this.Property(t => t.fuel_base_code).HasColumnName("fuel_base_code");
        }
    }
}
