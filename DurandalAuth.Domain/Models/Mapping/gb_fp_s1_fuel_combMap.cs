using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_s1_fuel_combMap : EntityTypeConfiguration<gb_fp_s1_fuel_comb>
    {
        public gb_fp_s1_fuel_combMap()
        {
            // Primary Key
            this.HasKey(t => t.source_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.ch4_n2o_units)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ch4_n2o_units_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

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

            this.Property(t => t.fuel_units)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.fuel_units_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.scenario_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.sector_name)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.source_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.tech_base_code)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.tech_mode)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.technology)
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("gb_fp_s1_fuel_comb", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.calc_year).HasColumnName("calc_year");
            this.Property(t => t.ch4_n2o_units).HasColumnName("ch4_n2o_units");
            this.Property(t => t.ch4_n2o_units_type).HasColumnName("ch4_n2o_units_type");
            this.Property(t => t.emiss_factor_ch4_entry).HasColumnName("emiss_factor_ch4_entry");
            this.Property(t => t.emiss_factor_ch4_val).HasColumnName("emiss_factor_ch4_val");
            this.Property(t => t.emiss_factor_n2o_entry).HasColumnName("emiss_factor_n2o_entry");
            this.Property(t => t.emiss_factor_n2o_val).HasColumnName("emiss_factor_n2o_val");
            this.Property(t => t.fuel_base_code).HasColumnName("fuel_base_code");
            this.Property(t => t.fuel_consumed).HasColumnName("fuel_consumed");
            this.Property(t => t.fuel_consumed_entry).HasColumnName("fuel_consumed_entry");
            this.Property(t => t.fuel_mode).HasColumnName("fuel_mode");
            this.Property(t => t.fuel_name).HasColumnName("fuel_name");
            this.Property(t => t.fuel_units).HasColumnName("fuel_units");
            this.Property(t => t.fuel_units_type).HasColumnName("fuel_units_type");
            this.Property(t => t.kg_co2).HasColumnName("kg_co2");
            this.Property(t => t.oxid_factor_val).HasColumnName("oxid_factor_val");
            this.Property(t => t.scenario_id).HasColumnName("scenario_id");
            this.Property(t => t.sector_name).HasColumnName("sector_name");
            this.Property(t => t.source_name).HasColumnName("source_name");
            this.Property(t => t.tech_base_code).HasColumnName("tech_base_code");
            this.Property(t => t.tech_mode).HasColumnName("tech_mode");
            this.Property(t => t.technology).HasColumnName("technology");
            this.Property(t => t.source_id).HasColumnName("source_id");

            // Relationships
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.gb_fp_s1_fuel_comb)
                .HasForeignKey(d => d.ch4_n2o_units_type);
            this.HasRequired(t => t.bill_type1)
                .WithMany(t => t.gb_fp_s1_fuel_comb1)
                .HasForeignKey(d => d.fuel_units_type);
            this.HasRequired(t => t.bill_unit)
                .WithMany(t => t.gb_fp_s1_fuel_comb)
                .HasForeignKey(d => new { d.ch4_n2o_units_type, d.ch4_n2o_units });
            this.HasRequired(t => t.bill_unit1)
                .WithMany(t => t.gb_fp_s1_fuel_comb1)
                .HasForeignKey(d => new { d.fuel_units_type, d.fuel_units });
            this.HasRequired(t => t.gb_fp_fuel_types)
                .WithMany(t => t.gb_fp_s1_fuel_comb)
                .HasForeignKey(d => d.fuel_base_code);
            this.HasOptional(t => t.gb_fp_fuel_types1)
                .WithMany(t => t.gb_fp_s1_fuel_comb1)
                .HasForeignKey(d => d.tech_base_code);
            this.HasRequired(t => t.gb_fp_fuels)
                .WithMany(t => t.gb_fp_s1_fuel_comb)
                .HasForeignKey(d => new { d.fuel_base_code, d.fuel_mode, d.fuel_name });
            this.HasOptional(t => t.gb_fp_fuels1)
                .WithMany(t => t.gb_fp_s1_fuel_comb1)
                .HasForeignKey(d => new { d.tech_base_code, d.tech_mode, d.technology });
            this.HasRequired(t => t.gb_fp_setup)
                .WithMany(t => t.gb_fp_s1_fuel_comb)
                .HasForeignKey(d => new { d.bl_id, d.calc_year, d.scenario_id });

        }
    }
}
