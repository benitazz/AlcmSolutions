using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_s_otherMap : EntityTypeConfiguration<gb_fp_s_other>
    {
        public gb_fp_s_otherMap()
        {
            // Primary Key
            this.HasKey(t => t.source_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.scenario_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.source_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("gb_fp_s_other", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.calc_year).HasColumnName("calc_year");
            this.Property(t => t.mt_co2).HasColumnName("mt_co2");
            this.Property(t => t.scenario_id).HasColumnName("scenario_id");
            this.Property(t => t.source_name).HasColumnName("source_name");
            this.Property(t => t.source_id).HasColumnName("source_id");

            // Relationships
            this.HasRequired(t => t.gb_fp_setup)
                .WithMany(t => t.gb_fp_s_other)
                .HasForeignKey(d => new { d.bl_id, d.calc_year, d.scenario_id });

        }
    }
}
