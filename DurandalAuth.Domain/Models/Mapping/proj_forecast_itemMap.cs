using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class proj_forecast_itemMap : EntityTypeConfiguration<proj_forecast_item>
    {
        public proj_forecast_itemMap()
        {
            // Primary Key
            this.HasKey(t => t.proj_forecast_item_id);

            // Properties
            this.Property(t => t.created_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.proj_forecast_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.project_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.work_pkg_id)
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("proj_forecast_item", "afm");
            this.Property(t => t.cost_forecast).HasColumnName("cost_forecast");
            this.Property(t => t.created_by).HasColumnName("created_by");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.date_forecast).HasColumnName("date_forecast");
            this.Property(t => t.proj_forecast_id).HasColumnName("proj_forecast_id");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.work_pkg_id).HasColumnName("work_pkg_id");
            this.Property(t => t.proj_forecast_item_id).HasColumnName("proj_forecast_item_id");

            // Relationships
            this.HasOptional(t => t.proj_forecast)
                .WithMany(t => t.proj_forecast_item)
                .HasForeignKey(d => new { d.project_id, d.proj_forecast_id });
            this.HasOptional(t => t.project)
                .WithMany(t => t.proj_forecast_item)
                .HasForeignKey(d => d.project_id);
            this.HasOptional(t => t.work_pkgs)
                .WithMany(t => t.proj_forecast_item)
                .HasForeignKey(d => new { d.project_id, d.work_pkg_id });

        }
    }
}
