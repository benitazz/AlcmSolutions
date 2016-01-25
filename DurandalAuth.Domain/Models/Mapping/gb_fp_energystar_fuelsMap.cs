using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_energystar_fuelsMap : EntityTypeConfiguration<gb_fp_energystar_fuels>
    {
        public gb_fp_energystar_fuelsMap()
        {
            // Primary Key
            this.HasKey(t => t.fuel_es);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(128);

            this.Property(t => t.fuel_es)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("gb_fp_energystar_fuels", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.fuel_es).HasColumnName("fuel_es");
        }
    }
}
