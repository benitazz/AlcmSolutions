using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class msds_locationMap : EntityTypeConfiguration<msds_location>
    {
        public msds_locationMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.container_cat)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.container_type)
                .IsFixedLength()
                .HasMaxLength(32);

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

            // Table & Column Mappings
            this.ToTable("msds_location", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.container_cat).HasColumnName("container_cat");
            this.Property(t => t.container_type).HasColumnName("container_type");
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
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.bill_type)
                .WithMany(t => t.msds_location)
                .HasForeignKey(d => d.evacuation_radius_units_type);
            this.HasOptional(t => t.bill_type1)
                .WithMany(t => t.msds_location1)
                .HasForeignKey(d => d.pressure_units_type);
            this.HasOptional(t => t.bill_type2)
                .WithMany(t => t.msds_location2)
                .HasForeignKey(d => d.quantity_units_type);
            this.HasOptional(t => t.bill_unit)
                .WithMany(t => t.msds_location)
                .HasForeignKey(d => new { d.evacuation_radius_units_type, d.evacuation_radius_units });
            this.HasOptional(t => t.bill_unit1)
                .WithMany(t => t.msds_location1)
                .HasForeignKey(d => new { d.pressure_units_type, d.pressure_units });
            this.HasOptional(t => t.bill_unit2)
                .WithMany(t => t.msds_location2)
                .HasForeignKey(d => new { d.quantity_units_type, d.quantity_units });
            this.HasOptional(t => t.bl)
                .WithMany(t => t.msds_location)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.eq)
                .WithMany(t => t.msds_location)
                .HasForeignKey(d => d.eq_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.MsdsLocation)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.hazard_container_cat)
                .WithMany(t => t.msds_location)
                .HasForeignKey(d => d.container_cat);
            this.HasOptional(t => t.hazard_container_type)
                .WithMany(t => t.msds_location)
                .HasForeignKey(d => new { d.container_cat, d.container_type });
            this.HasRequired(t => t.msds_data)
                .WithMany(t => t.msds_location)
                .HasForeignKey(d => d.msds_id);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.msds_location)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.site)
                .WithMany(t => t.msds_location)
                .HasForeignKey(d => d.site_id);

        }
    }
}
