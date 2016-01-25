using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_waste_sol_dataMap : EntityTypeConfiguration<gb_fp_waste_sol_data>
    {
        public gb_fp_waste_sol_dataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.version_type, t.version_name, t.waste_name });

            // Properties
            this.Property(t => t.composition)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

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

            this.Property(t => t.waste_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("gb_fp_waste_sol_data", "afm");
            this.Property(t => t.carbon_sequestration).HasColumnName("carbon_sequestration");
            this.Property(t => t.carbon_sequestration_entry).HasColumnName("carbon_sequestration_entry");
            this.Property(t => t.combustion).HasColumnName("combustion");
            this.Property(t => t.combustion_entry).HasColumnName("combustion_entry");
            this.Property(t => t.composite_disposal).HasColumnName("composite_disposal");
            this.Property(t => t.composite_disposal_entry).HasColumnName("composite_disposal_entry");
            this.Property(t => t.composite_downstream).HasColumnName("composite_downstream");
            this.Property(t => t.composite_downstream_entry).HasColumnName("composite_downstream_entry");
            this.Property(t => t.composition).HasColumnName("composition");
            this.Property(t => t.landfilling).HasColumnName("landfilling");
            this.Property(t => t.landfilling_entry).HasColumnName("landfilling_entry");
            this.Property(t => t.manufacture_mix).HasColumnName("manufacture_mix");
            this.Property(t => t.manufacture_mix_entry).HasColumnName("manufacture_mix_entry");
            this.Property(t => t.manufacture_recycled).HasColumnName("manufacture_recycled");
            this.Property(t => t.manufacture_recycled_entry).HasColumnName("manufacture_recycled_entry");
            this.Property(t => t.raw_acquisition).HasColumnName("raw_acquisition");
            this.Property(t => t.raw_acquisition_entry).HasColumnName("raw_acquisition_entry");
            this.Property(t => t.recycling).HasColumnName("recycling");
            this.Property(t => t.recycling_entry).HasColumnName("recycling_entry");
            this.Property(t => t.units).HasColumnName("units");
            this.Property(t => t.units_type).HasColumnName("units_type");
            this.Property(t => t.version_type).HasColumnName("version_type");
            this.Property(t => t.version_name).HasColumnName("version_name");
            this.Property(t => t.waste_name).HasColumnName("waste_name");

            // Relationships
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.gb_fp_waste_sol_data)
                .HasForeignKey(d => d.units_type);
            this.HasRequired(t => t.bill_unit)
                .WithMany(t => t.gb_fp_waste_sol_data)
                .HasForeignKey(d => new { d.units_type, d.units });
            this.HasRequired(t => t.gb_fp_versions)
                .WithMany(t => t.gb_fp_waste_sol_data)
                .HasForeignKey(d => new { d.version_type, d.version_name });

        }
    }
}
