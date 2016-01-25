using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_waste_liq_dataMap : EntityTypeConfiguration<gb_fp_waste_liq_data>
    {
        public gb_fp_waste_liq_dataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.version_type, t.version_name, t.treatment_id });

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

            this.Property(t => t.treatment_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            // Table & Column Mappings
            this.ToTable("gb_fp_waste_liq_data", "afm");
            this.Property(t => t.bod5_wastewater).HasColumnName("bod5_wastewater");
            this.Property(t => t.bod5_wastewater_entry).HasColumnName("bod5_wastewater_entry");
            this.Property(t => t.ch4_bod5).HasColumnName("ch4_bod5");
            this.Property(t => t.percent_anaerobic).HasColumnName("percent_anaerobic");
            this.Property(t => t.units).HasColumnName("units");
            this.Property(t => t.units_type).HasColumnName("units_type");
            this.Property(t => t.version_type).HasColumnName("version_type");
            this.Property(t => t.version_name).HasColumnName("version_name");
            this.Property(t => t.treatment_id).HasColumnName("treatment_id");

            // Relationships
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.gb_fp_waste_liq_data)
                .HasForeignKey(d => d.units_type);
            this.HasRequired(t => t.bill_unit)
                .WithMany(t => t.gb_fp_waste_liq_data)
                .HasForeignKey(d => new { d.units_type, d.units });
            this.HasRequired(t => t.gb_fp_versions)
                .WithMany(t => t.gb_fp_waste_liq_data)
                .HasForeignKey(d => new { d.version_type, d.version_name });

        }
    }
}
