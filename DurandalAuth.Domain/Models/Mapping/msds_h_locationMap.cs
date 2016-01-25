using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class msds_h_locationMap : EntityTypeConfiguration<msds_h_location>
    {
        public msds_h_locationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.auto_number, t.date_archived, t.time_archived });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(1024);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.evacuation_radius_units)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.evacuation_radius_units_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.pressure_units)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.pressure_units_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.quantity_units)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.quantity_units_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.temperature_units)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.container_cat)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.container_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.auto_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("msds_h_location", "afm");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.date_updated).HasColumnName("date_updated");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.evacuation_radius).HasColumnName("evacuation_radius");
            this.Property(t => t.evacuation_radius_units).HasColumnName("evacuation_radius_units");
            this.Property(t => t.evacuation_radius_units_type).HasColumnName("evacuation_radius_units_type");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.msds_id).HasColumnName("msds_id");
            this.Property(t => t.num_containers).HasColumnName("num_containers");
            this.Property(t => t.pressure).HasColumnName("pressure");
            this.Property(t => t.pressure_units).HasColumnName("pressure_units");
            this.Property(t => t.pressure_units_type).HasColumnName("pressure_units_type");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.quantity_units).HasColumnName("quantity_units");
            this.Property(t => t.quantity_units_type).HasColumnName("quantity_units_type");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.temperature).HasColumnName("temperature");
            this.Property(t => t.temperature_units).HasColumnName("temperature_units");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.container_cat).HasColumnName("container_cat");
            this.Property(t => t.container_type).HasColumnName("container_type");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
            this.Property(t => t.date_archived).HasColumnName("date_archived");
            this.Property(t => t.time_archived).HasColumnName("time_archived");
        }
    }
}
