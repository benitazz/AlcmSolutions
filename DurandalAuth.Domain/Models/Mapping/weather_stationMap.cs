using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class weather_stationMap : EntityTypeConfiguration<weather_station>
    {
        public weather_stationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.weather_source_id, t.weather_station_id });

            // Properties
            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.state_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.station_location)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.units_of_measure)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.weather_source_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.weather_station_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("weather_station", "afm");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.elevation).HasColumnName("elevation");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.state_id).HasColumnName("state_id");
            this.Property(t => t.station_location).HasColumnName("station_location");
            this.Property(t => t.units_of_measure).HasColumnName("units_of_measure");
            this.Property(t => t.weather_source_id).HasColumnName("weather_source_id");
            this.Property(t => t.weather_station_id).HasColumnName("weather_station_id");

            // Relationships
            this.HasRequired(t => t.weather_station_source)
                .WithMany(t => t.weather_station)
                .HasForeignKey(d => d.weather_source_id);

        }
    }
}
