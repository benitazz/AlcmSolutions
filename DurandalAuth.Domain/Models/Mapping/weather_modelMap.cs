using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class weather_modelMap : EntityTypeConfiguration<weather_model>
    {
        public weather_modelMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.time_period, t.model_type, t.aggregation_type });

            // Properties
            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.time_period)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.model_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.aggregation_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("weather_model", "afm");
            this.Property(t => t.coefficient_base_load).HasColumnName("coefficient_base_load");
            this.Property(t => t.coefficient_cdd).HasColumnName("coefficient_cdd");
            this.Property(t => t.coefficient_hdd).HasColumnName("coefficient_hdd");
            this.Property(t => t.cooling).HasColumnName("cooling");
            this.Property(t => t.heating).HasColumnName("heating");
            this.Property(t => t.oat_c1).HasColumnName("oat_c1");
            this.Property(t => t.oat_c2).HasColumnName("oat_c2");
            this.Property(t => t.oat_h1).HasColumnName("oat_h1");
            this.Property(t => t.oat_h2).HasColumnName("oat_h2");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.time_period).HasColumnName("time_period");
            this.Property(t => t.model_type).HasColumnName("model_type");
            this.Property(t => t.aggregation_type).HasColumnName("aggregation_type");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.weather_model)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.energy_time_period)
                .WithMany(t => t.weather_model)
                .HasForeignKey(d => d.time_period);

        }
    }
}
