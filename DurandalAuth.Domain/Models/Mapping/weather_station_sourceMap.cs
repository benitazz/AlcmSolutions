using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class weather_station_sourceMap : EntityTypeConfiguration<weather_station_source>
    {
        public weather_station_sourceMap()
        {
            // Primary Key
            this.HasKey(t => t.weather_source_id);

            // Properties
            this.Property(t => t.access_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.access_pwd)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.protocol)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.url_address)
                .HasMaxLength(256);

            this.Property(t => t.weather_source_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("weather_station_source", "afm");
            this.Property(t => t.access_id).HasColumnName("access_id");
            this.Property(t => t.access_pwd).HasColumnName("access_pwd");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.protocol).HasColumnName("protocol");
            this.Property(t => t.url_address).HasColumnName("url_address");
            this.Property(t => t.weather_source_id).HasColumnName("weather_source_id");
        }
    }
}
