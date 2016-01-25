using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_s1_co_aircMap : EntityTypeConfiguration<gb_fp_s1_co_airc>
    {
        public gb_fp_s1_co_aircMap()
        {
            // Primary Key
            this.HasKey(t => t.source_id);

            // Properties
            this.Property(t => t.aircraft_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.scenario_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("gb_fp_s1_co_airc", "afm");
            this.Property(t => t.aircraft_type).HasColumnName("aircraft_type");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.calc_year).HasColumnName("calc_year");
            this.Property(t => t.hours).HasColumnName("hours");
            this.Property(t => t.kg_co2).HasColumnName("kg_co2");
            this.Property(t => t.scenario_id).HasColumnName("scenario_id");
            this.Property(t => t.source_id).HasColumnName("source_id");

            // Relationships
            this.HasRequired(t => t.gb_fp_setup)
                .WithMany(t => t.gb_fp_s1_co_airc)
                .HasForeignKey(d => new { d.bl_id, d.calc_year, d.scenario_id });

        }
    }
}
