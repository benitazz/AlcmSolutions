using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_incident_injury_areasMap : EntityTypeConfiguration<ehs_incident_injury_areas>
    {
        public ehs_incident_injury_areasMap()
        {
            // Primary Key
            this.HasKey(t => t.injury_area_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(256);

            this.Property(t => t.injury_area_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ehs_incident_injury_areas", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.injury_area_id).HasColumnName("injury_area_id");
        }
    }
}
