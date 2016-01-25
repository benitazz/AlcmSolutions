using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_incident_cause_catMap : EntityTypeConfiguration<ehs_incident_cause_cat>
    {
        public ehs_incident_cause_catMap()
        {
            // Primary Key
            this.HasKey(t => t.cause_category_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(256);

            this.Property(t => t.cause_category_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ehs_incident_cause_cat", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.cause_category_id).HasColumnName("cause_category_id");
        }
    }
}
