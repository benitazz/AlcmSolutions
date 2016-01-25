using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class weather_station_data_sumMap : EntityTypeConfiguration<weather_station_data_sum>
    {
        public weather_station_data_sumMap()
        {
            // Primary Key
            this.HasKey(t => new { t.weather_source_id, t.weather_station_id, t.year_reported, t.month_reported });

            // Properties
            this.Property(t => t.weather_source_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.weather_station_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.year_reported)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.month_reported)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("weather_station_data_sum", "afm");
            this.Property(t => t.sum_cdd).HasColumnName("sum_cdd");
            this.Property(t => t.sum_hdd).HasColumnName("sum_hdd");
            this.Property(t => t.weather_source_id).HasColumnName("weather_source_id");
            this.Property(t => t.weather_station_id).HasColumnName("weather_station_id");
            this.Property(t => t.year_reported).HasColumnName("year_reported");
            this.Property(t => t.month_reported).HasColumnName("month_reported");

            // Relationships
            this.HasRequired(t => t.weather_station_source)
                .WithMany(t => t.weather_station_data_sum)
                .HasForeignKey(d => d.weather_source_id);

        }
    }
}
