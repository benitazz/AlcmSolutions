#region

using System.Data.Entity.ModelConfiguration;

#endregion

namespace DurandalAuth.Domain.Models.Mapping
{
    /// <summary>
    /// The city map.
    /// </summary>
    public class CityMap : EntityTypeConfiguration<City>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CityMap"/> class.
        /// </summary>
        public CityMap()
        {
            // Primary Key
            this.HasKey(t => new { state_id = t.state_id, city_id = t.city_id });

            // Properties
            this.Property(t => t.ctry_id).IsFixedLength().HasMaxLength(16);

            this.Property(t => t.DetailDwg).IsFixedLength().HasMaxLength(64);

            this.Property(t => t.Dwgname).HasMaxLength(128);

            this.Property(t => t.Ehandle).HasMaxLength(64);

            this.Property(t => t.Name).IsFixedLength().HasMaxLength(32);

            this.Property(t => t.regn_id).IsFixedLength().HasMaxLength(16);

            this.Property(t => t.timezone_id).IsFixedLength().HasMaxLength(32);

            this.Property(t => t.state_id).IsRequired().IsFixedLength().HasMaxLength(4);

            this.Property(t => t.city_id).IsRequired().IsFixedLength().HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("city", "afm");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.DetailDwg).HasColumnName("detail_dwg");
            this.Property(t => t.Dwgname).HasColumnName("dwgname");
            this.Property(t => t.Ehandle).HasColumnName("ehandle");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.Lat).HasColumnName("lat");
            this.Property(t => t.Lon).HasColumnName("lon");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.regn_id).HasColumnName("regn_id");
            this.Property(t => t.timezone_id).HasColumnName("timezone_id");
            this.Property(t => t.state_id).HasColumnName("state_id");
            this.Property(t => t.city_id).HasColumnName("city_id");

            // Relationships
            this.HasOptional(t => t.AfmTimezones).WithMany(t => t.cities).HasForeignKey(d => d.timezone_id);
            this.HasOptional(t => t.Ctry).WithMany(t => t.cities).HasForeignKey(d => d.ctry_id);
            this.HasOptional(t => t.Regn)
                .WithMany(t => t.Cities)
                .HasForeignKey(d => new { ctry_id = d.ctry_id, regn_id = d.regn_id });
            this.HasRequired(t => t.State).WithMany(t => t.cities).HasForeignKey(d => d.state_id);
        }
    }
}