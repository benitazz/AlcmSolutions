using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_setupMap : EntityTypeConfiguration<gb_fp_setup>
    {
        public gb_fp_setupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.calc_year, t.scenario_id });

            // Properties
            this.Property(t => t.carbon_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.carbon_version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.comm_airc_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.comm_airc_version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.egrid_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.egrid_version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.emiss_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.emiss_version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.fuel_dens_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.fuel_dens_version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.gwp_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.gwp_version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.heat_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.heat_version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.mobile_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.mobile_version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.oxid_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.oxid_version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.refrig_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.refrig_version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.airc_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.airc_version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.sector_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.subregion_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.waste_liq_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.waste_liq_version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.waste_sol_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.waste_sol_version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.calc_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.scenario_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("gb_fp_setup", "afm");
            this.Property(t => t.carbon_version).HasColumnName("carbon_version");
            this.Property(t => t.carbon_version_type).HasColumnName("carbon_version_type");
            this.Property(t => t.comm_airc_version).HasColumnName("comm_airc_version");
            this.Property(t => t.comm_airc_version_type).HasColumnName("comm_airc_version_type");
            this.Property(t => t.count_occup).HasColumnName("count_occup");
            this.Property(t => t.egrid_version).HasColumnName("egrid_version");
            this.Property(t => t.egrid_version_type).HasColumnName("egrid_version_type");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.emiss_version).HasColumnName("emiss_version");
            this.Property(t => t.emiss_version_type).HasColumnName("emiss_version_type");
            this.Property(t => t.energystar_rating).HasColumnName("energystar_rating");
            this.Property(t => t.fuel_dens_version).HasColumnName("fuel_dens_version");
            this.Property(t => t.fuel_dens_version_type).HasColumnName("fuel_dens_version_type");
            this.Property(t => t.gwp_version).HasColumnName("gwp_version");
            this.Property(t => t.gwp_version_type).HasColumnName("gwp_version_type");
            this.Property(t => t.heat_version).HasColumnName("heat_version");
            this.Property(t => t.heat_version_type).HasColumnName("heat_version_type");
            this.Property(t => t.mobile_version).HasColumnName("mobile_version");
            this.Property(t => t.mobile_version_type).HasColumnName("mobile_version_type");
            this.Property(t => t.oxid_version).HasColumnName("oxid_version");
            this.Property(t => t.oxid_version_type).HasColumnName("oxid_version_type");
            this.Property(t => t.refrig_version).HasColumnName("refrig_version");
            this.Property(t => t.refrig_version_type).HasColumnName("refrig_version_type");
            this.Property(t => t.airc_version).HasColumnName("airc_version");
            this.Property(t => t.airc_version_type).HasColumnName("airc_version_type");
            this.Property(t => t.area_gross_ext).HasColumnName("area_gross_ext");
            this.Property(t => t.sector_name).HasColumnName("sector_name");
            this.Property(t => t.subregion_code).HasColumnName("subregion_code");
            this.Property(t => t.waste_liq_version).HasColumnName("waste_liq_version");
            this.Property(t => t.waste_liq_version_type).HasColumnName("waste_liq_version_type");
            this.Property(t => t.waste_sol_version).HasColumnName("waste_sol_version");
            this.Property(t => t.waste_sol_version_type).HasColumnName("waste_sol_version_type");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.calc_year).HasColumnName("calc_year");
            this.Property(t => t.scenario_id).HasColumnName("scenario_id");

            // Relationships
            this.HasRequired(t => t.gb_fp_versions)
                .WithMany(t => t.gb_fp_setup)
                .HasForeignKey(d => new { d.airc_version_type, d.airc_version });
            this.HasRequired(t => t.gb_fp_versions1)
                .WithMany(t => t.gb_fp_setup1)
                .HasForeignKey(d => new { d.carbon_version_type, d.carbon_version });
            this.HasRequired(t => t.gb_fp_versions2)
                .WithMany(t => t.gb_fp_setup2)
                .HasForeignKey(d => new { d.comm_airc_version_type, d.comm_airc_version });
            this.HasRequired(t => t.gb_fp_versions3)
                .WithMany(t => t.gb_fp_setup3)
                .HasForeignKey(d => new { d.egrid_version_type, d.egrid_version });
            this.HasRequired(t => t.gb_fp_versions4)
                .WithMany(t => t.gb_fp_setup4)
                .HasForeignKey(d => new { d.emiss_version_type, d.emiss_version });
            this.HasRequired(t => t.gb_fp_versions5)
                .WithMany(t => t.gb_fp_setup5)
                .HasForeignKey(d => new { d.fuel_dens_version_type, d.fuel_dens_version });
            this.HasRequired(t => t.gb_fp_versions6)
                .WithMany(t => t.gb_fp_setup6)
                .HasForeignKey(d => new { d.gwp_version_type, d.gwp_version });
            this.HasRequired(t => t.gb_fp_versions7)
                .WithMany(t => t.gb_fp_setup7)
                .HasForeignKey(d => new { d.heat_version_type, d.heat_version });
            this.HasRequired(t => t.gb_fp_versions8)
                .WithMany(t => t.gb_fp_setup8)
                .HasForeignKey(d => new { d.mobile_version_type, d.mobile_version });
            this.HasRequired(t => t.gb_fp_versions9)
                .WithMany(t => t.gb_fp_setup9)
                .HasForeignKey(d => new { d.oxid_version_type, d.oxid_version });
            this.HasRequired(t => t.gb_fp_versions10)
                .WithMany(t => t.gb_fp_setup10)
                .HasForeignKey(d => new { d.refrig_version_type, d.refrig_version });
            this.HasRequired(t => t.gb_fp_versions11)
                .WithMany(t => t.gb_fp_setup11)
                .HasForeignKey(d => new { d.waste_liq_version_type, d.waste_liq_version });
            this.HasRequired(t => t.gb_fp_versions12)
                .WithMany(t => t.gb_fp_setup12)
                .HasForeignKey(d => new { d.waste_sol_version_type, d.waste_sol_version });

        }
    }
}
