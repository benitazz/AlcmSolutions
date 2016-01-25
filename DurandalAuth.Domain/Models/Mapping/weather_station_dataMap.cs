using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class weather_station_dataMap : EntityTypeConfiguration<weather_station_data>
    {
        public weather_station_dataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.weather_source_id, t.weather_station_id, t.date_reported });

            // Properties
            this.Property(t => t.weather_source_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.weather_station_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("weather_station_data", "afm");
            this.Property(t => t.estimated).HasColumnName("estimated");
            this.Property(t => t.temp_outside_air).HasColumnName("temp_outside_air");
            this.Property(t => t.weather_source_id).HasColumnName("weather_source_id");
            this.Property(t => t.weather_station_id).HasColumnName("weather_station_id");
            this.Property(t => t.date_reported).HasColumnName("date_reported");

            // Relationships
            this.HasRequired(t => t.weather_station_source)
                .WithMany(t => t.weather_station_data)
                .HasForeignKey(d => d.weather_source_id);

        }
    }
}
