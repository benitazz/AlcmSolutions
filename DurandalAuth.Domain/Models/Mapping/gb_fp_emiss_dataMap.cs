using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_emiss_dataMap : EntityTypeConfiguration<gb_fp_emiss_data>
    {
        public gb_fp_emiss_dataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.version_type, t.version_name, t.sector_name, t.fuel_base_code, t.fuel_mode, t.fuel_name });

            // Properties
            this.Property(t => t.units)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.units_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.version_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.sector_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

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
            this.ToTable("gb_fp_emiss_data", "afm");
            this.Property(t => t.ch4).HasColumnName("ch4");
            this.Property(t => t.ch4_entry).HasColumnName("ch4_entry");
            this.Property(t => t.n2o).HasColumnName("n2o");
            this.Property(t => t.n2o_entry).HasColumnName("n2o_entry");
            this.Property(t => t.units).HasColumnName("units");
            this.Property(t => t.units_type).HasColumnName("units_type");
            this.Property(t => t.version_type).HasColumnName("version_type");
            this.Property(t => t.version_name).HasColumnName("version_name");
            this.Property(t => t.sector_name).HasColumnName("sector_name");
            this.Property(t => t.fuel_base_code).HasColumnName("fuel_base_code");
            this.Property(t => t.fuel_mode).HasColumnName("fuel_mode");
            this.Property(t => t.fuel_name).HasColumnName("fuel_name");

            // Relationships
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.gb_fp_emiss_data)
                .HasForeignKey(d => d.units_type);
            this.HasRequired(t => t.bill_unit)
                .WithMany(t => t.gb_fp_emiss_data)
                .HasForeignKey(d => new { d.units_type, d.units });
            this.HasRequired(t => t.gb_fp_fuel_types)
                .WithMany(t => t.gb_fp_emiss_data)
                .HasForeignKey(d => d.fuel_base_code);
            this.HasRequired(t => t.gb_fp_fuels)
                .WithMany(t => t.gb_fp_emiss_data)
                .HasForeignKey(d => new { d.fuel_base_code, d.fuel_mode, d.fuel_name });
            this.HasRequired(t => t.gb_fp_versions)
                .WithMany(t => t.gb_fp_emiss_data)
                .HasForeignKey(d => new { d.version_type, d.version_name });

        }
    }
}
