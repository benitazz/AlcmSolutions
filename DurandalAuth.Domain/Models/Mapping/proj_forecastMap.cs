using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class proj_forecastMap : EntityTypeConfiguration<proj_forecast>
    {
        public proj_forecastMap()
        {
            // Primary Key
            this.HasKey(t => new { t.project_id, t.proj_forecast_id });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.project_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.proj_forecast_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("proj_forecast", "afm");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.proj_forecast_id).HasColumnName("proj_forecast_id");

            // Relationships
            this.HasRequired(t => t.project)
                .WithMany(t => t.proj_forecast)
                .HasForeignKey(d => d.project_id);

        }
    }
}
