using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class compliance_locationsMap : EntityTypeConfiguration<compliance_locations>
    {
        public compliance_locationsMap()
        {
            // Primary Key
            this.HasKey(t => t.location_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.city_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.county_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.eq_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.geo_region_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.regn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.state_id)
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("compliance_locations", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.city_id).HasColumnName("city_id");
            this.Property(t => t.county_id).HasColumnName("county_id");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.geo_region_id).HasColumnName("geo_region_id");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.regn_id).HasColumnName("regn_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.state_id).HasColumnName("state_id");
            this.Property(t => t.location_id).HasColumnName("location_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.compliance_locations)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.city)
                .WithMany(t => t.ComplianceLocations)
                .HasForeignKey(d => new { d.state_id, d.city_id });
            this.HasOptional(t => t.county)
                .WithMany(t => t.ComplianceLocations)
                .HasForeignKey(d => new { d.state_id, d.county_id });
            this.HasOptional(t => t.ctry)
                .WithMany(t => t.compliance_locations)
                .HasForeignKey(d => d.ctry_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.ComplianceLocations)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.eq)
                .WithMany(t => t.compliance_locations)
                .HasForeignKey(d => d.eq_id);
            this.HasOptional(t => t.eqstd)
                .WithMany(t => t.compliance_locations)
                .HasForeignKey(d => d.eq_std);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.ComplianceLocations)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.geo_region)
                .WithMany(t => t.compliance_locations)
                .HasForeignKey(d => d.geo_region_id);
            this.HasOptional(t => t.property)
                .WithMany(t => t.compliance_locations)
                .HasForeignKey(d => d.pr_id);
            this.HasOptional(t => t.regn)
                .WithMany(t => t.ComplianceLocations)
                .HasForeignKey(d => new { d.ctry_id, d.regn_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.compliance_locations)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.site)
                .WithMany(t => t.compliance_locations)
                .HasForeignKey(d => d.site_id);
            this.HasOptional(t => t.state)
                .WithMany(t => t.compliance_locations)
                .HasForeignKey(d => d.state_id);

        }
    }
}
