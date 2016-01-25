using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_fuelsMap : EntityTypeConfiguration<gb_fp_fuels>
    {
        public gb_fp_fuelsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.fuel_base_code, t.fuel_mode, t.fuel_name });

            // Properties
            this.Property(t => t.fuel_es)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.fuel_base_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.fuel_mode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.fuel_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("gb_fp_fuels", "afm");
            this.Property(t => t.fuel_es).HasColumnName("fuel_es");
            this.Property(t => t.fuel_base_code).HasColumnName("fuel_base_code");
            this.Property(t => t.fuel_mode).HasColumnName("fuel_mode");
            this.Property(t => t.fuel_name).HasColumnName("fuel_name");

            // Relationships
            this.HasOptional(t => t.gb_fp_energystar_fuels)
                .WithMany(t => t.gb_fp_fuels)
                .HasForeignKey(d => d.fuel_es);
            this.HasRequired(t => t.gb_fp_fuel_types)
                .WithMany(t => t.gb_fp_fuels)
                .HasForeignKey(d => d.fuel_base_code);

        }
    }
}
