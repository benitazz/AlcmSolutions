using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class regnMap : EntityTypeConfiguration<regn>
    {
        public regnMap()
        {
            // Primary Key
            this.HasKey(t => new { ctry_id = t.ctry_id, regn_id = t.regn_id });

            // Properties
            this.Property(t => t.Hpattern)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.HpatternAcad)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.Name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ctry_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.regn_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("regn", "afm");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.Hpattern).HasColumnName("hpattern");
            this.Property(t => t.HpatternAcad).HasColumnName("hpattern_acad");
            this.Property(t => t.Lat).HasColumnName("lat");
            this.Property(t => t.Lon).HasColumnName("lon");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.regn_id).HasColumnName("regn_id");

            // Relationships
            this.HasRequired(t => t.Ctry)
                .WithMany(t => t.regns)
                .HasForeignKey(d => d.ctry_id);

        }
    }
}
