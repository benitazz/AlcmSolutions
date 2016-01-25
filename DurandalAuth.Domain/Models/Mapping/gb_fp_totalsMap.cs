using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_totalsMap : EntityTypeConfiguration<gb_fp_totals>
    {
        public gb_fp_totalsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.calc_year, t.scenario_id });

            // Properties
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
            this.ToTable("gb_fp_totals", "afm");
            this.Property(t => t.s_other).HasColumnName("s_other");
            this.Property(t => t.s1_co_airc).HasColumnName("s1_co_airc");
            this.Property(t => t.s1_co_road).HasColumnName("s1_co_road");
            this.Property(t => t.s1_fuel_comb).HasColumnName("s1_fuel_comb");
            this.Property(t => t.s1_refrig_airc).HasColumnName("s1_refrig_airc");
            this.Property(t => t.s2_purch_e).HasColumnName("s2_purch_e");
            this.Property(t => t.s3_cont).HasColumnName("s3_cont");
            this.Property(t => t.s3_em_air).HasColumnName("s3_em_air");
            this.Property(t => t.s3_em_rail).HasColumnName("s3_em_rail");
            this.Property(t => t.s3_em_road).HasColumnName("s3_em_road");
            this.Property(t => t.s3_mat).HasColumnName("s3_mat");
            this.Property(t => t.s3_outs).HasColumnName("s3_outs");
            this.Property(t => t.s3_serv).HasColumnName("s3_serv");
            this.Property(t => t.s3_waste_liq).HasColumnName("s3_waste_liq");
            this.Property(t => t.s3_waste_sol).HasColumnName("s3_waste_sol");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.total_s1_s2_s_other).HasColumnName("total_s1_s2_s_other");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.calc_year).HasColumnName("calc_year");
            this.Property(t => t.scenario_id).HasColumnName("scenario_id");

            // Relationships
            this.HasRequired(t => t.gb_fp_setup)
                .WithOptional(t => t.gb_fp_totals);

        }
    }
}
