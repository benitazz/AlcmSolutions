using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class countyMap : EntityTypeConfiguration<County>
    {
        public countyMap()
        {
            // Primary Key
            this.HasKey(t => new { state_id = t.state_id, county_id = t.county_id });

            // Properties
            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Dwgname)
                .HasMaxLength(128);

            this.Property(t => t.Ehandle)
                .HasMaxLength(64);

            this.Property(t => t.Name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.regn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.state_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.county_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("county", "afm");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.Dwgname).HasColumnName("dwgname");
            this.Property(t => t.Ehandle).HasColumnName("ehandle");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.Lat).HasColumnName("lat");
            this.Property(t => t.Lon).HasColumnName("lon");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.regn_id).HasColumnName("regn_id");
            this.Property(t => t.state_id).HasColumnName("state_id");
            this.Property(t => t.county_id).HasColumnName("county_id");

            // Relationships
            this.HasOptional(t => t.Ctry)
                .WithMany(t => t.counties)
                .HasForeignKey(d => d.ctry_id);
            this.HasOptional(t => t.Regn)
                .WithMany(t => t.Counties)
                .HasForeignKey(d => new { ctry_id = d.ctry_id, regn_id = d.regn_id });
            this.HasRequired(t => t.State)
                .WithMany(t => t.counties)
                .HasForeignKey(d => d.state_id);

        }
    }
}
