using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class bas_measurement_scopeMap : EntityTypeConfiguration<bas_measurement_scope>
    {
        public bas_measurement_scopeMap()
        {
            // Primary Key
            this.HasKey(t => t.measurement_scope_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.zone_id)
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("bas_measurement_scope", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.data_point_id).HasColumnName("data_point_id");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.zone_id).HasColumnName("zone_id");
            this.Property(t => t.measurement_scope_id).HasColumnName("measurement_scope_id");

            // Relationships
            this.HasRequired(t => t.bas_data_point)
                .WithMany(t => t.bas_measurement_scope)
                .HasForeignKey(d => d.data_point_id);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.bas_measurement_scope)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.eq)
                .WithMany(t => t.bas_measurement_scope)
                .HasForeignKey(d => d.eq_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.BasMeasurementScope)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.bas_measurement_scope)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.site)
                .WithMany(t => t.bas_measurement_scope)
                .HasForeignKey(d => d.site_id);
            this.HasOptional(t => t.zone)
                .WithMany(t => t.bas_measurement_scope)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.zone_id });

        }
    }
}
