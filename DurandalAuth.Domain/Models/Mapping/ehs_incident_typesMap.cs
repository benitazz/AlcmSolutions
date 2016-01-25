using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_incident_typesMap : EntityTypeConfiguration<ehs_incident_types>
    {
        public ehs_incident_typesMap()
        {
            // Primary Key
            this.HasKey(t => t.incident_type);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(256);

            this.Property(t => t.incident_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ehs_incident_types", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.notification).HasColumnName("notification");
            this.Property(t => t.incident_type).HasColumnName("incident_type");
        }
    }
}
